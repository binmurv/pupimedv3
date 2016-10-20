using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormAddDistribItem : MetroForm
    {
        UCItemDistribution parent;
        List<String> listCode;
        List<string> campus = new List<string>();
        List<string> campuscode = new List<string>();
        string strType, strCode, strName, strQty, strDCode, strDate;
        int intBalance, intTotal, intAvailable, intQty;
        
        public FormAddDistribItem(UCItemDistribution parent)
        {
            InitializeComponent();
            getCode();
            this.parent = parent;
            cbType.SelectedIndex = 0;
            cbType.Focus();
            loadBranches();
            dtDate.Value = DateTime.Today;
        }

        private void getBalance()
        {
            intAvailable = int.Parse(PUPiMed.Program.getPrevCode("SELECT IFNULL(fnGetBalance('" + strCode + "'),0);"));
            txtAvailable.Text = intAvailable.ToString();
            getIntValues();
        }

        private void getIntValues()
        {
            strQty = txtQty.Text;
            if (!Int32.TryParse(strQty, out intQty))
            {
                txtQty.Text = "0";
            }
            getSelectedCampus();
            int count = campus.Count;
            intTotal = intQty * count;
            intBalance = intAvailable - intTotal;
            txtBalance.Text = intBalance.ToString();
            txtTotal.Text = intTotal.ToString();
        }

        private void getSelectedCampus()
        {
            campus.Clear();
            foreach (int index in this.cbBranch.CheckedIndices)
            {
               campus.Add(campuscode[index]);
            }
        }

        private void clearItems()
        {
            txtQty.Text = "0";
            txtBalance.Text = "0";
            txtAvailable.Text = "0";
            txtTotal.Text = "0";
            foreach (int index in this.cbBranch.CheckedIndices)
            {
                cbBranch.SetItemChecked(index, false);
            }
            foreach (var cb in this.Controls.OfType<ComboBox>())
            {
                cb.SelectedIndex = 0;
            } 
            dtDate.Value = DateTime.Today;
            getBalance();
        }

        private void FormAddDistribItem_Load(object sender, EventArgs e)
        {
        }

        private void UOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBalance();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCode();
            if (everythingIsOkay())
            {
                if (intBalance >= 0)
                {
                    if (cbBranch.CheckedItems.Count > 0)
                    {
                        if (int.Parse(strQty) > 0)
                        //if(Int32.Parse(strQty) > Int32.Parse(Program.getPrevCode("SELECT FNGETBALANCE(strItemCode) - intItemMin AS `Max` FROM tblItem WHERE boolItemDeleted = FALSE AND FNGETBALANCE(strItemCode)>intItemMin AND strItemCode LIKE '"+strCode+"';")))
                        {
                            if (saveHeader())
                            {
                                if (saveCampusDetail())
                                {
                                    clearItems();
                                    getCode();
                                    status.Text = "Saved.";
                                    status.BackColor = Color.LimeGreen;
                                }
                            }
                        }
                        else
                            error("Quantity can't be zero");
                    }
                    else
                        error("Please select branches before saving");
                }
                else
                    error("Insufficient stock");
            }
            else
                error("Please fill out the required fields before saving");
        }

        private void panel_Click(object sender, EventArgs e)
        {
            getIntValues();
        }

        private void error (string text)
        {
            status.Text = text;
            status.BackColor = Color.Tomato;
        }
        private void clearStatus()
        {
            status.BackColor = Color.DarkCyan;
            status.Text = "";
        }

        private void materialCheckBox5_CheckStateChanged(object sender, EventArgs e)
        {
            getIntValues();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            dtDate.MaxDate = DateTime.Today;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.parent.updateTable();
            this.Dispose();
        }

        private void pbAddItem_Click(object sender, EventArgs e)
        {

        }

        private void cbBranch_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            getIntValues();
        }

        private void cbBranch_MouseClick(object sender, MouseEventArgs e)
        {
            getIntValues();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtQty.Text)|| !String.IsNullOrEmpty(txtQty.Text))
                getIntValues();
        }

        private void cbBranch_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQty.Text) || !String.IsNullOrEmpty(txtQty.Text))
                getIntValues();
        }

        private void cbBranch_MouseEnter(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQty.Text) || !String.IsNullOrEmpty(txtQty.Text))
                getIntValues();
        }

        private void cbBranch_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQty.Text) || !String.IsNullOrEmpty(txtQty.Text))
                getIntValues();
        }

        private void cbBranch_ItemCheck(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtQty.Text) || !String.IsNullOrEmpty(txtQty.Text))
                getIntValues();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtDCode_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            new Forms.FormAddBranches(this).ShowDialog();
        }


        private void getCode()
        {
            //check if theres an existing code
            string prevCode = PUPiMed.Program.getPrevCode("SELECT strDisHCode from tblDistributionHeader ORDER by char_length(strDisHCode) DESC, strDisHCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                this.txtDCode.Enabled = true;
                this.txtDCode.Focus();
                this.txtDCode.BackColor = Color.White;

            }
            else
            {
                strDCode = PUPiMed.Program.getNextCode(prevCode);
                this.txtDCode.Text = strDCode;
                this.txtDCode.Enabled = false;
                this.txtDCode.BackColor = Color.FromArgb(224, 224, 224);
            }
        }


        private bool everythingIsOkay()
        {
            strDCode = txtDCode.Text;
            strType = cbType.SelectedItem.ToString();
            strCode = txtCode.Text;
            strName = cbName.SelectedItem.ToString();
            strQty = txtQty.Text;
            if (!Int32.TryParse(strQty, out intQty))
            {
                error("Please enter a numeric value for Quantity");
                //MetroMessageBox.Show(this, "Please enter a numeric value for 'Quantity'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            strDate = dtDate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(strDCode) || string.IsNullOrWhiteSpace(strDate)
             || string.IsNullOrWhiteSpace(strType) || string.IsNullOrWhiteSpace(strName)  || string.IsNullOrWhiteSpace(strCode))
            {
                return false;
            }
            
            return true;
        }
        private bool saveHeader()
        {
            string strQuery =
                "INSERT INTO tblDistributionHeader (`strDisHCode`, `datDisHDate`, `strDisHItemCode`, `intDisHQty`,  `strDisHAdded`) VALUES ('"
                + strDCode + "', '"
                + strDate + "', '"
                + strCode + "', "
                + strQty + ",USER());";
            if (!PUPiMed.Program.ExecuteQuery(strQuery))
            {
                error("Failed to save to database");
                MetroMessageBox.Show(this, "Failed to save to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool saveCampusDetail()
        {
            getSelectedCampus();
            string strQuery = "";
            foreach(string strBranch in campus)
            {
                strQuery=
                    "INSERT INTO tbldistributiondetail VALUES " +
                    "('" + strDCode + "', '" + strBranch + "');";

                if (!PUPiMed.Program.ExecuteQuery(strQuery))
                {
                    //MetroMessageBox.Show(this, "Failed to save "+strBranch+" to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //MessageBox.Show(strQuery);
            }
            return true;
                
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbName.SelectedIndex <= listCode.Count && listCode != null)
            {
                txtCode.Text = listCode[cbName.SelectedIndex].ToString();
                strCode = txtCode.Text;
                getBalance();
                getIntValues();
            }
        }
        private void loadItemComboBox(int type)
        {
            if (!Program.fillComboBox(cbName, "SELECT a.strItemCode, CONCAT(a.strItemName, ' ', IFNULL(b.strAddiDosage,''), ' ', IFNULL(b.strAddiForm,'')) AS Medicine FROM tblItem a LEFT JOIN tblAdditional b ON a.strItemCode = b.strAddiItemCode WHERE fnGetBalance(strItemCode)>intItemMin AND intItemType=" + type + " AND boolItemDeleted = false; ", out listCode))
            {
                cbName.Enabled = false;
                txtCode.Text = "";
                error("No available item");
            }
            else
            {
                cbName.Enabled = true;
                txtCode.Text = listCode[0].ToString();
            }
            cbName.SelectedIndex = 0;
            clearStatus();
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadItemComboBox(cbType.SelectedIndex+1);
        }

        public void loadBranches()
        {
            cbBranch.Items.Clear();
            try
            {
                if (LoginNew.conn != null && LoginNew.conn.State == ConnectionState.Closed)
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblbranch where boolbrandeleted=false;", LoginNew.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            campuscode.Add(dataReader.GetString(0));
                            cbBranch.Items.Add(dataReader.GetString(1));
                        }
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoginNew.conn.Close();
            }
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
