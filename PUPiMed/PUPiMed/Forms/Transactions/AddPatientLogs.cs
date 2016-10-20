using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormAddPatientLogs : MetroForm
    {
        string strCode, strName, strTime, strDate, strComplaint, strTreatment, strQty, strMedGiven;
        public string strQuery;
        List<String> listMed, listName;
        private UCPatientLogs_DTR_ uCPatientLogs_DTR_;
        private int intAvailable;

        public FormAddPatientLogs()
        {
            InitializeComponent();
            dtTime.Value = DateTime.Now;
            loadMedicine();
            loadPatients("SELECT strPatiCode, Concat(strPatiLastName, ', ', strPatiFirstName, ' ', strPatiMiddleName) FROM tblPatient WHERE boolPatiDeleted = FALSE");
            getCode();
            dtDate.MaxDate = DateTime.Today;
        }

        public FormAddPatientLogs(UCPatientLogs_DTR_ uCPatientLogs_DTR_): this()
        {
            this.uCPatientLogs_DTR_ = uCPatientLogs_DTR_;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new FormAddPatient(this).ShowDialog();
        }

        private void dtTimeIn_ValueChanged_1(object sender, EventArgs e)
        {
            clearStatus();
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.CustomFormat = "hh:mm:ss tt";
            dtTime.ShowUpDown = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCode();
            if (headerIsOkay())
            {
               if (saveHeader())
                {
                    if (listMedsGiven.Rows.Count > 0)
                    {
                        if (!saveDetail())
                        {
                            error("Failed to save Log Detail");
                        }
                        else
                        {
                            getCode();
                            cbName.SelectedIndex = 0;
                            dtDate.Value = DateTime.Now.Date;
                            txtComplaints.Clear();
                            txtTreatments.Clear();
                            listMedsGiven.Rows.Clear();
                            cbMedsGiven.SelectedIndex = 0;
                            txtQty.Value = 0;
                            if (uCPatientLogs_DTR_ != null)
                            {
                                uCPatientLogs_DTR_.updateTable();
                            }
                            error("Saved");
                            status.BackColor = Color.LimeGreen;
                            getBalance();
                        }
                    }else
                    {
                        getCode();
                        cbName.SelectedIndex = 0;
                        dtDate.Value = DateTime.Now.Date;
                        txtComplaints.Clear();
                        txtTreatments.Clear();
                        listMedsGiven.Rows.Clear();
                        cbMedsGiven.SelectedIndex = 0;
                        txtQty.Value = 0;
                        if (uCPatientLogs_DTR_ != null)
                        {
                            uCPatientLogs_DTR_.updateTable();
                        }
                        error("Saved");
                        status.BackColor = Color.LimeGreen;
                        getBalance();
                    }
                }
            }
            else
            {
                error("Please fill out the required fields before saving");
            }
        }
           

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_Click(object sender, EventArgs e)
        {

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

        private bool saveHeader()
        {
            string strQuery = "INSERT INTO tblLogsHeader (`strLogHCode`, `datLogHDatetime`, `strLogHPatiCode`, `strLogsComplaints`, `strLogHTreatment`, strLogHAdded) VALUES('" + strCode + "','" + strDate+strTime + "','" + listName[cbName.SelectedIndex].ToString() + "','" + strComplaint + "','" + strTreatment + "', USER());";
            if (!Program.ExecuteQuery(strQuery))
            {
                return false;
            }
            return true;
        }

        private bool headerIsOkay()
        {
            strCode = txtCode.Text;
            strName = cbName.SelectedItem.ToString();
            strTime = dtTime.Value.ToString("hh-mm-ss");
            strDate = dtDate.Value.ToString("yyyy-MM-dd-");
            strComplaint = txtComplaints.Text.ToString();
            strTreatment = txtTreatments.Text.ToString();
            
            if (string.IsNullOrWhiteSpace(strCode) ||
                string.IsNullOrWhiteSpace(strName) ||
                string.IsNullOrWhiteSpace(strTime) ||
                string.IsNullOrWhiteSpace(strDate) ||
                string.IsNullOrWhiteSpace(strComplaint) ||
                string.IsNullOrWhiteSpace(strTreatment)
            ){ 
                return false;
            }
            return true;
        }

        private bool detailIsOkay()
        {
            strMedGiven = cbMedsGiven.SelectedItem.ToString();
            strQty = txtQty.Text;
            
            if (string.IsNullOrEmpty(strMedGiven) || string.IsNullOrEmpty(strQty))
            {
                return false;
            }else
            {
                if (Int32.Parse(strQty) < 1)
                    return false;
            }
            return true;
        }

        private bool saveDetail()
        {
            string strQuery;
            foreach (DataGridViewRow row in listMedsGiven.Rows)
            {
                    strQuery =
                    "INSERT INTO tblLogsDetail VALUES ('"
                    + strCode + "','"
                    + listMed[cbMedsGiven.FindStringExact(row.Cells[0].Value.ToString())].ToString() + "','"
                    + strQty 
                    + "');";
                if (!Program.ExecuteQuery(strQuery))
                {
                    return false;
                }
            }
            return true;
        }

        private void metroButton1_Click(object sender, EventArgs e) //ADD 
        {
            if (detailIsOkay())
            {
                if (!Program.duplicateEntry(listMedsGiven, strMedGiven , 0))
                {
                    string[] row = new string[2];
                    row[0] = strMedGiven;
                    row[1] = strQty;
                    listMedsGiven.Rows.Add(row);
                    cbMedsGiven.SelectedIndex = 0;
                    txtQty.Value = 0;
                }
                else
                {
                    error("Duplicate entry for "+strMedGiven);
                }
            }
            else
            {
                error("Quantity can't be zero");
            }
            
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listMedsGiven.SelectedRows)
            {
                listMedsGiven.Rows.Remove(row);
            }

            if (listMedsGiven.SelectedRows.Count > 0)
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

        private void listMedsGiven_SelectionChanged(object sender, EventArgs e)
        {
            if (listMedsGiven.SelectedRows.Count > 0)
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

        private void listMedsGiven_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (listMedsGiven.SelectedRows.Count > 0)
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

        private void listMedsGiven_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (listMedsGiven.SelectedRows.Count > 0)
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

        private void txtCode_Click_1(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearStatus();
            getBalance();
            txtQty.Maximum = Int32.Parse(txtAvailable.Text);
            txtQty.Value = txtQty.Minimum;
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            clearStatus();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadPatients(null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listMedsGiven.SelectedRows)
            {
                listMedsGiven.Rows.Remove(row);

                cbMedsGiven.SelectedItem = row.Cells[0].Value.ToString();
                txtQty.Text = row.Cells[1].Value.ToString();
            }
        }

        private void getBalance()
        {
            try
            {
                intAvailable = int.Parse(PUPiMed.Program.getPrevCode("SELECT fnGetBalance('" + listMed[cbMedsGiven.SelectedIndex].ToString() + "');"));
                txtAvailable.Text = intAvailable.ToString();
            }
            catch { }
        }

        private void txtQty_ValueChanged(object sender, ScrollEventArgs e)
        {
            
        }

        public void loadMedicine()
        {
            if (!Program.fillComboBox(cbMedsGiven, "SELECT a.strItemCode, CONCAT(a.strItemName, ' ', IFNULL(b.strAddiDosage,''), ' ', IFNULL(b.strAddiForm,'')) AS Medicine FROM tblItem a LEFT JOIN tblAdditional b ON a.strItemCode = b.strAddiItemCode WHERE fnGetBalance(strItemCode)>0 AND intItemType=1 AND boolItemDeleted = false; ", out listMed))
            {
                cbMedsGiven.PromptText = "No Medicine Found!";
            }
            cbMedsGiven.SelectedIndex = 0;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void loadPatients(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                loadPatients("SELECT strPatiCode AS `Code`, Concat(strPatiLastName, ', ', strPatiFirstName, ' ', strPatiMiddleName) FROM tblPatient WHERE boolPatiDeleted = FALSE; ");
            }else
            {
                if (!Program.fillComboBox(cbName, query, out listName))
                {
                    cbName.PromptText = "No Patient Found!";
                }
                cbName.SelectedIndex = 0;
            }
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            FormPatientSearch form = new FormPatientSearch(this);

            form.ShowDialog();
        }
        
        private void getCode()
        {
            string prevCode = Program.getPrevCode("SELECT strLogHCode from tblLogsHeader ORDER by char_length(strLogHCode) DESC, strLogHCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                this.txtCode.Enabled = true;
                this.txtCode.BackColor = Color.White;
                this.txtCode.Focus();
            }
            else
            {
                strCode = Program.getNextCode(prevCode);
                this.txtCode.Text = strCode;
                this.txtCode.Enabled = false;
                this.txtCode.BackColor = Color.FromArgb(224,224,224);
                this.cbName.Focus();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool everythingIsOkay()
        {
            if (!headerIsOkay()||listMedsGiven.Rows.Count<1)
            {
                return false;
            }
            return true;
        }

        private void txtComplaints_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
