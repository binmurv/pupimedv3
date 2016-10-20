using MetroFramework.Controls;
using System.Drawing;

namespace PUPiMed
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpLeftPanel = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroLabel();
            this.mtMaintenance = new MetroFramework.Controls.MetroTile();
            this.picItemLibrary = new System.Windows.Forms.PictureBox();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtNotifications = new MetroFramework.Controls.MetroTile();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.mtDistribute = new MetroFramework.Controls.MetroTile();
            this.picItemDistribution = new System.Windows.Forms.PictureBox();
            this.mtPatient = new MetroFramework.Controls.MetroTile();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mtInventory = new MetroFramework.Controls.MetroTile();
            this.picItemInventory = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mpanel = new MetroFramework.Controls.MetroPanel();
            this.mpLeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mtMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemLibrary)).BeginInit();
            this.metroTile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mtNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.mtDistribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemDistribution)).BeginInit();
            this.mtPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.mtInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mpLeftPanel
            // 
            this.mpLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpLeftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mpLeftPanel.Controls.Add(this.panel1);
            this.mpLeftPanel.Controls.Add(this.mtMaintenance);
            this.mpLeftPanel.Controls.Add(this.mtLogout);
            this.mpLeftPanel.Controls.Add(this.metroTile2);
            this.mpLeftPanel.Controls.Add(this.metroTile1);
            this.mpLeftPanel.Controls.Add(this.mtNotifications);
            this.mpLeftPanel.Controls.Add(this.mtDistribute);
            this.mpLeftPanel.Controls.Add(this.mtPatient);
            this.mpLeftPanel.Controls.Add(this.mtInventory);
            this.mpLeftPanel.Controls.Add(this.picLogo);
            this.mpLeftPanel.Controls.Add(this.label1);
            this.mpLeftPanel.HorizontalScrollbarBarColor = true;
            this.mpLeftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpLeftPanel.HorizontalScrollbarSize = 10;
            this.mpLeftPanel.Location = new System.Drawing.Point(-1, -2);
            this.mpLeftPanel.Name = "mpLeftPanel";
            this.mpLeftPanel.Size = new System.Drawing.Size(292, 679);
            this.mpLeftPanel.Style = MetroFramework.MetroColorStyle.Red;
            this.mpLeftPanel.TabIndex = 0;
            this.mpLeftPanel.UseCustomBackColor = true;
            this.mpLeftPanel.UseStyleColors = true;
            this.mpLeftPanel.VerticalScrollbarBarColor = true;
            this.mpLeftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpLeftPanel.VerticalScrollbarSize = 10;
            this.mpLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpLeftPanel_Paint);
            this.mpLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mpLeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mpLeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 47);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(18, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(129, 19);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0000-00-00 00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.UseCustomBackColor = true;
            this.lblTime.UseCustomForeColor = true;
            this.lblTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.lblTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.lblTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(18, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "User: ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtUser
            // 
            this.txtUser.FontSize = MetroFramework.MetroLabelSize.Small;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(57, 1);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(234, 19);
            this.txtUser.TabIndex = 16;
            this.txtUser.Text = " ";
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.UseCustomBackColor = true;
            this.txtUser.UseCustomForeColor = true;
            this.txtUser.WrapToLine = true;
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mtMaintenance
            // 
            this.mtMaintenance.ActiveControl = null;
            this.mtMaintenance.AllowDrop = true;
            this.mtMaintenance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtMaintenance.BackColor = System.Drawing.Color.Teal;
            this.mtMaintenance.Controls.Add(this.picItemLibrary);
            this.mtMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtMaintenance.ForeColor = System.Drawing.Color.White;
            this.mtMaintenance.Location = new System.Drawing.Point(1, 180);
            this.mtMaintenance.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtMaintenance.Name = "mtMaintenance";
            this.mtMaintenance.Size = new System.Drawing.Size(291, 62);
            this.mtMaintenance.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtMaintenance.TabIndex = 1;
            this.mtMaintenance.Text = "           Maintenance";
            this.mtMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtMaintenance.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtMaintenance.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtMaintenance.UseCustomBackColor = true;
            this.mtMaintenance.UseCustomForeColor = true;
            this.mtMaintenance.UseSelectable = true;
            this.mtMaintenance.Click += new System.EventHandler(this.mtMaintenance_Click);
            this.mtMaintenance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mtMaintenance.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.mtMaintenance.MouseLeave += new System.EventHandler(this.mouseExit);
            this.mtMaintenance.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mtMaintenance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // picItemLibrary
            // 
            this.picItemLibrary.Image = global::PUPiMed.Properties.Resources.maintenance21;
            this.picItemLibrary.Location = new System.Drawing.Point(18, 12);
            this.picItemLibrary.Name = "picItemLibrary";
            this.picItemLibrary.Size = new System.Drawing.Size(40, 39);
            this.picItemLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemLibrary.TabIndex = 0;
            this.picItemLibrary.TabStop = false;
            this.picItemLibrary.Click += new System.EventHandler(this.mtMaintenance_Click);
            this.picItemLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picItemLibrary.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picItemLibrary.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mtLogout
            // 
            this.mtLogout.AccessibleName = "Logout";
            this.mtLogout.ActiveControl = null;
            this.mtLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtLogout.Location = new System.Drawing.Point(18, 624);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(98, 40);
            this.mtLogout.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtLogout.TabIndex = 10;
            this.mtLogout.Text = "LOG OUT";
            this.mtLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtLogout.TileImage = global::PUPiMed.Properties.Resources.logout;
            this.mtLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtLogout.UseCustomBackColor = true;
            this.mtLogout.UseCustomForeColor = true;
            this.mtLogout.UseSelectable = true;
            this.mtLogout.UseStyleColors = true;
            this.mtLogout.UseTileImage = true;
            this.mtLogout.Click += new System.EventHandler(this.tilelogout_Click);
            this.mtLogout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mtLogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mtLogout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.AllowDrop = true;
            this.metroTile2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.metroTile2.Controls.Add(this.pictureBox2);
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.ForeColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(1, 490);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(291, 62);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 6;
            this.metroTile2.Text = "           Reports";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            this.metroTile2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroTile2.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.metroTile2.MouseLeave += new System.EventHandler(this.mouseExit);
            this.metroTile2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroTile2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PUPiMed.Properties.Resources.report;
            this.pictureBox2.Location = new System.Drawing.Point(17, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.metroTile2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.AllowDrop = true;
            this.metroTile1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile1.BackColor = System.Drawing.Color.Teal;
            this.metroTile1.Controls.Add(this.pictureBox1);
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(1, 304);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(291, 62);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "           Receive Inventory";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTile1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroTile1.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.metroTile1.MouseLeave += new System.EventHandler(this.mouseExit);
            this.metroTile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroTile1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PUPiMed.Properties.Resources.receiveinventoryy;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.metroTile1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mtNotifications
            // 
            this.mtNotifications.ActiveControl = null;
            this.mtNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtNotifications.BackColor = System.Drawing.Color.Teal;
            this.mtNotifications.Controls.Add(this.pictureBox10);
            this.mtNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtNotifications.ForeColor = System.Drawing.Color.White;
            this.mtNotifications.Location = new System.Drawing.Point(1, 552);
            this.mtNotifications.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtNotifications.Name = "mtNotifications";
            this.mtNotifications.Size = new System.Drawing.Size(291, 62);
            this.mtNotifications.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtNotifications.TabIndex = 7;
            this.mtNotifications.Text = "           Notifications";
            this.mtNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtNotifications.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtNotifications.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtNotifications.UseCustomBackColor = true;
            this.mtNotifications.UseCustomForeColor = true;
            this.mtNotifications.UseSelectable = true;
            this.mtNotifications.Click += new System.EventHandler(this.mtPatientRecords_Click);
            this.mtNotifications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mtNotifications.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.mtNotifications.MouseLeave += new System.EventHandler(this.mouseExit);
            this.mtNotifications.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mtNotifications.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PUPiMed.Properties.Resources.error_104px1;
            this.pictureBox10.Location = new System.Drawing.Point(18, 14);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.mtPatientRecords_Click);
            this.pictureBox10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mtDistribute
            // 
            this.mtDistribute.ActiveControl = null;
            this.mtDistribute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtDistribute.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtDistribute.Controls.Add(this.picItemDistribution);
            this.mtDistribute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDistribute.ForeColor = System.Drawing.Color.White;
            this.mtDistribute.Location = new System.Drawing.Point(1, 366);
            this.mtDistribute.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtDistribute.Name = "mtDistribute";
            this.mtDistribute.Size = new System.Drawing.Size(291, 62);
            this.mtDistribute.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtDistribute.TabIndex = 4;
            this.mtDistribute.Text = "           Item Distribution";
            this.mtDistribute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDistribute.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtDistribute.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDistribute.UseCustomBackColor = true;
            this.mtDistribute.UseCustomForeColor = true;
            this.mtDistribute.UseSelectable = true;
            this.mtDistribute.Click += new System.EventHandler(this.mtDistribute_Click);
            this.mtDistribute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mtDistribute.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.mtDistribute.MouseLeave += new System.EventHandler(this.mouseExit);
            this.mtDistribute.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mtDistribute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // picItemDistribution
            // 
            this.picItemDistribution.Image = global::PUPiMed.Properties.Resources.truck_52px;
            this.picItemDistribution.Location = new System.Drawing.Point(18, 12);
            this.picItemDistribution.Name = "picItemDistribution";
            this.picItemDistribution.Size = new System.Drawing.Size(40, 35);
            this.picItemDistribution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemDistribution.TabIndex = 0;
            this.picItemDistribution.TabStop = false;
            this.picItemDistribution.Click += new System.EventHandler(this.mtDistribute_Click);
            this.picItemDistribution.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picItemDistribution.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picItemDistribution.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mtPatient
            // 
            this.mtPatient.ActiveControl = null;
            this.mtPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtPatient.BackColor = System.Drawing.Color.Teal;
            this.mtPatient.Controls.Add(this.pictureBox6);
            this.mtPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtPatient.ForeColor = System.Drawing.Color.White;
            this.mtPatient.Location = new System.Drawing.Point(1, 428);
            this.mtPatient.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtPatient.Name = "mtPatient";
            this.mtPatient.Size = new System.Drawing.Size(291, 62);
            this.mtPatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPatient.TabIndex = 5;
            this.mtPatient.Text = "           Patient Logs";
            this.mtPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtPatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPatient.UseCustomBackColor = true;
            this.mtPatient.UseCustomForeColor = true;
            this.mtPatient.UseSelectable = true;
            this.mtPatient.Click += new System.EventHandler(this.mtPatient_Click);
            this.mtPatient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mtPatient.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.mtPatient.MouseLeave += new System.EventHandler(this.mouseExit);
            this.mtPatient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mtPatient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PUPiMed.Properties.Resources.patient_white;
            this.pictureBox6.Location = new System.Drawing.Point(18, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.mtPatient_Click);
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mtInventory
            // 
            this.mtInventory.ActiveControl = null;
            this.mtInventory.AllowDrop = true;
            this.mtInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtInventory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtInventory.Controls.Add(this.picItemInventory);
            this.mtInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtInventory.ForeColor = System.Drawing.Color.White;
            this.mtInventory.Location = new System.Drawing.Point(1, 242);
            this.mtInventory.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtInventory.Name = "mtInventory";
            this.mtInventory.Size = new System.Drawing.Size(291, 62);
            this.mtInventory.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtInventory.TabIndex = 2;
            this.mtInventory.Text = "           Item Inventory";
            this.mtInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtInventory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtInventory.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtInventory.UseCustomBackColor = true;
            this.mtInventory.UseCustomForeColor = true;
            this.mtInventory.UseSelectable = true;
            this.mtInventory.UseStyleColors = true;
            this.mtInventory.Click += new System.EventHandler(this.mtInventory_Click);
            this.mtInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mtInventory.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.mtInventory.MouseLeave += new System.EventHandler(this.mouseExit);
            this.mtInventory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mtInventory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // picItemInventory
            // 
            this.picItemInventory.Image = global::PUPiMed.Properties.Resources._01inventory;
            this.picItemInventory.Location = new System.Drawing.Point(18, 6);
            this.picItemInventory.Name = "picItemInventory";
            this.picItemInventory.Size = new System.Drawing.Size(45, 45);
            this.picItemInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemInventory.TabIndex = 0;
            this.picItemInventory.TabStop = false;
            this.picItemInventory.Click += new System.EventHandler(this.mtInventory_Click);
            this.picItemInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picItemInventory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picItemInventory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::PUPiMed.Properties.Resources.l1;
            this.picLogo.Location = new System.Drawing.Point(38, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(214, 99);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Logs and Inventory System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.picLogo_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // mpanel
            // 
            this.mpanel.AccessibleName = "mpanel";
            this.mpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpanel.AutoSize = true;
            this.mpanel.BackColor = System.Drawing.SystemColors.Control;
            this.mpanel.HorizontalScrollbarBarColor = true;
            this.mpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanel.HorizontalScrollbarSize = 10;
            this.mpanel.Location = new System.Drawing.Point(291, 0);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(864, 676);
            this.mpanel.TabIndex = 4;
            this.mpanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mpanel.UseCustomBackColor = true;
            this.mpanel.UseCustomForeColor = true;
            this.mpanel.VerticalScrollbarBarColor = true;
            this.mpanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpanel.VerticalScrollbarSize = 10;
            this.mpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpanel_Paint);
            this.mpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::PUPiMed.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::PUPiMed.Properties.Resources.bg;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1155, 676);
            this.Controls.Add(this.mpanel);
            this.Controls.Add(this.mpLeftPanel);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1155, 676);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.mpLeftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mtMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemLibrary)).EndInit();
            this.metroTile2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mtNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.mtDistribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemDistribution)).EndInit();
            this.mtPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.mtInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        
        #endregion

        private MetroFramework.Controls.MetroPanel mpLeftPanel;
        private MetroFramework.Controls.MetroTile mtInventory;
        private MetroFramework.Controls.MetroTile mtPatient;
        private MetroFramework.Controls.MetroTile mtDistribute;
        private MetroFramework.Controls.MetroTile mtNotifications;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroTile mtLogout;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox picItemDistribution;
        private System.Windows.Forms.PictureBox picItemInventory;
        private System.Windows.Forms.PictureBox picItemLibrary;
        private MetroLabel lblTime;
        private MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroPanel mpanel;
        public MetroTile mtMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroLabel metroLabel1;
        private MetroLabel txtUser;
    }
}