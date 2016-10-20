using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed.UserControls
{
    public partial class UCDepartment : UserControl
    {
        string query, strCode, strName, strAcronym;
        bool newRecord;

        public UCDepartment()
        {
            InitializeComponent();
            query = "SELECT strDeptCode AS 'Code', strDeptName AS 'Name', strDeptShort AS 'Acronym' FROM tblDepartment WHERE boolDeptDeleted=FALSE AND strDeptCode LIKE '"+txtFilter.Text+"%'";
            updateTable();
        }

        public void updateTable()
        {
            using(LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (LoginNew.conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, LoginNew.conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                if (dt != null)
                                {
                                    sda.Fill(dt);
                                    grid.DataSource = dt;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, System.EventArgs e)
        {
            query = "SELECT strDeptCode AS 'Code', strDeptName AS 'Name', strDeptShort AS 'Acronym' FROM tblDepartment WHERE boolDeptDeleted=FALSE AND strDeptName LIKE '" + txtFilter.Text + "%'";
            updateTable();
        }
        
        private void grid_CurrentCellChanged(object sender, System.EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            newRecord = true;
            clearContents();
            getCode();
            txtName.Focus();
        }

        private void getCode()
        {
            strCode = Program.getPrevCode("SELECT strDeptCode from tblDepartment ORDER by char_length(strDeptCode) DESC, strDeptCode DESC LIMIT 1;");

            if (string.IsNullOrEmpty(strCode))
            {
                txtCode.Enabled = true;
            }
            else
            {
                strCode = Program.getNextCode(strCode);
                txtCode.Text = strCode;
                txtCode.Enabled = false;
            }
            txtCode.BackColor = txtCode.Enabled == true ? Color.White : Color.FromName("Control");

        }

        private bool everythingIsOkay()
        {
            getCode();
            strCode = txtCode.Text;
            strAcronym = txtAcronym.Text;
            strName = txtName.Text;
            if (string.IsNullOrEmpty(strCode) || string.IsNullOrEmpty(strAcronym) || string.IsNullOrEmpty(strName))
                return false;

            return true;
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                txtCode.Text = grid.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtAcronym.Text = grid.CurrentRow.Cells[2].Value.ToString();

                newRecord = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearContents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (everythingIsOkay())
            {
                if (newRecord)
                    query = "INSERT INTO `dbmedicalclinic`.`tbldepartment` (`strDeptCode`, `strDeptName`, `strDeptShort`, `strDeptAdded`) VALUES('" + strCode + "', '" + strName + "', '" + strAcronym + "', USER());";
                else
                    query = "UPDATE `dbmedicalclinic`.`tbldepartment` SET `strDeptName`='"+strName+"', `strDeptShort`='"+strAcronym+"' WHERE `strDeptCode`='"+grid.CurrentRow.Cells[0].Value.ToString()+"';";

                if (!Program.ExecuteQuery(query))
                {
                    if (newRecord)
                        error("Failed to save department");
                    else
                        error("Failed to update department");
                }
                else
                {
                    clearContents();
                    status.Text = "Saved";
                    status.BackColor = Color.LimeGreen;
                    query = "SELECT strDeptCode AS 'Code', strDeptName AS 'Name', strDeptShort AS 'Acronym' FROM tblDepartment WHERE boolDeptDeleted=FALSE AND strDeptCode LIKE '" + txtFilter.Text + "%'";
                    updateTable();
                    getCode();
                }
            }
            else
            {
                error("Please fill out empty fields");
            }
        }

        private void clearContents()
        {
            txtAcronym.Clear();
            txtName.Clear();
        }

        private void error(string errmsg)
        {
            status.Text = errmsg;
            status.BackColor = Color.Tomato;
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (Program.ExecuteQuery("UPDATE tblDepartment SET boolDeptDeleted = TRUE, dtmDeptDeleted=NOW(), strDeptDeleted=CURRENT_USER WHERE strDeptCode = '" + grid.CurrentRow.Cells[0].Value.ToString() + "';"))
                    {
                        query = "SELECT strDeptCode AS 'Code', strDeptName AS 'Name', strDeptShort AS 'Acronym' FROM tblDepartment WHERE boolDeptDeleted=FALSE AND strDeptCode LIKE '" + txtFilter.Text + "%'";
                        updateTable();
                    }
                }
            }
        }
    }
}
