using MetroFramework.Forms;
using System;
using System.Drawing;
using PUPiMed.UserControls;

namespace PUPiMed.Forms
{
    public partial class FormAddManufacturer : MetroForm
    {
        public string strCode, strName, strACode, strNo, strStreet, strTown, strCity;
        private FormAddItem formAddItem;
        private UCManufacturer ucManufacturer;
        bool new_;

        public FormAddManufacturer(FormAddItem addItem, int index)
        {
            InitializeComponent();
            this.formAddItem = addItem;
            cbItemType.SelectedIndex = index;
            cbItemType.Enabled = false;
            this.new_ = true;
            getCode();
        }
        public FormAddManufacturer()
        {
            InitializeComponent();
            getCode();
            cbItemType.SelectedIndex = 0;
        }

        public FormAddManufacturer(UCManufacturer uCManufacturer, bool new_) : this()
        {
            this.ucManufacturer = uCManufacturer;
            this.new_ = new_;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ucManufacturer != null)
                this.ucManufacturer.updateTable();
            this.Dispose();
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCode();
            if (everythingIsOkay())
            {
                if (addressIsOkay())
                {
                    if (string.IsNullOrEmpty(Program.getNextCode(strCode)))
                    {
                        txtCode.Focus();
                        status.Text = "Invalid code";
                        status.BackColor = Color.Tomato;
                    }
                    else
                    {
                        string query;
                        //save to db
                        if (new_)
                        {
                            query = "INSERT INTO tblmanufacturer (`strManuCode`, `strManuName`, `intManuType`, `strManuAddrCode`, `strManuAdded`) VALUES('" + strCode + "','" + strName + "','" + (cbItemType.SelectedIndex < 1 ? 1 : cbItemType.SelectedIndex + 1) + "','" + strACode + "', USER());";
                        }
                        else
                        {
                            query = "UPDATE tblManufacturer SET strManuCode='" + strCode + "', intManuType="+ (cbItemType.SelectedIndex < 1 ? 1 : cbItemType.SelectedIndex + 1) + ",strManuName='" + strName + "', strManuAddrCode='" + strACode + "' WHERE strManuCode='" + strCode + "';";
                        }
                        //save to db
                        if (!Program.ExecuteQuery(query))
                        {
                            //tell them something's wrong
                            status.Text = "Failed to save manufacturer";
                            status.BackColor = Color.Tomato;
                        }
                        else
                        {
                            strCode = Program.getNextCode(strCode);
                            txtCode.Text = strCode;
                            txtName.Clear();
                            txtName.Focus();
                            txtNo.Clear();
                            txtStreet.Clear();
                            txtTown.Clear();
                            txtCity.Clear();
                            cbItemType.SelectedIndex = 0;
                            status.Text = "Saved";
                            status.BackColor = Color.LimeGreen;
                            if (formAddItem != null)
                                formAddItem.loadManufacturer();
                            if (!new_)
                            {
                                this.ucManufacturer.updateTable();
                                this.Dispose();
                            }
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

        private void txtName_Click(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
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
        private bool addressIsOkay()
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

            return saveAddress();
        }
        private bool saveAddress()
        {
            string query;
            if (new_)
            {
                query = "INSERT INTO tblAddress (`strAddrCode`, `strAddrNum`, `strAddrStreet`, `strAddrTown`, `strAddrCity`, strAddrAdded) VALUES('" + strACode + "','" + strNo + "','" + strStreet + "','" + strTown + "','" + strCity + "', USER());";
            }
            else
            {
                query = "UPDATE tblAddress SET strAddrNum='" + strNo + "', strAddrStreet='" + strStreet + "', strAddrTown='" + strTown + "', strAddrCity='" + strCity + "' WHERE strAddrCode='" + strACode + "';";
            }

            if (!Program.ExecuteQuery(query))
            {
                status.Text = "Failed to save address";
                status.BackColor = Color.Tomato;
                return false;
            }
            return true;
        }
        private void getCode()
        {
            string prevCode = Program.getPrevCode("SELECT strManuCode from tblManufacturer ORDER by char_length(strManuCode) DESC, strManuCode DESC LIMIT 1;");
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
    }
}
