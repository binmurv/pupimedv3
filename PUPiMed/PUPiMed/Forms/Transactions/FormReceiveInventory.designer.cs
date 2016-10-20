namespace PUPiMed
{
    partial class FormReceiveInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiveInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.dtReceived = new MetroFramework.Controls.MetroDateTime();
            this.cbSupplier = new MetroFramework.Controls.MetroComboBox();
            this.txtRCode = new MetroFramework.Controls.MetroTextBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeliveryNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pbAddSupplier = new System.Windows.Forms.PictureBox();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSeyb = new System.Windows.Forms.Button();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.cbName = new MetroFramework.Controls.MetroComboBox();
            this.dtExp = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.listDetail = new MetroFramework.Controls.MetroGrid();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAddItem = new System.Windows.Forms.PictureBox();
            this.status = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(387, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 70);
            this.label1.TabIndex = 26;
            this.label1.Text = "Receive Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // dtReceived
            // 
            this.dtReceived.AllowDrop = true;
            this.dtReceived.Checked = false;
            this.dtReceived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtReceived.DisplayFocus = true;
            this.dtReceived.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceived.Location = new System.Drawing.Point(11, 224);
            this.dtReceived.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReceived.Name = "dtReceived";
            this.dtReceived.Size = new System.Drawing.Size(218, 29);
            this.dtReceived.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtReceived.TabIndex = 13;
            this.dtReceived.UseStyleColors = true;
            this.dtReceived.ValueChanged += new System.EventHandler(this.dtReceived_ValueChanged);
            this.dtReceived.DropDown += new System.EventHandler(this.dtReceived_DropDown);
            // 
            // cbSupplier
            // 
            this.cbSupplier.BackColor = System.Drawing.Color.White;
            this.cbSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSupplier.DisplayFocus = true;
            this.cbSupplier.DropDownHeight = 200;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.IntegralHeight = false;
            this.cbSupplier.ItemHeight = 23;
            this.cbSupplier.Location = new System.Drawing.Point(11, 298);
            this.cbSupplier.MaxDropDownItems = 10;
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(183, 29);
            this.cbSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbSupplier.TabIndex = 14;
            this.cbSupplier.UseCustomBackColor = true;
            this.cbSupplier.UseCustomForeColor = true;
            this.cbSupplier.UseSelectable = true;
            this.cbSupplier.UseStyleColors = true;
            this.cbSupplier.Click += new System.EventHandler(this.cbType_Click);
            // 
            // txtRCode
            // 
            this.txtRCode.AccessibleName = "";
            this.txtRCode.BackColor = System.Drawing.Color.White;
            this.txtRCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRCode.Lines = new string[0];
            this.txtRCode.Location = new System.Drawing.Point(11, 87);
            this.txtRCode.MaxLength = 15;
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.PasswordChar = '\0';
            this.txtRCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRCode.SelectedText = "";
            this.txtRCode.Size = new System.Drawing.Size(218, 29);
            this.txtRCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtRCode.TabIndex = 11;
            this.txtRCode.UseCustomBackColor = true;
            this.txtRCode.UseSelectable = true;
            this.txtRCode.TextChanged += new System.EventHandler(this.txtDeliveryNo_TextChanged);
            this.txtRCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtRCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtRCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(11, 65);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 19);
            this.lblCode.TabIndex = 116;
            this.lblCode.Text = "Receiving Code   :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCode.UseCustomBackColor = true;
            this.lblCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.lblCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.lblCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "";
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(11, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 19);
            this.metroLabel1.TabIndex = 117;
            this.metroLabel1.Text = "Date Received   :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "";
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(11, 276);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 118;
            this.metroLabel2.Text = "Supplier   :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtDeliveryNo);
            this.groupBox1.Controls.Add(this.txtRCode);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.pbAddSupplier);
            this.groupBox1.Controls.Add(this.cbSupplier);
            this.groupBox1.Controls.Add(this.dtReceived);
            this.groupBox1.Controls.Add(this.btnCansel);
            this.groupBox1.Controls.Add(this.btnSeyb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(789, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 478);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiving Information";
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.AccessibleName = "";
            this.txtDeliveryNo.BackColor = System.Drawing.Color.White;
            this.txtDeliveryNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDeliveryNo.Lines = new string[0];
            this.txtDeliveryNo.Location = new System.Drawing.Point(11, 154);
            this.txtDeliveryNo.MaxLength = 32767;
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.PasswordChar = '\0';
            this.txtDeliveryNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveryNo.SelectedText = "";
            this.txtDeliveryNo.Size = new System.Drawing.Size(218, 29);
            this.txtDeliveryNo.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDeliveryNo.TabIndex = 12;
            this.txtDeliveryNo.UseCustomBackColor = true;
            this.txtDeliveryNo.UseSelectable = true;
            this.txtDeliveryNo.TextChanged += new System.EventHandler(this.txtDeliveryNo_TextChanged);
            this.txtDeliveryNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtDeliveryNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtDeliveryNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "";
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(11, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 19);
            this.metroLabel3.TabIndex = 116;
            this.metroLabel3.Text = "Delivery Receipt No.   :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pbAddSupplier
            // 
            this.pbAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.pbAddSupplier.BackgroundImage = global::PUPiMed.Properties.Resources.adad;
            this.pbAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddSupplier.Location = new System.Drawing.Point(200, 298);
            this.pbAddSupplier.Name = "pbAddSupplier";
            this.pbAddSupplier.Size = new System.Drawing.Size(29, 29);
            this.pbAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSupplier.TabIndex = 106;
            this.pbAddSupplier.TabStop = false;
            this.pbAddSupplier.Click += new System.EventHandler(this.pbAddSupplier_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCansel.BackColor = System.Drawing.Color.Transparent;
            this.btnCansel.BackgroundImage = global::PUPiMed.Properties.Resources.cancel;
            this.btnCansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCansel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCansel.FlatAppearance.BorderSize = 0;
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCansel.Location = new System.Drawing.Point(130, 424);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(98, 37);
            this.btnCansel.TabIndex = 188;
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSeyb
            // 
            this.btnSeyb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeyb.BackColor = System.Drawing.Color.Transparent;
            this.btnSeyb.BackgroundImage = global::PUPiMed.Properties.Resources.save2;
            this.btnSeyb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeyb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeyb.FlatAppearance.BorderSize = 0;
            this.btnSeyb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeyb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeyb.Location = new System.Drawing.Point(12, 424);
            this.btnSeyb.Name = "btnSeyb";
            this.btnSeyb.Size = new System.Drawing.Size(99, 37);
            this.btnSeyb.TabIndex = 187;
            this.btnSeyb.UseVisualStyleBackColor = false;
            this.btnSeyb.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbType.DisplayFocus = true;
            this.cbType.DisplayMember = "Medicine";
            this.cbType.DropDownHeight = 200;
            this.cbType.FormattingEnabled = true;
            this.cbType.IntegralHeight = false;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbType.Location = new System.Drawing.Point(16, 64);
            this.cbType.MaxDropDownItems = 10;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(176, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbType.TabIndex = 1;
            this.cbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbType.UseCustomBackColor = true;
            this.cbType.UseCustomForeColor = true;
            this.cbType.UseSelectable = true;
            this.cbType.UseStyleColors = true;
            this.cbType.ValueMember = "Medicine";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            this.cbType.Click += new System.EventHandler(this.cbType_Click);
            // 
            // cbName
            // 
            this.cbName.BackColor = System.Drawing.Color.White;
            this.cbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbName.DisplayFocus = true;
            this.cbName.DropDownHeight = 200;
            this.cbName.DropDownWidth = 300;
            this.cbName.FormattingEnabled = true;
            this.cbName.IntegralHeight = false;
            this.cbName.ItemHeight = 23;
            this.cbName.Location = new System.Drawing.Point(16, 135);
            this.cbName.Name = "cbName";
            this.cbName.PromptText = "Select Item";
            this.cbName.Size = new System.Drawing.Size(141, 29);
            this.cbName.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbName.TabIndex = 2;
            this.cbName.UseCustomBackColor = true;
            this.cbName.UseCustomForeColor = true;
            this.cbName.UseSelectable = true;
            this.cbName.UseStyleColors = true;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            this.cbName.Click += new System.EventHandler(this.cbType_Click);
            // 
            // dtExp
            // 
            this.dtExp.AllowDrop = true;
            this.dtExp.Checked = false;
            this.dtExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtExp.DisplayFocus = true;
            this.dtExp.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExp.Location = new System.Drawing.Point(16, 356);
            this.dtExp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtExp.Name = "dtExp";
            this.dtExp.Size = new System.Drawing.Size(176, 29);
            this.dtExp.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtExp.TabIndex = 5;
            this.dtExp.UseStyleColors = true;
            this.dtExp.ValueChanged += new System.EventHandler(this.dtExp_ValueChanged);
            this.dtExp.DropDown += new System.EventHandler(this.dtReceived_DropDown);
            this.dtExp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.dtExp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.dtExp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "";
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(16, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(176, 26);
            this.metroLabel5.TabIndex = 130;
            this.metroLabel5.Text = "Item Type   :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "";
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(16, 186);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(176, 26);
            this.metroLabel4.TabIndex = 116;
            this.metroLabel4.Text = "Batch Code    :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(16, 101);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(176, 26);
            this.metroLabel7.TabIndex = 132;
            this.metroLabel7.Text = "Item Name   :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "";
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(16, 254);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(176, 26);
            this.metroLabel8.TabIndex = 133;
            this.metroLabel8.Text = "Quantity :";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "";
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(16, 220);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(176, 26);
            this.txtCode.TabIndex = 3;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.EnabledChanged += new System.EventHandler(this.txtCode_EnabledChanged);
            this.txtCode.TextChanged += new System.EventHandler(this.txtDeliveryNo_TextChanged);
            this.txtCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleName = "btnadd";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.Highlight = true;
            this.btnEdit.Location = new System.Drawing.Point(414, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 29);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "btnadd";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Highlight = true;
            this.btnDelete.Location = new System.Drawing.Point(494, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "";
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(16, 322);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(176, 26);
            this.metroLabel10.TabIndex = 135;
            this.metroLabel10.Text = "Expiration Date  :";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(334, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.listDetail);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.dtExp);
            this.groupBox2.Controls.Add(this.pbAddItem);
            this.groupBox2.Controls.Add(this.cbName);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 478);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Information";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(16, 288);
            this.txtQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(176, 26);
            this.txtQty.TabIndex = 4;
            // 
            // listDetail
            // 
            this.listDetail.AllowUserToAddRows = false;
            this.listDetail.AllowUserToDeleteRows = false;
            this.listDetail.AllowUserToResizeRows = false;
            this.listDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cType,
            this.cName,
            this.cBatch,
            this.cQty,
            this.cExp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.listDetail.EnableHeadersVisualStyles = false;
            this.listDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listDetail.Location = new System.Drawing.Point(210, 33);
            this.listDetail.MultiSelect = false;
            this.listDetail.Name = "listDetail";
            this.listDetail.ReadOnly = true;
            this.listDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listDetail.RowHeadersVisible = false;
            this.listDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDetail.ShowCellErrors = false;
            this.listDetail.ShowCellToolTips = false;
            this.listDetail.ShowEditingIcon = false;
            this.listDetail.ShowRowErrors = false;
            this.listDetail.Size = new System.Drawing.Size(518, 379);
            this.listDetail.StandardTab = true;
            this.listDetail.Style = MetroFramework.MetroColorStyle.Teal;
            this.listDetail.TabIndex = 139;
            this.listDetail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listDetail.UseStyleColors = true;
            this.listDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.listDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.listDetail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cType
            // 
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cBatch
            // 
            this.cBatch.HeaderText = "Batch Code";
            this.cBatch.Name = "cBatch";
            this.cBatch.ReadOnly = true;
            // 
            // cQty
            // 
            this.cQty.HeaderText = "Quantity";
            this.cQty.Name = "cQty";
            this.cQty.ReadOnly = true;
            // 
            // cExp
            // 
            this.cExp.HeaderText = "Exp Date";
            this.cExp.Name = "cExp";
            this.cExp.ReadOnly = true;
            // 
            // pbAddItem
            // 
            this.pbAddItem.BackColor = System.Drawing.Color.Transparent;
            this.pbAddItem.BackgroundImage = global::PUPiMed.Properties.Resources.adad;
            this.pbAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddItem.Location = new System.Drawing.Point(163, 135);
            this.pbAddItem.Name = "pbAddItem";
            this.pbAddItem.Size = new System.Drawing.Size(29, 29);
            this.pbAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddItem.TabIndex = 113;
            this.pbAddItem.TabStop = false;
            this.pbAddItem.Click += new System.EventHandler(this.pbAddItem_Click);
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(0, 83);
            this.status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1047, 29);
            this.status.TabIndex = 138;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // FormReceiveInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 610);
            this.ControlBox = false;
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReceiveInventory";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.FormReceiveInventory_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dtReceived;
        private MetroFramework.Controls.MetroComboBox cbSupplier;
        private System.Windows.Forms.PictureBox pbAddSupplier;
        public MetroFramework.Controls.MetroTextBox txtRCode;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroTextBox txtDeliveryNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroComboBox cbName;
        private System.Windows.Forms.PictureBox pbAddItem;
        private MetroFramework.Controls.MetroDateTime dtExp;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile status;
        private MetroFramework.Controls.MetroGrid listDetail;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSeyb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExp;
        private System.Windows.Forms.NumericUpDown txtQty;
    }
}