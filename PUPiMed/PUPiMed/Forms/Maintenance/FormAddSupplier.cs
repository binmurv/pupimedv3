using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using PUPiMed.UserControls;

namespace PUPiMed
{
    public partial class FormAddSupplier : MetroForm
    {
        public string strCode, strName, strACode, strContact, strEmail, strNo, strStreet, strTown, strCity;
        private FormReceiveInventory formReceiveInventory;
        private UCSupplier uCSupplier;
        private bool new_;

        public FormAddSupplier()
        {
            InitializeComponent();
            getCode();
        }

        public FormAddSupplier(FormReceiveInventory formReceiveInventory) : this()
        {
            this.formReceiveInventory = formReceiveInventory;
            this.new_ = true;
        }

        public FormAddSupplier(UCSupplier uCSupplier) : this()
        {
            this.uCSupplier = uCSupplier;
            this.new_ = true;
        }

        public FormAddSupplier(UCSupplier uCSupplier, bool new_) : this(uCSupplier)
        {
            this.new_ = new_;
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtCode.Text))
                txtCode.ForeColor = Color.White;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        private void lblother_Click(object sender, EventArgs e)
        {

        }

        private void getCode()
        {
            string prevCode = Program.getPrevCode("SELECT strSuppCode from tblSupplier ORDER by char_length(strSuppCode) DESC, strSuppCode DESC LIMIT 1;");
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
            strContact = txtContact.Text;
            strEmail = txtEmail.Text;
            strNo = txtNo.Text;
            strStreet = txtStreet.Text;
            strTown = txtTown.Text;
            strCity = txtCity.Text;

            if (string.IsNullOrEmpty(strCode)|| string.IsNullOrEmpty(strName) || string.IsNullOrEmpty(strContact) || string.IsNullOrEmpty(strEmail) ||  string.IsNullOrEmpty(strTown) || string.IsNullOrEmpty(strCity))
            {
                //check if email is valid
                 return false;
            }
            return true;
        }
        private bool addressIsOkay()
        {
            //check if there's a prev address code
            //default ADDR-000
            //increment if there's one
            string prevCode = Program.getPrevCode("SELECT strAddrCode from tblAddress ORDER by char_length(strAddrCode) DESC, strAddrCode DESC LIMIT 1; ");
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
                        if (new_)
                        {
                            query = "INSERT INTO tblSupplier (`strSuppCode`, `strSuppName`, `strSuppAddrCode`, `strSuppContactNo`, `strSuppEmail`, strSuppAdded) VALUES ('" + strCode + "','" + strName + "','" + strACode + "','" + strContact + "','" + strEmail + "',USER());";
                        }
                        else
                        {
                            query = "UPDATE tblSupplier SET strSuppCode='" + strCode + "', strSuppName='" + strName + "', strSuppAddrCode='" + strACode + "', strSuppContactNo='" + strContact + "', strSuppEmail='" + strEmail + "' WHERE strSuppCode='" + strCode + "';";
                        }
                        //save to db
                        if (!Program.ExecuteQuery(query))
                        {
                            //tell them something's wrong
                            status.Text = "Failed to save supplier";
                            status.BackColor = Color.Tomato;
                        }
                        else
                        {

                            strCode = Program.getNextCode(strCode);
                            txtCode.Text = strCode;
                            txtName.Clear();
                            txtName.Focus();
                            txtContact.Clear();
                            txtEmail.Clear();
                            txtNo.Clear();
                            txtStreet.Clear();
                            txtTown.Clear();
                            txtCity.Clear();
                            status.Text = "Saved";
                            status.BackColor = Color.LimeGreen;
                            if (!new_)
                                this.Dispose();
                            if (this.uCSupplier != null)
                                this.uCSupplier.updateTable();
                            if (this.formReceiveInventory != null)
                                this.formReceiveInventory.loadSupplierComboBox();

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
        private void btncancel_Click(object sender, EventArgs e)
        { 
            this.Dispose();

        }
        
    }
}
