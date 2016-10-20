using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace PUPiMed.UserControls
{
    public partial class UCSupplier : UserControl
    {
        FormAddSupplier supplierForm;
        public string query;
        public UCSupplier()
        {
            InitializeComponent();
            query = "select * from vwsupplier WHERE `Supplier's Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }
        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            new FormSupplierSearch(this).ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAddSupplier(this,true).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                supplierForm = new FormAddSupplier(this, false);
                getValues();
                supplierForm.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getValues()
        {
            string code = grid.CurrentRow.Cells[0].Value.ToString();
            
            supplierForm.txtCode.Text = code;
            supplierForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
            supplierForm.txtContact.Text = grid.CurrentRow.Cells[3].Value.ToString();
            supplierForm.txtEmail.Text = grid.CurrentRow.Cells[4].Value.ToString();
            try
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAddress a INNER JOIN tblsupplier b ON a.strAddrCode=b.strSuppAddrCode WHERE b.strSuppCode = '" + code + "';", LoginNew.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        //Read the data and store them in the list
                        if (dataReader.Read())
                        {
                            supplierForm.strACode = dataReader.GetString(0);
                            supplierForm.txtNo.Text = dataReader.GetString(1);
                            supplierForm.txtStreet.Text = dataReader.GetString(2);
                            supplierForm.txtTown.Text = dataReader.GetString(3);
                            supplierForm.txtCity.Text = dataReader.GetString(4);
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

                        strQuery = "UPDATE tblSupplier SET boolSuppDeleted=1, dtmSuppDeleted=NOW(), strSuppDeleted=CURRENT_USER WHERE strSuppCode = '" + col1 + "';";

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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            query = "select * from vwsupplier WHERE `Supplier's Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                supplierForm = new FormAddSupplier(this, false);
                getValues();
                supplierForm.supplier.Enabled = false;
                supplierForm.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
