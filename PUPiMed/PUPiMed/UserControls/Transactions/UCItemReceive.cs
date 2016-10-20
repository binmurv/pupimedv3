using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PUPiMed
{
    public partial class UCReceive : UserControl
    {
        public string strQuery;

        public UCReceive()
        {
            InitializeComponent();
            strQuery = "SELECT * FROM vwreceived WHERE `Item Name` LIKE '" + txtFilter.Text + "%' ORDER BY `Date Received`;";
            updateTable();

        }

        private void ReceiveInventory_Click(object sender, EventArgs e)
        {
            new FormReceiveInventory(this).ShowDialog();
        }

        public void updateTable()
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            strQuery = "SELECT * FROM vwreceived WHERE `Item  Name` LIKE '" + txtFilter.Text + "%' ORDER BY `Date Received`;";
            updateTable();
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            new Forms.FormReceiveItemSearch(this).ShowDialog(); ; 
        }
    }
}
