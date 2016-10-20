using MetroFramework.Forms;
using PUPiMed.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PUPiMed
{
    public partial class FormAddItem : MetroForm
    {
        public UCItem parent;
        public int choice = 0, itemType = 1;
        List<String> listManuCode;

        string strCode, strName, strGen, strManu;
        int intMin, intMax;
        private UCItemLibrary uCItemLibrary;

        public FormAddItem(UCItem parent, int itemType)
        {
            InitializeComponent();
            this.itemType = itemType;
            this.parent = parent;
            loadItemType();
            loadManufacturer();
        }

        public FormAddItem(int itemType)
        {
            InitializeComponent();
            this.itemType = itemType;
            this.choice = 0;
            loadItemType();
            loadManufacturer();
        }

        public FormAddItem(UCItemLibrary uCItemLibrary, int itemType)
        {
            InitializeComponent();
            this.uCItemLibrary = uCItemLibrary;
            this.itemType = itemType;
            this.choice = 1;
            loadItemType();
            loadManufacturer();
        }

        public void loadItemType()
        {
            switch (this.itemType)
            {
                case 1:
                    this.icon.Image = global::PUPiMed.Properties.Resources.pill_teal;
                    Title.Text = "MEDICINE";
                    lblCode.Text = "Medicine Code: ";
                    medicine.Enabled = true;
                    medicine.Visible = true;
                    medicine.BringToFront();
                    equipment.Enabled = false;
                    equipment.Visible = false;
                    break;
                case 2:
                    this.icon.Image = global::PUPiMed.Properties.Resources.suppliesdff;
                    Title.Text = "SUPPLY";
                    lblCode.Text = "Supply Code: ";
                    medicine.Enabled = true;
                    medicine.Visible = true;
                    medicine.BringToFront();
                    equipment.Enabled = false;
                    equipment.Visible = false;
                    break;
                case 3:
                    this.icon.Image = global::PUPiMed.Properties.Resources.wheelchair_teal;
                    Title.Text = "EQUIPMENT";
                    lblCode.Text = "Equipment Code: ";
                    medicine.Enabled = false;
                    medicine.Visible = false;
                    equipment.BringToFront();
                    equipment.Enabled = true;
                    equipment.Visible = true;
                    break;
            }
        }

        private bool everythingIsOkay()
        {
            if (this.itemType != 3)
            {
                strCode = txtCode.Text;
                strName = txtName.Text;
                strGen = txtGen.Text;
                strManu = listManuCode[cbManufacturer.SelectedIndex].ToString();

                if (itemType == 1)
                {
                    if (string.IsNullOrEmpty(txtDosage.Text))
                    {
                        return false;
                    }
                }

                if (!(Int32.TryParse(txtMin.Text, out intMin)))
                {
                    return false;
                }
                if (!(Int32.TryParse(txtMax.Text, out intMax)))
                {
                    return false;
                }
            }
            else
            {
                strCode = txtCode.Text;
                strName = txtName_.Text;
                strGen = txtGeneric_.Text;
                strManu = listManuCode[cbManufacturer_.SelectedIndex].ToString();

                if (!(Int32.TryParse(txtMin_.Text, out intMin)))
                {
                    return false;
                }
                if (!(Int32.TryParse(txtMax_.Text, out intMax)))
                {
                    return false;
                }
            }
            
            if (string.IsNullOrEmpty(strCode) || string.IsNullOrEmpty(strName) || string.IsNullOrEmpty(strGen) || string.IsNullOrEmpty(strManu))
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCode();
            string strQuery;
            if (everythingIsOkay())
            {
                if (intMin >= intMax)
                {
                    status.Text = "Max must be greater than the minimum value.";
                    status.BackColor = Color.Tomato;
                }else
                {
                    if (string.IsNullOrEmpty(PUPiMed.Program.getNextCode(strCode)))
                    {
                        txtCode.Focus();
                        status.Text = "Invalid code.";
                        status.BackColor = Color.Tomato;
                    }
                    else
                    {
                        if (choice == 0)
                        {
                            strQuery = "INSERT INTO tblItem (`strItemCode`, `strItemName`, `strItemGeneric`, `strItemManuCode`, `intItemMin`, `intItemMax`, `intItemType`, `strItemAdded`) VALUES ('" + strCode + "', '" + strName + "', '" + strGen + "', '" + strManu + "', " + intMin + ", " + intMax + ", " + itemType + ", USER());";
                        }
                        else
                        {
                            strQuery = "UPDATE tblItem SET strItemName='" + strName
                                + "', strItemGeneric='" + strGen
                                + "', strItemManuCode='" + strManu
                                + "', intItemMin=" + intMin
                                + ", intItemMax=" + intMax
                                + " WHERE strItemCode='" + strCode + "';";
                        }

                        if (PUPiMed.Program.ExecuteQuery(strQuery))
                        {
                            if (itemType != 3)
                            {
                                if (!string.IsNullOrEmpty(txtDosage.Text))
                                {
                                    string form = cbForm.SelectedItem.ToString();
                                    string query= "";
                                    if (choice == 1)
                                        query = "UPDATE `dbmedicalclinic`.`tbladditional` SET `strAddiDosage`='"+txtDosage.Text+"', `strAddiForm`='"+form+"' WHERE `strAddiItemCode`='"+strCode+"';";
                                    else
                                        query = "INSERT INTO `dbmedicalclinic`.`tbladditional` (`strAddiItemCode`, `strAddiDosage`, `strAddiForm`) VALUES ('" + strCode + "', '" + txtDosage.Text + "', '" + form + "');";
                                    
                                    if (Program.ExecuteQuery(query)) { }
                                    //System.Windows.Forms.MessageBox.Show(query);
                                }
                            }
                                //success
                                loadManufacturer();
                                strCode = PUPiMed.Program.getNextCode(strCode);
                                txtCode.Text = strCode;
                                txtCode.Enabled = false;

                                if (this.itemType == 3)
                                {
                                    if (cbManufacturer_.Items != null)
                                        cbManufacturer_.SelectedIndex = 0;
                                    txtName_.Clear();
                                    txtName_.Focus();
                                    txtGeneric_.Clear();
                                    txtMin_.Value = txtMin_.Minimum;
                                    txtMax_.Value = txtMax_.Minimum;
                                }
                                else
                                {
                                    if (cbManufacturer.Items != null)
                                        cbManufacturer.SelectedIndex = 0;
                                    txtName.Clear();
                                    txtName.Focus();
                                    txtGen.Clear();
                                    txtMin.Value = txtMin.Minimum;
                                    txtMax.Value = txtMax.Maximum;
                                    txtDosage.Clear();
                                    cbForm.SelectedIndex = 0;
                                }
                                
                                if (parent != null)
                                    parent.updateTable();
                                if (this.uCItemLibrary != null)
                                    uCItemLibrary.updateTable();
                                status.Text = "Saved";
                                status.BackColor = Color.LimeGreen;
                                if (choice == 1)
                                    this.Dispose();
                        }
                        else
                        {
                            //fail
                            status.Text = "Failed to make changes";
                            status.BackColor = Color.Tomato;
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

        public void loadManufacturer()
        {
            //Meds & Supplies Only
            if (this.itemType != 3)
            {
                if (Program.fillComboBox(cbManufacturer, "SELECT * FROM tblManufacturer WHERE boolManuDeleted = false AND intManuType=" + itemType + ";", out listManuCode))
                {
                    cbManufacturer.PromptText = "Please add a new Manufacturer";
                }
            }
            //Equipment Only
            else
            {
                if (Program.fillComboBox(cbManufacturer_, "SELECT * FROM tblManufacturer WHERE boolManuDeleted = false AND intManuType=" + itemType + ";", out listManuCode))
                {
                    cbManufacturer_.PromptText = "Please add a new Manufacturer";
                }
            }
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            if (choice == 1)
            {
                txtCode.Enabled = false;
                txtName.Focus();
            }
            else
            {
                getCode();
            }
            cbForm.SelectedIndex = 0;
        }

        private void txtMin_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyC­har) && !char.IsControl(e.Ke­yChar);
        }

        private void txtMax_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyC­har) && !char.IsControl(e.Ke­yChar);
        }

        private void txtMin_ValueChanged(object sender, EventArgs e)
        {
            txtMin.Minimum = 0;
        }

        private void pbAddSupplier_Click(object sender, EventArgs e)
        {
            new FormAddManufacturer(this, this.itemType-1).ShowDialog();
        }


        private void txtMax_ValueChanged(object sender, EventArgs e)
        {
        }

        private void getCode()
        {
            //check if theres an existing code
            string prevCode = PUPiMed.Program.getPrevCode("SELECT strItemCode from tblItem WHERE intItemType=" + itemType + " ORDER by CHAR_LENGTH(strItemCode) DESC, strItemCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                this.txtCode.Enabled = true;
                this.txtCode.Focus();
            }
            else
            {
                strCode = PUPiMed.Program.getNextCode(prevCode);
                this.txtCode.Text = strCode;
                this.txtCode.Enabled = false;
                this.txtName.Focus();
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
        }
        private void txtCode_Click(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
        }
        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
