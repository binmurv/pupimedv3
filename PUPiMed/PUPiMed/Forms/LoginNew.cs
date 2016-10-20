using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ToastNotifications;

namespace PUPiMed
{
    public partial class LoginNew : MetroForm
    {
        public static MySqlConnection conn = new MySqlConnection();
        public static string server = "localhost";//"192.168.43.112"; 
        public static string user;
        public static string pass;
        public static string db = "dbmedicalclinic";
        //public static string connString = 
        //            "server = MySql;" +
        //            "user id = root;" +
        //            "database = dbmedicalclinic;";


        public LoginNew()
        {
            InitializeComponent();
           // Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0,0, Width, Height, 20, 20));
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            login(txtUser.Text, txtPass.Text);
        }

        public void login(string user, string pass)
        {
            try
            {
                LoginNew.setConnection(user,pass, txtServer.Text, LoginNew.db);
                LoginNew.conn.Open();
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Open))
                {
                    this.txtPass.Clear();
                    this.txtUser.Clear();
                    new MainForm(this).Show();
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "Access Denied", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Access Denied", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            finally
            {
                LoginNew.conn.Close();
            }
            
        }

        public static void setConnection (string user, string pass)
        {
            LoginNew.user = user;
            LoginNew.pass = pass;

            LoginNew.conn.ConnectionString =
                    "server = " + LoginNew.server + ";" +
                    "user id =" + LoginNew.user + ";" +
                    "password=" + LoginNew.pass + ";" +
                    "database=" + LoginNew.db + ";";
        }

        public static void setConnection(string user, string pass, string server)
        {
            LoginNew.user = user;
            LoginNew.pass = pass;
            LoginNew.server = server;

            LoginNew.conn.ConnectionString =
                    "server = " + LoginNew.server + ";" +
                    "user id =" + LoginNew.user + ";" +
                    "password=" + LoginNew.pass + ";" +
                    "database=" + LoginNew.db + ";";
        }

        public static void setConnection(string user, string pass, string server,  string database)
        {
            LoginNew.user = user;
            LoginNew.pass = pass;
            LoginNew.server = server;
            LoginNew.db = database;

            LoginNew.conn.ConnectionString =
                    "server = " + LoginNew.server + ";" +
                    "user id =" + LoginNew.user + ";" +
                    "password=" + LoginNew.pass + ";" +
                    "database=" + LoginNew.db + ";";
        }

        public static string getConnection()
        {
            return LoginNew.conn.ConnectionString;
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginNew_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void lblNewAccount_Click(object sender, EventArgs e)
        {
           new Forms.formRegistration(txtServer.Text).ShowDialog();
        }

        private void txtServer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            (sender as Button).Enabled = true;
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            LoginNew.server = txtServer.Text;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_Click(object sender, EventArgs e)
        {

        }
    }
}
