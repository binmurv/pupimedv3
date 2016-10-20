using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PUPiMed
{
    public partial class UCPatientLogs_DTR_ : UserControl
    {
        public string strQuery;

        public UCPatientLogs_DTR_()
        {
            InitializeComponent();
            strQuery = "SELECT `Date`, `Time In`, `First Name`, `Middle Name`, `Last Name`, `Department`, `Complaints` FROM vwlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%';";
            
            updateTable();
        }

        public void updateTable()
        {
            try
            {
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
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message.ToString());
            }
            finally
            {
                LoginNew.conn.Close();
            }
        }

        private void gridDTR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new FormAddPatientLogs(this).ShowDialog();
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            strQuery = "SELECT `Date`, `Time In`, `First Name`, `Middle Name`, `Last Name`, `Department`, `Complaints` FROM vwlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%' ";
            new FormPatientSearch(this).ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            strQuery = "SELECT `Date`, `Time In`, `First Name`, `Middle Name`, `Last Name`, `Department`, `Complaints` FROM vwlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }
    }
}
