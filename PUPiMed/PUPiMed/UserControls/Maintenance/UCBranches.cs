using System;
using System.Data;
using System.Windows.Forms;
using PUPiMed.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace PUPiMed.UserControls
{
    public partial class UCBranches : UserControl
    {
        FormAddBranches branchesForm;
        public string query;
        public UCBranches()
        {
            InitializeComponent();
            query = "select * from vwbranches WHERE `Branch Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            new FormBranchSearch(this).ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.FormAddBranches(this,true).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                string code = grid.CurrentRow.Cells[0].Value.ToString();
                branchesForm = new FormAddBranches(this,false);
                branchesForm.txtCode.Text = code;
                branchesForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                        LoginNew.conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAddress a INNER JOIN tblBranch b ON a.strAddrCode=b.strBranAddrCode WHERE b.strBranCode = '" + code + "';", LoginNew.conn))
                    {
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            //Read the data and store them in the list
                            if (dataReader.Read())
                            {
                                branchesForm.strACode = dataReader.GetString(0);
                                branchesForm.txtNo.Text = dataReader.GetString(1);
                                branchesForm.txtStreet.Text = dataReader.GetString(2);
                                branchesForm.txtTown.Text = dataReader.GetString(3);
                                branchesForm.txtCity.Text = dataReader.GetString(4);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoginNew.conn.Close();
                }

                branchesForm.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateTable()
        {
            using (LoginNew.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand(query, LoginNew.conn))
                {
                    cmd.CommandType = CommandType.Text;
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            query = "select * from vwbranches WHERE `Branch Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                var result = MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    string strQuery;
                    string col1;
                    if (grid.CurrentRow.Cells[0] != null)
                    {
                        col1 = grid.CurrentRow.Cells[0].Value.ToString();

                        strQuery = "UPDATE tblBranch SET boolBranDeleted=1, dtmBranDeleted=NOW(), strBranDeleted=CURRENT_USER WHERE strBranCode = '" + col1 + "';";

                        if (Program.ExecuteQuery(strQuery))
                        {
                            //success
                            updateTable();
                        }
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                string code = grid.CurrentRow.Cells[0].Value.ToString();
                branchesForm = new FormAddBranches(this, false);
                branchesForm.txtCode.Text = code;
                branchesForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                        LoginNew.conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAddress a INNER JOIN tblBranch b ON a.strAddrCode=b.strBranAddrCode WHERE b.strBranCode = '" + code + "';", LoginNew.conn))
                    {
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            //Read the data and store them in the list
                            if (dataReader.Read())
                            {
                                branchesForm.strACode = dataReader.GetString(0);
                                branchesForm.txtNo.Text = dataReader.GetString(1);
                                branchesForm.txtStreet.Text = dataReader.GetString(2);
                                branchesForm.txtTown.Text = dataReader.GetString(3);
                                branchesForm.txtCity.Text = dataReader.GetString(4);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoginNew.conn.Close();
                }
                branchesForm.branch.Enabled = false;
                branchesForm.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
