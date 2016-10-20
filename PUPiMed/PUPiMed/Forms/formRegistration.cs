using MetroFramework;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PUPiMed.Forms
{
    public partial class formRegistration : MetroFramework.Forms.MetroForm
    {
        string server;
        public formRegistration(string server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void formRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)          
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtJob.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                error("Please fill out all the fields");
            }else
            {
                try
                {
                    string query =
                        "CREATE USER '" + txtUsername.Text + "'@'%';" +
                        "SET PASSWORD FOR '" + txtUsername.Text + "'@'%' = PASSWORD('" + txtPassword.Text + "');" +
                        "GRANT SELECT, INSERT, EXECUTE, SHOW VIEW, TRIGGER ON dbMedicalClinic.* TO '" + txtUsername.Text + "'@'%';" +
                        "INSERT INTO `dbmedicalclinic`.`tbluser` (`strUserUName`, `strUserPassword`, `strUserFirstName`, `strUserMiddleName`, `strUserLastName`, `strUserJob`) VALUES ('" + txtUsername.Text + "', PASSWORD('" + txtPassword.Text + "'), '" + txtFName.Text + "', '" + txtMName.Text + "', '" + txtLName.Text + "', '" + txtJob.Text + "');";
                    //MessageBox.Show(query);
                    LoginNew.setConnection(txtAUsername.Text, txtAPassword.Text);
                    if (Program.ExecuteQuery(query))
                    {
                        status.BackColor = System.Drawing.Color.LimeGreen;
                        status.Text = "User " + txtUsername.Text + " successfully created";
                        foreach (MetroTextBox txtbox in this.groupBox1.Controls.OfType<MetroTextBox>())
                        {
                            txtbox.Clear();
                        }
                        foreach (MetroTextBox txtbox in this.groupBox2.Controls.OfType<MetroTextBox>())
                        {
                            txtbox.Clear();
                        }
                    }
                    //if (Program.ExecuteQuery("CREATE USER '" + txtUsername.Text + "'@'%';"))
                    //{
                    //    if (Program.ExecuteQuery("SET PASSWORD FOR '" + txtUsername.Text + "'@'%' = PASSWORD('" + txtPassword.Text + "');"))
                    //    {
                    //        if (Program.ExecuteQuery("GRANT SELECT, INSERT, EXECUTE, SHOW VIEW, TRIGGER ON dbMedicalClinic.* TO '" + txtUsername.Text + "'@'%';"))
                    //        {
                    //            if (Program.ExecuteQuery("INSERT INTO `dbmedicalclinic`.`tbluser` (`strUserUName`, `strUserPassword`, `strUserName`, `strUserJob`) VALUES ('" + txtUsername.Text + "', PASSWORD('" + txtPassword.Text + "'), '" + txtName.Text + "', '" + txtJob.Text + "');"))
                    //            {
                    //                Program.ExecuteQuery("COMMIT;");
                    //                status.BackColor = System.Drawing.Color.LimeGreen;
                    //                status.Text = "User " + txtUsername.Text + " successfully created";
                    //                foreach (MetroTextBox txtbox in this.Controls.OfType<MetroTextBox>())
                    //                {
                    //                    txtbox.Clear();
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    LoginNew.conn.Close();
                }
            }
                
        }

        private void error (string text)
        {
            status.BackColor = System.Drawing.Color.Tomato;
            status.Text = text;
        }
    }
}
