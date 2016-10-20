using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        
        public static string user, pass;

        private void btnLOGIN_Click(object sender, System.EventArgs e)
        {
            //Login.user = txtUser.Text;
            //Login.pass = txtPass.Text;
            setLogin(txtUser.Text,txtPass.Text);
            try
            {
                Program.login();
                //Program.conn.Open();
                if (Program.conn != null)
                    new MainForm().ShowDialog();
                
            }
            catch (Exception ex){
                MetroMessageBox.Show(this, "Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void setLogin(string user, string pass)
        {
            Login.user = user;
            Login.pass = pass;
        }
        
        public static string getUser()
        {
            return user;
        }
        public static string getPass()
        {
            return pass;
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            StartTimer();
        }
        private void StartTimer()
        {
            System.Windows.Forms.Timer timer1 = null;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
