using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUPiMed.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace PUPiMed.UserControls
{
    public partial class UCManufacturer : UserControl
    {
        FormAddManufacturer manufacturerForm;
        public string query;
        public UCManufacturer()
        {
            InitializeComponent();
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            new FormManufacturerSearch(this).ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAddManufacturer(this, true).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                string code = grid.CurrentRow.Cells[0].Value.ToString();
                manufacturerForm = new FormAddManufacturer(this, false);
                manufacturerForm.txtCode.Text = code;
                manufacturerForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                manufacturerForm.cbItemType.SelectedIndex = manufacturerForm.cbItemType.Items.IndexOf(grid.CurrentRow.Cells[2].Value.ToString());
                try
                {
                    if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                        LoginNew.conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAddress a INNER JOIN tblManufacturer b ON a.strAddrCode=b.strManuAddrCode WHERE b.strManuCode = '" + code + "';", LoginNew.conn))
                    {
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            //Read the data and store them in the list
                            if (dataReader.Read())
                            {
                                manufacturerForm.strACode = dataReader.GetString(0);
                                manufacturerForm.txtNo.Text = dataReader.GetString(1);
                                manufacturerForm.txtStreet.Text = dataReader.GetString(2);
                                manufacturerForm.txtTown.Text = dataReader.GetString(3);
                                manufacturerForm.txtCity.Text = dataReader.GetString(4);
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
                manufacturerForm.ShowDialog();
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
                            else
                            {

                            }

                        }
                    }
                }
            }
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

                        strQuery = "UPDATE tblManufacturer SET boolManuDeleted=1, dtmManuDeleted=NOW(), strManuDeleted=CURRENT_USER WHERE strManuCode = '" + col1 + "';";

                        if (Program.ExecuteQuery(strQuery))
                        {
                            //success
                            updateTable();
                        }
                        else
                        {
                            //fail
                        }
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCManufacturer_Load(object sender, EventArgs e)
        {
            query = "select * from vwmanufacturer where `Manufacturer's Name` LIKE '"+txtFilter.Text+"%';";
            updateTable();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            query = "select * from vwmanufacturer where `Manufacturer's Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                string code = grid.CurrentRow.Cells[0].Value.ToString();
                manufacturerForm = new FormAddManufacturer(this, false);
                manufacturerForm.txtCode.Text = code;
                manufacturerForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                manufacturerForm.cbItemType.SelectedIndex = manufacturerForm.cbItemType.Items.IndexOf(grid.CurrentRow.Cells[2].Value.ToString());
                try
                {
                    if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                        LoginNew.conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAddress a INNER JOIN tblManufacturer b ON a.strAddrCode=b.strManuAddrCode WHERE b.strManuCode = '" + code + "';", LoginNew.conn))
                    {
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            //Read the data and store them in the list
                            if (dataReader.Read())
                            {
                                manufacturerForm.strACode = dataReader.GetString(0);
                                manufacturerForm.txtNo.Text = dataReader.GetString(1);
                                manufacturerForm.txtStreet.Text = dataReader.GetString(2);
                                manufacturerForm.txtTown.Text = dataReader.GetString(3);
                                manufacturerForm.txtCity.Text = dataReader.GetString(4);
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
                manufacturerForm.manufacturer.Enabled = false;
                manufacturerForm.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
