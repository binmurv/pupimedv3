using MetroFramework.Controls;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using ToastNotifications;
using PUPiMed;
using PUPiMed.UserControls;

namespace PUPiMed
{
    public partial class MainForm : MetroForm
    {

        LoginNew parent;
        private Color backColor1, backColor2, hover, selected;

        private void LoadMainForm()
        {
            this.StartTimer();
            this.InitializeComponent();
            this.lblTime.ForeColor = System.Drawing.Color.White;
            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0,0, Width, Height, 20, 20));
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            backColor1 = Color.Teal;
            backColor2 = Color.LightSeaGreen;
            hover = Color.LightCoral;
            selected = Color.Firebrick;
            changeUC(new UCHome());

            txtUser.Text = Program.getPrevCode("SELECT IFNULL((SELECT CONCAT(strUserFirstName, ' ', strUserLastName, ' - ',strUserJob) FROM tblUser WHERE strUserUName LIKE '"+LoginNew.user+"' AND strUserPassword LIKE PASSWORD('"+LoginNew.pass+"')), '"+LoginNew.user+"');");

            this.showExpiredNotif();
        }
        public MainForm(LoginNew parent)
        {
            this.parent = parent;
            this.LoadMainForm();
        }


        private void MainForm_Shown_1(object sender, EventArgs e)
        {
        }

        public MainForm()
        {
            LoadMainForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        public void showExpiredNotif()
        {
            //MySqlConnection notifConn = LoginNew.conn;
            //string query = "CALL notif();";
            //try
            //{
            //    if (notifConn != null && (notifConn.State == ConnectionState.Closed))
            //        notifConn.Open();
            //    using (MySqlCommand cmd = new MySqlCommand(query, notifConn))
            //    {
            //        using (MySqlDataReader dataReader = cmd.ExecuteReader())
            //        {
            //            //Read the data and store them in the list
            //            while (dataReader.Read())
            //            {
            //                ToastNotifications.Notification notif = new ToastNotifications.Notification(dataReader[0].ToString(), dataReader[1].ToString(), 7, ToastNotifications.FormAnimator.AnimationMethod.Slide, ToastNotifications.FormAnimator.AnimationDirection.Up);
            //                notif.Show();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Notif: " + ex.Message);
            //}
            //finally
            //{
            //    notifConn.Close();
            //}
            int exp, min, max;
            exp = Int32.Parse(Program.getPrevCode("select count(*) FROM vwnotif where type=0;"));
            min = Int32.Parse(Program.getPrevCode("select count(*) FROM vwnotif where type=1;"));
            max = Int32.Parse(Program.getPrevCode("select count(*) FROM vwnotif where type=2"));
            if (exp>0)
            {
                string strNotif = "A total of "+exp+" items have expired";
                ToastNotifications.Notification notif = new ToastNotifications.Notification("Expiration", strNotif, 7, ToastNotifications.FormAnimator.AnimationMethod.Slide, ToastNotifications.FormAnimator.AnimationDirection.Up, 0);
                notif.Show();
            }
            if(min > 0)
            {
                string strNotif = "A total of "+min+" items have reached their minimum stock level";
                ToastNotifications.Notification notif = new ToastNotifications.Notification("Stock Level", strNotif, 7, ToastNotifications.FormAnimator.AnimationMethod.Slide, ToastNotifications.FormAnimator.AnimationDirection.Up, 1);
                notif.Show();
            }
            if(max > 0)
            {
                string strNotif = "A total of "+max+" items have reached their maximum stock level";
                ToastNotifications.Notification notif = new ToastNotifications.Notification("Stock Level", strNotif, 7, ToastNotifications.FormAnimator.AnimationMethod.Slide, ToastNotifications.FormAnimator.AnimationDirection.Up, 1);
                notif.Show();
            }

            
        }

        private void resetColor(object sender)
        {
            try
            {
                MetroTile mtile = new MetroTile();
                mtile = sender as MetroTile;
                foreach (var tile in mpLeftPanel.Controls.OfType<MetroTile>())
                {
                    if (tile.Name != "mtLogout"&& tile.TabIndex%2==0)
                        tile.BackColor = backColor2;
                    else if (tile.Name != "mtLogout" && tile.TabIndex % 2 != 0)
                        tile.BackColor = backColor1;
                }
                mtile.BackColor = selected;
            }
            catch { }
        }

        private void StartTimer()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.ForeColor = System.Drawing.Color.White;
            lblTime.Text = DateTime.Now.ToLongDateString() +" "+ DateTime.Now.ToLongTimeString();
        }
        

        private void mpLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtMedicine_Click(object sender, EventArgs e)
        {
            changeUC(new UCItem(1));
            resetColor(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mtAdmin_Click(object sender, EventArgs e)
        {
            changeUC(new UCFacultyTab());
            resetColor(sender);
        }

        private void mtSupplies_Click(object sender, EventArgs e)
        {
            changeUC(new UCItem(2));
            resetColor(sender);
        }

        private void mtEquipment_Click(object sender, EventArgs e)
        {
            changeUC(new UCItem(3));
            resetColor(sender);
        }

        private void mtDistribute_Click(object sender, EventArgs e)
        {
            changeUC(new UCItemDistribution());
            resetColor(sender);
        }

        //private void mtStudent_Click(object sender, EventArgs e)
        //{
        //    changeUC(new UCMaintenance());
        //    resetColor(sender);
        //}

        private void mtFaculty_Click(object sender, EventArgs e)
        {
            changeUC(new UCAdminTab());
            resetColor(sender);
        }


        private void gridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tilelogout_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Dispose();
        }

        private void mtInventory_Click(object sender, EventArgs e)
        {
            changeUC(new UCItemInventory());
            resetColor(sender);
        }

        private void mtPatient_Click(object sender, EventArgs e)
        {
            changeUC(new UCPatientLogs_DTR_());
            resetColor(sender);
        }

        private void ItemLibrary_Click(object sender, EventArgs e)
        {
            changeUC(new UCItemLibrary());
            resetColor(sender);
        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void mtPatientRecords_Click(object sender, EventArgs e)
        {
            changeUC(new ucNotifications());
            resetColor(sender);
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
   
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
           
        }


        public void changeUC (UserControl uc)
        {
            try
            {
                //this.mpanel.Controls.Clear();
                //this.mpanel.Controls.Add(uc);
                
                Control ctrlOnScreen = uc;
                Control ctrlOffScreen = this.mpanel.Controls[0];
                this.mpanel.Controls.Add(ctrlOnScreen);
                ctrlOnScreen.BringToFront();
                ctrlOffScreen.SendToBack();
                this.Controls.Remove(ctrlOffScreen);
            }
            catch { }
        }
        


        private void picLogo_Click(object sender, EventArgs e)
        {
            foreach (var tile in mpLeftPanel.Controls.OfType<MetroTile>())
            {
                if (tile.Name != "mtLogout" && tile.TabIndex % 2 == 0)
                    tile.BackColor = backColor2;
                else if (tile.Name != "mtLogout" && tile.TabIndex % 2 != 0)
                    tile.BackColor = backColor1;
            }
            changeUC(new UCHome());
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            changeUC(new UCReceive());
            resetColor(sender);
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            try
            {
                MetroTile mtile = new MetroTile();
                mtile = sender as MetroTile;
                if (mtile.BackColor != selected)
                    mtile.BackColor = hover;
            }
            catch { }
        }

        private void mouseExit(object sender, EventArgs e)
        {
            try
            {
                MetroTile tile = sender as MetroTile;
                if (tile.BackColor != selected)
                {
                    if (tile.TabIndex % 2 == 0)
                        tile.BackColor = backColor2;
                    else if (tile.TabIndex % 2 != 0)
                        tile.BackColor = backColor1;
                }
            }
            catch { }
        }


        private void mtMaintenance_Click(object sender, EventArgs e)
        {
            UCMenuMaintenance uc = new UCMenuMaintenance(this);
            showMenu(uc, mtMaintenance.Location.X + this.Location.X + mtMaintenance.Width, mtMaintenance.Location.Y + this.Location.Y -2);
            resetColor(sender);
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UCReportSubMenu uc = new UCReportSubMenu(this);

            showMenu(uc, metroTile2.Location.X + this.Location.X + metroTile2.Width, (metroTile2.Height + metroTile2.Location.Y+ this.Location.Y) - uc.Height - 3);
            resetColor(sender);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        public void showMenu(UserControl uc, int x, int y)
        {
            formMenu menu = new formMenu(uc);
            menu.Location = new Point(x, y);
            menu.Show();
            menu.FormClosing += Menu_FormClosing;
            menu.Focus();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Focus();
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
    }
}
