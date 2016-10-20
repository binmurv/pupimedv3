using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PUPiMed
{
    public partial class ucNotifications : UserControl
    {
        public ucNotifications()
        {
            InitializeComponent();
        }

        private void ucNotifications_Load(object sender, EventArgs e)
        {
            updateTable();
        }
        string strQuery = "CALL notif()";
        public void updateTable()
        {
            using (LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(strQuery, LoginNew.conn))
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
}
