using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCItemDistribution : UserControl
    {
        public string query = "SELECT * FROM vwDistrib;";
        public UCItemDistribution()
        {
            InitializeComponent();
            updateTable();
        }

        private void gridDistribution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        public void updateTable()
        {
            
            try
            {
                LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, LoginNew.conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            sda.Fill(dt);
                            grid.DataSource = dt;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        finally
                        {
                            dt.Dispose();
                        }
                    }
                }
            }catch(Exception exx)
            {
                MessageBox.Show(exx.Message.ToString());
            }
            finally
            {
                LoginNew.conn.Close();
            }
        }
        private void AddDistibItem_Click(object sender, EventArgs e)
        {
            new FormAddDistribItem(this).ShowDialog();
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            FormItemSearch form = new FormItemSearch(this);
            query = "SELECT * FROM vwDistrib WHERE `Item Name` LIKE '" + txtFilter.Text + "%' ";
            form.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM vwDistrib WHERE `Item Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }
    }
}
