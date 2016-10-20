using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormReceiveInventory : MetroForm
    {
        UCReceive parent;
        List<String> listItemCode, listSuppCode;
        string strType, strCode, strName, strQty, strSupplier, strExp, strRDate, strRCode, strDelivery;

        public FormReceiveInventory(UCReceive parent)
        {
            this.parent = parent;
            
            InitializeComponent();
            dtReceived.Value = DateTime.Today;
            cbType.SelectedIndex = 0;
            loadItemComboBox(cbType.SelectedIndex+1);
            loadSupplierComboBox();
            cbType.Focus();
        }

        private void error(string text)
        {
            status.Text = text;
            status.BackColor = Color.Tomato;
        }
        private void clearStatus()
        {
            status.BackColor = Color.DarkCyan;
            status.Text = "";
        }

        private void setMinMax()
        {
            //SELECT strItemCode AS `Code`,  CASE  WHEN fnGetBalance(strItemCode) = intItemMin THEN 0 WHEN fnGetBalance(strItemCode) < intItemMin THEN intItemMin - fnGetBalance(strItemCode) WHEN fnGetBalance(strItemCode) > intItemMin THEN 0 END AS `Min`, CASE  WHEN fnGetBalance(strItemCode) = intItemMax THEN 0  WHEN fnGetBalance(strItemCode) < intItemMax THEN intItemMax - fnGetBalance(strItemCode)  WHEN fnGetBalance(strItemCode) > intItemMax THEN 0 END AS `Max` FROM tblItem WHERE boolItemDeleted = false;
            txtQty.Minimum = Int32.Parse(Program.getPrevCode("SELECT CASE  WHEN fnGetBalance(strItemCode) = intItemMin THEN 0 WHEN fnGetBalance(strItemCode) < intItemMin THEN intItemMin - fnGetBalance(strItemCode) WHEN fnGetBalance(strItemCode) > intItemMin THEN 0 END AS `Min` FROM tblItem WHERE boolItemDeleted = false AND strItemCode LIKE '"+listItemCode[cbName.SelectedIndex].ToString()+"';"));
            txtQty.Maximum = Int32.Parse(Program.getPrevCode("SELECT CASE  WHEN fnGetBalance(strItemCode) = intItemMax THEN 0  WHEN fnGetBalance(strItemCode) < intItemMax THEN intItemMax - fnGetBalance(strItemCode)  WHEN fnGetBalance(strItemCode) > intItemMax THEN 0 END AS `Max` FROM tblItem WHERE boolItemDeleted = false AND strItemCode LIKE '" + listItemCode[cbName.SelectedIndex].ToString() + "';"));
        }

        public void loadItemComboBox(int type)
        {   //add dosage and formulation for Meds
            
            if (!Program.fillComboBox(cbName, "SELECT a.strItemCode, CONCAT(a.strItemName, ' ', IFNULL(b.strAddiDosage,''), ' ', IFNULL(b.strAddiForm,'')) AS Medicine FROM tblItem a LEFT JOIN tblAdditional b ON a.strItemCode = b.strAddiItemCode WHERE intItemType=" + type + " AND boolItemDeleted = false; ", out listItemCode))
            {
                pbAddItem.Focus();
                cbName.PromptText = "Please add a new Item";
            }
            cbName.SelectedIndex = 0;
            setMinMax();
        }

        public void loadSupplierComboBox()
        {
            if (!Program.fillComboBox(cbSupplier, "SELECT strSuppCode, strSuppName FROM tblSupplier;", out listSuppCode))
            {
                pbAddSupplier.Focus();
                cbSupplier.PromptText = "Please add a new Supplier";
            }
            cbSupplier.SelectedIndex = 0;
        }

        private void gridRI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.parent.updateTable();
            this.Dispose();
        }

        private void pbAddItem_Click(object sender, EventArgs e)
        {
            if (cbType != null)
            {
                if (cbType.SelectedItem.Equals("Medicine"))
                    new FormAddItem(1).ShowDialog();
                else if (cbType.SelectedItem.Equals("Supply"))
                    new FormAddItem(2).ShowDialog();
                else if (cbType.SelectedItem.Equals("Equipment"))
                    new FormAddItem(3).ShowDialog();
                else 
                    cbType.Focus();
                loadItemComboBox(cbType.SelectedIndex + 1);
            }
        }

        

        private void FormReceiveInventory_Load(object sender, EventArgs e)
        {
            getCode();
        }
        private void getCode()
        {
            string prevCode = PUPiMed.Program.getPrevCode("SELECT strRecHCode from tblReceiveHeader ORDER by char_length(strRecHCode) DESC, strRecHCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                this.txtRCode.Enabled = true;
                this.txtRCode.Enabled = true;
                this.txtRCode.Focus();
                this.txtRCode.BackColor = Color.White;
            }
            else
            {
                strRCode = PUPiMed.Program.getNextCode(prevCode);
                this.txtRCode.Text = strRCode;
                this.txtRCode.Enabled = false;
                this.txtRCode.BackColor = Color.FromArgb(224, 224, 224);
                this.cbType.Focus();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            getCode();
            if (headerIsOkay())
            {
                if (listDetail.Rows.Count>0)
                {
                    if (saveHeader())
                    {
                        if (saveDetail())
                        {
                            clearFields();
                            error("Saved");
                            status.BackColor = Color.LimeGreen;
                        }
                    }
                }
                else
                {
                    error("Please add an item first");
                }
            }
            else
            {
                error("Please fill out the required fields before saving");
            }
        }

        private bool saveHeader()
        {
            string strQuery = "INSERT INTO tblreceiveheader (`strRecHCode`, `strRecHDeliveryReceipt`, `strRecHSuppCode`, `datRecHDateReceived`, `strRecHAdded`) VALUES('" + strRCode+"','"+strDelivery+"','" + listSuppCode[cbSupplier.SelectedIndex]+"','"+strRDate+"', USER());";
            if (!PUPiMed.Program.ExecuteQuery(strQuery))
            {
                return false;
            }
            return true;
        }

        private bool saveDetail()
        {
            string strQuery = "";
            foreach (DataGridViewRow row in listDetail.Rows)
            {
                loadItemComboBox(1 + cbType.FindStringExact(row.Cells[0].Value.ToString()));

                strQuery =
                    "INSERT INTO tblreceivedetail (`strRecDRecHCode`, `strRecDItemCode`, `strRecDBatchCode`, `intRecDQty`, `datRecDExpDate`) VALUES ('"
                    + strRCode + "','"  //Receiving Code
                    + listItemCode[cbName.FindStringExact(row.Cells[1].Value.ToString())].ToString() + "','" //itemCode
                    + row.Cells[2].Value.ToString() + "','" //BatchCode
                    + row.Cells[3].Value.ToString() + "','" //QTY
                    + row.Cells[4].Value.ToString() + "');"; //DATE EXP


                if (!PUPiMed.Program.ExecuteQuery(strQuery))
                {
                    return false;
                }
            }
            return true;
        }


        //edit row
        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listDetail.SelectedRows)
            {
                cbType.SelectedItem = row.Cells[0].Value.ToString();
                cbName.SelectedItem = row.Cells[1].Value.ToString();
                txtCode.Text = row.Cells[2].Value.ToString();
                txtQty.Text = row.Cells[3].Value.ToString();
                dtExp.Value = DateTime.Parse(row.Cells[4].Value.ToString());

                listDetail.Rows.Remove(row);
            }
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
                    }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            clearStatus();
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtReceived_ValueChanged(object sender, EventArgs e)
        {
            dtReceived.MaxDate = DateTime.Today;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearStatus();
            setMinMax();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void txtDeliveryNo_TextChanged(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void dtReceived_DropDown(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void cbType_Click(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {

        }
        

        private void txtCode_EnabledChanged(object sender, EventArgs e)
        {
            MetroTextBox txt = sender as MetroTextBox;
            if (!txt.Enabled)
                txt.BackColor = Color.Gainsboro;
            else
                txt.BackColor = Color.White;
        }

        private void listReceived_ItemActivate(object sender, EventArgs e)
        {
            if(listDetail.SelectedRows.Count > 0) {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        
        private void dtExp_ValueChanged(object sender, EventArgs e)
        {
            clearStatus();
        }

        
       
        private void clearFields()
        {
            cbType.SelectedIndex = 0;
            loadItemComboBox(1);
            loadSupplierComboBox();
            txtQty.Text = "0";
            getCode();
            dtExp.Value = DateTime.Today;
            dtReceived.Value = DateTime.Today;
            listDetail.Rows.Clear();
            txtCode.Clear();
            txtDeliveryNo.Clear();
            cbType.Focus();

        }
         
        private void pbAddSupplier_Click(object sender, EventArgs e)
        {
            new FormAddSupplier(this).ShowDialog();
        }

        private bool headerIsOkay()
        {
            strRCode = txtRCode.Text;
            strDelivery = txtDeliveryNo.Text;
            strRDate = dtReceived.Value.ToString("yyyy-MM-dd");
            strSupplier = cbSupplier.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(strRCode) || string.IsNullOrWhiteSpace(strDelivery) || string.IsNullOrWhiteSpace(strRDate) || string.IsNullOrWhiteSpace(strSupplier))
            {
                return false;
            }
            return true;
        }
        
        private bool detailIsOkay()
        {
            strType = cbType.SelectedItem.ToString();
            strCode = txtCode.Text;
            strName = cbName.SelectedItem.ToString();
            strQty = txtQty.Text;
            strExp = dtExp.Value.ToString("yyyy-MM-dd");
            
            if (string.IsNullOrWhiteSpace(strType) || string.IsNullOrWhiteSpace(strName)|| string.IsNullOrWhiteSpace(strQty) || string.IsNullOrWhiteSpace(strExp))
            {
                return false;
            }else
            {
                if (cbType.SelectedIndex == 0 && string.IsNullOrWhiteSpace(strCode))
                    return false;
            }
           return true;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = new string[5];
            int qty;
            if (!detailIsOkay())
            {
                error("Please fill out the required fields before adding");
                //MetroMessageBox.Show(this, "Please fill out the required fields before adding.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((Int32.TryParse(strQty, out qty)))
                {
                    //qty cant be zero or less
                    if (qty <= 0)
                    {
                        error("Quantity can't be less than one");
                        //MetroMessageBox.Show(this, "Quantity can't be less than one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        
                        if (!PUPiMed.Program.duplicateEntry(listDetail, strName, 1))
                        {
                            row[0] = strType;
                            row[1] = strName;
                            row[2] = strCode;
                            row[3] = strQty;
                            row[4] = strExp;
                            listDetail.Rows.Add(row);

                            //cbType.SelectedIndex = 0;
                            cbName.SelectedIndex = 0;
                            txtCode.Clear();
                            txtQty.Text = "0";
                            dtExp.Value = DateTime.Today;
                            cbType.Focus();
                        }
                        else
                        {
                            error("Duplicate entry for " + strName);
                            //MetroMessageBox.Show(this, "Duplicate entry for " + strName + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
                else
                {
                    error("Please enter a numeric value for 'Quantity'");
                    //MetroMessageBox.Show(this, "Please enter a numeric value for 'Quantity'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (listDetail.SelectedRows.Count > 0)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        //Delete row
        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listDetail.SelectedRows)
            {
                listDetail.Rows.Remove(row);
            }

            if (listDetail.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearStatus();
            loadItemComboBox(cbType.SelectedIndex + 1);
            //string str = "";
            //for(int i = 0; i < alistCode.Count; i++)
            //{
            //    str += alistCode[i] + " - " + cbName.Items[i] + "\n";
            //}
            //MessageBox.Show(str);
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
