namespace PUPiMed
{
    partial class FormAddPatientLogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPatientLogs));
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.suppcode = new MetroFramework.Controls.MetroLabel();
            this.status = new MetroFramework.Controls.MetroTile();
            this.title = new System.Windows.Forms.Label();
            this.cbName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbMedsGiven = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.lblAdvanced = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.txtTreatments = new MetroFramework.Controls.MetroTextBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.txtComplaints = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAvailable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.listMedsGiven = new MetroFramework.Controls.MetroGrid();
            this.Meds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.Medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMedsGiven)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "patientCode";
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(175, 33);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(219, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 2;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseCustomForeColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click_1);
            // 
            // suppcode
            // 
            this.suppcode.AccessibleName = "patientCode";
            this.suppcode.AutoSize = true;
            this.suppcode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.suppcode.Location = new System.Drawing.Point(37, 37);
            this.suppcode.Name = "suppcode";
            this.suppcode.Size = new System.Drawing.Size(122, 19);
            this.suppcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.suppcode.TabIndex = 29;
            this.suppcode.Text = "Patient Log Code :";
            // 
            // status
            // 
            this.status.AccessibleName = "basicinfos";
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Enabled = false;
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(0, 71);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(843, 32);
            this.status.TabIndex = 109;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseCustomForeColor = true;
            this.status.UseSelectable = true;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(192, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(419, 61);
            this.title.TabIndex = 110;
            this.title.Text = "ADD PATIENT : PATIENT LOGS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbName
            // 
            this.cbName.AccessibleName = "ptype";
            this.cbName.BackColor = System.Drawing.Color.White;
            this.cbName.DropDownHeight = 200;
            this.cbName.DropDownWidth = 284;
            this.cbName.FormattingEnabled = true;
            this.cbName.IntegralHeight = false;
            this.cbName.ItemHeight = 23;
            this.cbName.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Admin"});
            this.cbName.Location = new System.Drawing.Point(175, 79);
            this.cbName.MaxDropDownItems = 10;
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(184, 29);
            this.cbName.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbName.TabIndex = 3;
            this.cbName.UseSelectable = true;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "ptype";
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(37, 90);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(108, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel8.TabIndex = 111;
            this.metroLabel8.Text = "Patient\'s Name :";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "ptype";
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(36, 242);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 114;
            this.metroLabel1.Text = "Complaints :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "ptype";
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(36, 303);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 116;
            this.metroLabel2.Text = "Treatments :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMedsGiven
            // 
            this.cbMedsGiven.AccessibleName = "cbMedsGiven";
            this.cbMedsGiven.BackColor = System.Drawing.Color.White;
            this.cbMedsGiven.DropDownHeight = 200;
            this.cbMedsGiven.FormattingEnabled = true;
            this.cbMedsGiven.IntegralHeight = false;
            this.cbMedsGiven.ItemHeight = 23;
            this.cbMedsGiven.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Admin"});
            this.cbMedsGiven.Location = new System.Drawing.Point(94, 33);
            this.cbMedsGiven.MaxDropDownItems = 10;
            this.cbMedsGiven.Name = "cbMedsGiven";
            this.cbMedsGiven.Size = new System.Drawing.Size(217, 29);
            this.cbMedsGiven.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbMedsGiven.TabIndex = 9;
            this.cbMedsGiven.UseSelectable = true;
            this.cbMedsGiven.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            this.cbMedsGiven.Click += new System.EventHandler(this.txtCode_Click_1);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "ptype";
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(17, 37);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 119;
            this.metroLabel3.Text = "Medicine :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "ptype";
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 120;
            this.metroLabel4.Text = "Quantity :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "ptype";
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(36, 198);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 123;
            this.metroLabel5.Text = "Time :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.lblAdvanced);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.txtTreatments);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtComplaints);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.suppcode);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources.adad;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(365, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::PUPiMed.Properties.Resources.refresh_icon_png_2;
            this.refresh.Location = new System.Drawing.Point(174, 111);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(27, 15);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 168;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.AutoSize = true;
            this.lblAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdvanced.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAdvanced.ForeColor = System.Drawing.Color.Navy;
            this.lblAdvanced.Location = new System.Drawing.Point(207, 111);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(100, 15);
            this.lblAdvanced.TabIndex = 167;
            this.lblAdvanced.Text = "Advanced Options";
            this.lblAdvanced.UseCustomBackColor = true;
            this.lblAdvanced.UseCustomForeColor = true;
            this.lblAdvanced.UseStyleColors = true;
            this.lblAdvanced.Click += new System.EventHandler(this.lblAdvanced_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "ptype";
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(37, 146);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 128;
            this.metroLabel6.Text = "Date :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtDate
            // 
            this.dtDate.AllowDrop = true;
            this.dtDate.Checked = false;
            this.dtDate.DisplayFocus = true;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(175, 146);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(219, 29);
            this.dtDate.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtDate.TabIndex = 5;
            this.dtDate.UseStyleColors = true;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // txtTreatments
            // 
            this.txtTreatments.AccessibleName = "txtqty";
            this.txtTreatments.Lines = new string[0];
            this.txtTreatments.Location = new System.Drawing.Point(175, 303);
            this.txtTreatments.MaxLength = 32767;
            this.txtTreatments.Multiline = true;
            this.txtTreatments.Name = "txtTreatments";
            this.txtTreatments.PasswordChar = '\0';
            this.txtTreatments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTreatments.SelectedText = "";
            this.txtTreatments.Size = new System.Drawing.Size(219, 50);
            this.txtTreatments.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtTreatments.TabIndex = 7;
            this.txtTreatments.UseCustomBackColor = true;
            this.txtTreatments.UseSelectable = true;
            this.txtTreatments.Click += new System.EventHandler(this.txtCode_Click_1);
            // 
            // dtTime
            // 
            this.dtTime.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtTime.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(174, 198);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(219, 24);
            this.dtTime.TabIndex = 4;
            this.dtTime.ValueChanged += new System.EventHandler(this.dtTimeIn_ValueChanged_1);
            // 
            // txtComplaints
            // 
            this.txtComplaints.AccessibleName = "txtqty";
            this.txtComplaints.Lines = new string[0];
            this.txtComplaints.Location = new System.Drawing.Point(175, 242);
            this.txtComplaints.MaxLength = 32767;
            this.txtComplaints.Multiline = true;
            this.txtComplaints.Name = "txtComplaints";
            this.txtComplaints.PasswordChar = '\0';
            this.txtComplaints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComplaints.SelectedText = "";
            this.txtComplaints.Size = new System.Drawing.Size(219, 50);
            this.txtComplaints.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtComplaints.TabIndex = 6;
            this.txtComplaints.UseCustomBackColor = true;
            this.txtComplaints.UseSelectable = true;
            this.txtComplaints.Click += new System.EventHandler(this.txtCode_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAvailable);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.listMedsGiven);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.cbMedsGiven);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(487, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 362);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicine/s Given";
            // 
            // txtAvailable
            // 
            this.txtAvailable.AccessibleName = "";
            this.txtAvailable.BackColor = System.Drawing.Color.Transparent;
            this.txtAvailable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtAvailable.Location = new System.Drawing.Point(94, 110);
            this.txtAvailable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(217, 20);
            this.txtAvailable.TabIndex = 134;
            this.txtAvailable.Text = "0";
            this.txtAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAvailable.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(18, 111);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 20);
            this.metroLabel7.TabIndex = 133;
            this.metroLabel7.Text = "Available :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(94, 75);
            this.txtQty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(220, 22);
            this.txtQty.TabIndex = 10;
            // 
            // listMedsGiven
            // 
            this.listMedsGiven.AllowUserToAddRows = false;
            this.listMedsGiven.AllowUserToDeleteRows = false;
            this.listMedsGiven.AllowUserToResizeRows = false;
            this.listMedsGiven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMedsGiven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMedsGiven.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listMedsGiven.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMedsGiven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listMedsGiven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listMedsGiven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meds,
            this.colQty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listMedsGiven.DefaultCellStyle = dataGridViewCellStyle2;
            this.listMedsGiven.EnableHeadersVisualStyles = false;
            this.listMedsGiven.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listMedsGiven.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMedsGiven.Location = new System.Drawing.Point(13, 198);
            this.listMedsGiven.MultiSelect = false;
            this.listMedsGiven.Name = "listMedsGiven";
            this.listMedsGiven.ReadOnly = true;
            this.listMedsGiven.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMedsGiven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listMedsGiven.RowHeadersVisible = false;
            this.listMedsGiven.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listMedsGiven.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listMedsGiven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMedsGiven.ShowCellErrors = false;
            this.listMedsGiven.ShowCellToolTips = false;
            this.listMedsGiven.ShowEditingIcon = false;
            this.listMedsGiven.ShowRowErrors = false;
            this.listMedsGiven.Size = new System.Drawing.Size(293, 154);
            this.listMedsGiven.StandardTab = true;
            this.listMedsGiven.Style = MetroFramework.MetroColorStyle.Teal;
            this.listMedsGiven.TabIndex = 14;
            this.listMedsGiven.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listMedsGiven.UseCustomBackColor = true;
            this.listMedsGiven.UseCustomForeColor = true;
            this.listMedsGiven.UseStyleColors = true;
            this.listMedsGiven.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.listMedsGiven_RowsAdded);
            this.listMedsGiven.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.listMedsGiven_RowsRemoved);
            this.listMedsGiven.SelectionChanged += new System.EventHandler(this.listMedsGiven_SelectionChanged);
            // 
            // Meds
            // 
            this.Meds.FillWeight = 194.9239F;
            this.Meds.HeaderText = "Medicine";
            this.Meds.Name = "Meds";
            this.Meds.ReadOnly = true;
            this.Meds.Width = 200;
            // 
            // colQty
            // 
            this.colQty.FillWeight = 5.076141F;
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // metroButton1
            // 
            this.metroButton1.AccessibleName = "btnadd";
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(56, 146);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(68, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "btnadd";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Highlight = true;
            this.btnDelete.Location = new System.Drawing.Point(204, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 29);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleName = "btnadd";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.Highlight = true;
            this.btnEdit.Location = new System.Drawing.Point(130, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 29);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Medicine
            // 
            this.Medicine.Text = "Medicine";
            this.Medicine.Width = 169;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 73;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::PUPiMed.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(711, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 190;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::PUPiMed.Properties.Resources.save2;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(593, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.TabIndex = 189;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddPatientLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 545);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddPatientLogs";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMedsGiven)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel suppcode;
        private MetroFramework.Controls.MetroTile status;
        private System.Windows.Forms.Label title;
        private MetroFramework.Controls.MetroComboBox cbName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbMedsGiven;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtComplaints;
        private MetroFramework.Controls.MetroTextBox txtTreatments;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtDate;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private System.Windows.Forms.ColumnHeader Medicine;
        private System.Windows.Forms.ColumnHeader Quantity;
        private MetroFramework.Controls.MetroGrid listMedsGiven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        public System.Windows.Forms.NumericUpDown txtQty;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox refresh;
        private MetroFramework.Controls.MetroLabel lblAdvanced;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroLabel txtAvailable;
    }
}