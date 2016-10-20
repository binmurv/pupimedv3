using MetroFramework.Forms;
using PUPiMed.UserControls;
using System;
using System.Drawing;

namespace PUPiMed.Forms
{
    public partial class FormAddBranches : MetroForm
    {
        public string strCode, strName, strACode, strNo, strStreet, strTown, strCity, query;
        private FormAddDistribItem formAddDistribItem;
        UCBranches ucBranches;
        private bool new_;

        public FormAddBranches()
        {
            InitializeComponent();
            getCode();
        }

        public FormAddBranches(UCBranches ucBranches, bool new_) : this()
        {
            this.ucBranches = ucBranches;
            this.new_ = new_;
        }

        public FormAddBranches(FormAddDistribItem formAddDistribItem) : this()
        {
            this.formAddDistribItem = formAddDistribItem;
            this.new_ = true;
        }

        private void getCode()
        {
            string prevCode = Program.getPrevCode("SELECT strBranCode from tblBranch ORDER by char_length(strBranCode) DESC, strBranCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                this.txtCode.Enabled = true;
                this.txtCode.Focus();
            }
            else
            {
                strCode = Program.getNextCode(prevCode);
                this.txtCode.Text = strCode;
                this.txtCode.Enabled = false;
                this.txtName.Focus();
            }
        }

        private bool everythingIsOkay()
        {
            strCode = txtCode.Text;
            strName = txtName.Text;
            strNo = txtNo.Text;
            strStreet = txtStreet.Text;
            strTown = txtTown.Text;
            strCity = txtCity.Text;

            if (string.IsNullOrEmpty(strCode) || string.IsNullOrEmpty(strName) || string.IsNullOrEmpty(strTown) || string.IsNullOrEmpty(strCity))
            {
                return false;
            }
            return true;
        }
        private void getAddressCode()
        {
            //check if there's a prev address code
            //default ADDR-000
            //increment if there's one
            string prevCode = Program.getPrevCode("SELECT strAddrCode from tblAddress ORDER by char_length(strAddrCode) DESC, strAddrCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                strACode = "ADDR-000";
            }
            else
            {
                if (new_)
                    strACode = Program.getNextCode(prevCode);
            }
        }

        

        private bool saveAddress()
        {
            string query;
            if (new_ || string.IsNullOrEmpty(Program.getPrevCode("SELECT strBranAddrCode FROM tblBranch WHERE strBranCode LIKE '"+strCode+"'"))) {
                query = "INSERT INTO tblAddress (`strAddrCode`, `strAddrNum`, `strAddrStreet`, `strAddrTown`, `strAddrCity`, strAddrAdded) VALUES('" + strACode + "','" + strNo + "','" + strStreet + "','" + strTown + "','" + strCity + "', USER());";
            }
            else
            {
                query = "UPDATE tblAddress SET strAddrNum='"+strNo+"', strAddrStreet='"+strStreet+"', strAddrTown='"+strTown+"', strAddrCity='"+strCity+"' WHERE strAddrCode='"+strACode+"';";
            }

            if (!Program.ExecuteQuery(query))
            {
                status.Text = "Failed to save address";
                status.BackColor = Color.Tomato;
                return false;
            }
            return true;
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ucBranches != null)
                this.ucBranches.updateTable();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getAddressCode();
            getCode();
            if (everythingIsOkay())
            {
                if (saveAddress())
                {
                    if (string.IsNullOrEmpty(Program.getNextCode(strCode)))
                    {
                        txtCode.Focus();
                        status.Text = "Invalid code";
                        status.BackColor = Color.Tomato;
                    }
                    else
                    {
                        if (new_)
                        {
                            query = "INSERT INTO tblbranch (`strBranCode`, `strBranDesc`, `strBranAddrCode`, strBranAdded)  VALUES('" + strCode + "','" + strName + "','" + strACode + "', USER());";
                        }
                        else
                        {
                            query = "UPDATE tblbranch SET strBranCode='" + strCode + "', strBranDesc='" + strName + "', strBranAddrCode='" + strACode + "' WHERE strBranCode='" + strCode + "';";
                        }
                        //save to db
                        if (!Program.ExecuteQuery(query))
                        {
                            //tell them something's wrong
                            status.Text = "Failed to save branch";
                            status.BackColor = Color.Tomato;
                        }
                        else
                        {
                            getCode();
                            txtCode.Text = strCode;
                            txtName.Clear();
                            txtName.Focus();
                            txtNo.Clear();
                            txtStreet.Clear();
                            txtTown.Clear();
                            txtCity.Clear();
                            status.Text = "Saved";
                            status.BackColor = Color.LimeGreen;
                            if (formAddDistribItem != null)
                                formAddDistribItem.loadBranches();
                            if (ucBranches != null)
                                ucBranches.updateTable();
                            if (!new_)
                                this.Dispose();
                        }
                    }
                }
            }
            else
            {
                //tell them it's not :(
                status.Text = "Please fill out all the required fields";
                status.BackColor = Color.Tomato;
            }
        }
    }
}
