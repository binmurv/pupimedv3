using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCItemInventory : UserControl
    {
        public string query =
            "SELECT * FROM vwstock;";

        public UCItemInventory()
        {
            InitializeComponent();
            updateTable(query, grid);
            //this.grid.Size = new Size(832, this.grid.RowTemplate.Height * (1 + this.grid.Rows.Count) + gridPanel.Height);
        }

        public void updateTable(string strQuery, DataGridView gridview)
        {
            try
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(strQuery, LoginNew.conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            sda.Fill(dt);
                            gridview.DataSource = dt;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        finally
                        {
                            dt.Dispose();
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
            
            ////Change colorss
            //foreach (DataGridViewRow row in grid.Rows)
            //{
            //    row.Cells[2].Style.BackColor = Color.Red;
            //}
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM vwstock WHERE `Item Name` LIKE '" + txtFilter.Text + "%';";
            updateTable(query, grid);
            //this.grid.Size = new Size(832, this.grid.RowTemplate.Height * (1 + this.grid.Rows.Count) + gridPanel.Height);
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            FormItemSearch form = new FormItemSearch(this);
            query = "SELECT * FROM vwstock WHERE `Item Name` LIKE '" + txtFilter.Text + "%' ";
            form.ShowDialog();
            //this.grid.Size = new Size(832,this.grid.RowTemplate.Height * (1 + this.grid.Rows.Count) + gridPanel.Height);
        }

        private void UCItemInventory_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                //row.Cells[2].Style.BackColor = Color.Red;
            }

        }

        string code;

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = grid.CurrentRow;
            if (row != null)
            {
                if(grid.Height != 135 || row.Cells[1].Value.ToString()!=code)
                {
                    grid.Height = 135;
                    gridPanel.Visible = true;
                    loadSubgrid(row.Cells[1].Value.ToString());
                }
                else
                {
                    grid.Height = 520;
                    gridPanel.Visible = false;
                }
            }
            //if (row.Height != grid.RowTemplate.Height)
            //{
            //    row.Height = grid.RowTemplate.Height;
            //    //gridPanel.Visible = false;
            //    //gridPanel.SendToBack();
            //}
            //else
            //{
            //    ////reset row height
            //    //foreach (DataGridViewRow rows in grid.Rows)
            //    //{
            //    //    rows.Height = grid.RowTemplate.Height;
            //    //}

                
            //    if (row != null)
            //    {
            //        loadSubgrid(row.Cells[1].Value.ToString(), grid.Location.X, grid.Location.Y + ((1 + row.Index) * row.Height) + row.Height);
            //        //row.Height = row.Height + gridPanel.Height;
            //    }
            //}
        }

        private void loadSubgrid(string code)
        {
            //gridPanel.Visible = true;
            //gridPanel.BringToFront();
            //gridPanel.Location = new Point(x,y);
            this.code = code;
            string queryIn      = "SELECT * from vwreceiveditem WHERE `Item Name` LIKE '"+code+"';";
            string queryOut     = "SELECT * from vwdistribitem WHERE `Item Name` LIKE '" + code + "';";
            string queryOut2    = "SELECT * from vwlogsitem WHERE `Item Name` LIKE '" + code + "';";

            updateTable(queryIn, gridIn);
            updateTable(queryOut, gridOut);
            updateTable(queryOut2, gridOut2);
        }

        private void grid_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }
    }
}
