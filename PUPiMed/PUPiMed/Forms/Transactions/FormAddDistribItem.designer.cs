namespace PUPiMed
{
    partial class FormAddDistribItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDistribItem));
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.cbName = new MetroFramework.Controls.MetroComboBox();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.title = new System.Windows.Forms.Label();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.status = new MetroFramework.Controls.MetroTile();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbBranch = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBranch = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDCode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBalance = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroLabel();
            this.txtAvailable = new MetroFramework.Controls.MetroLabel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "fname";
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCode.Enabled = false;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(139, 112);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(186, 26);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 0;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtQty
            // 
            this.txtQty.AccessibleName = "fname";
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQty.Lines = new string[] {
        "0"};
            this.txtQty.Location = new System.Drawing.Point(139, 152);
            this.txtQty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtQty.MaxLength = 6;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(186, 26);
            this.txtQty.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtQty.TabIndex = 7;
            this.txtQty.Text = "0";
            this.txtQty.UseCustomBackColor = true;
            this.txtQty.UseSelectable = true;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtQty.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtQty.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cbName
            // 
            this.cbName.BackColor = System.Drawing.Color.White;
            this.cbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbName.DropDownHeight = 200;
            this.cbName.FormattingEnabled = true;
            this.cbName.IntegralHeight = false;
            this.cbName.ItemHeight = 23;
            this.cbName.Location = new System.Drawing.Point(139, 69);
            this.cbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cbName.MaxDropDownItems = 10;
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(184, 29);
            this.cbName.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbName.TabIndex = 5;
            this.cbName.UseCustomBackColor = true;
            this.cbName.UseSelectable = true;
            this.cbName.UseStyleColors = true;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            this.cbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.cbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.cbName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbType.DisplayMember = "0";
            this.cbType.DropDownHeight = 200;
            this.cbType.FormattingEnabled = true;
            this.cbType.IntegralHeight = false;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbType.Location = new System.Drawing.Point(139, 26);
            this.cbType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cbType.MaxDropDownItems = 10;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(184, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbType.TabIndex = 4;
            this.cbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbType.UseCustomBackColor = true;
            this.cbType.UseSelectable = true;
            this.cbType.UseStyleColors = true;
            this.cbType.ValueMember = "Medicine";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            this.cbType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.cbType.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.cbType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.title.Location = new System.Drawing.Point(288, 10);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(360, 58);
            this.title.TabIndex = 107;
            this.title.Text = "ADD ITEM TO DISTRIBUTE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // dtDate
            // 
            this.dtDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(671, 164);
            this.dtDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(186, 29);
            this.dtDate.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtDate.TabIndex = 8;
            this.dtDate.UseStyleColors = true;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            this.dtDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.dtDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.dtDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(0, 72);
            this.status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(903, 29);
            this.status.TabIndex = 101;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            this.status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.status.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.status.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(25, 35);
            this.lblCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(84, 20);
            this.lblCode.TabIndex = 117;
            this.lblCode.Text = "Item Type :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCode.UseCustomBackColor = true;
            this.lblCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.lblCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.lblCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "";
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(25, 75);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 20);
            this.metroLabel8.TabIndex = 129;
            this.metroLabel8.Text = "Item Name :";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AccessibleName = "";
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(25, 115);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(84, 20);
            this.metroLabel11.TabIndex = 130;
            this.metroLabel11.Text = "Item Code :";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "";
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 204);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 131;
            this.metroLabel1.Text = "Available :";
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
            this.metroLabel2.Location = new System.Drawing.Point(25, 155);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 20);
            this.metroLabel2.TabIndex = 132;
            this.metroLabel2.Text = "Quantity :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "";
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(532, 173);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 20);
            this.metroLabel5.TabIndex = 134;
            this.metroLabel5.Text = "Date :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "";
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(25, 244);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 20);
            this.metroLabel6.TabIndex = 135;
            this.metroLabel6.Text = "Total :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(25, 284);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 20);
            this.metroLabel7.TabIndex = 136;
            this.metroLabel7.Text = "Balance :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cbBranch
            // 
            this.cbBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbBranch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBranch.CheckOnClick = true;
            this.cbBranch.ColumnWidth = 180;
            this.cbBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBranch.ForeColor = System.Drawing.Color.Black;
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(19, 35);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(453, 352);
            this.cbBranch.TabIndex = 0;
            this.cbBranch.ThreeDCheckBoxes = true;
            this.cbBranch.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbBranch_ItemCheck);
            this.cbBranch.Click += new System.EventHandler(this.materialCheckBox5_CheckStateChanged);
            this.cbBranch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbBranch_MouseClick_1);
            this.cbBranch.Enter += new System.EventHandler(this.cbBranch_Enter);
            this.cbBranch.Leave += new System.EventHandler(this.cbBranch_ItemCheck);
            this.cbBranch.MouseEnter += new System.EventHandler(this.cbBranch_MouseEnter);
            this.cbBranch.MouseLeave += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBranch);
            this.groupBox1.Controls.Add(this.btnAddBranch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branches / Campuses";
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.AccessibleName = "btnadd";
            this.btnAddBranch.CausesValidation = false;
            this.btnAddBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBranch.Highlight = true;
            this.btnAddBranch.Location = new System.Drawing.Point(309, 404);
            this.btnAddBranch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(163, 39);
            this.btnAddBranch.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAddBranch.TabIndex = 2;
            this.btnAddBranch.Text = "Add New Branch";
            this.btnAddBranch.UseCustomBackColor = true;
            this.btnAddBranch.UseSelectable = true;
            this.btnAddBranch.UseStyleColors = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "";
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(532, 126);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 26);
            this.metroLabel3.TabIndex = 144;
            this.metroLabel3.Text = "Distribution Code :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            this.metroLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.metroLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.metroLabel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtDCode
            // 
            this.txtDCode.AccessibleName = "fname";
            this.txtDCode.BackColor = System.Drawing.Color.White;
            this.txtDCode.Enabled = false;
            this.txtDCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDCode.Lines = new string[0];
            this.txtDCode.Location = new System.Drawing.Point(671, 126);
            this.txtDCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtDCode.MaxLength = 15;
            this.txtDCode.Name = "txtDCode";
            this.txtDCode.PasswordChar = '\0';
            this.txtDCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDCode.SelectedText = "";
            this.txtDCode.Size = new System.Drawing.Size(184, 26);
            this.txtDCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDCode.TabIndex = 1;
            this.txtDCode.UseCustomBackColor = true;
            this.txtDCode.UseSelectable = true;
            this.txtDCode.Click += new System.EventHandler(this.txtDCode_Click);
            this.txtDCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtDCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtDCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtAvailable);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.lblCode);
            this.groupBox2.Controls.Add(this.cbName);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(532, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtBalance
            // 
            this.txtBalance.AccessibleName = "";
            this.txtBalance.BackColor = System.Drawing.Color.Transparent;
            this.txtBalance.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtBalance.Location = new System.Drawing.Point(139, 284);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(184, 20);
            this.txtBalance.TabIndex = 137;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBalance.UseCustomBackColor = true;
            this.txtBalance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtBalance.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtBalance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtTotal
            // 
            this.txtTotal.AccessibleName = "";
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtTotal.Location = new System.Drawing.Point(139, 244);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(184, 20);
            this.txtTotal.TabIndex = 137;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTotal.UseCustomBackColor = true;
            this.txtTotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtTotal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtTotal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtAvailable
            // 
            this.txtAvailable.AccessibleName = "";
            this.txtAvailable.BackColor = System.Drawing.Color.Transparent;
            this.txtAvailable.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtAvailable.Location = new System.Drawing.Point(139, 204);
            this.txtAvailable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(184, 20);
            this.txtAvailable.TabIndex = 137;
            this.txtAvailable.Text = "0";
            this.txtAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAvailable.UseCustomBackColor = true;
            this.txtAvailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.txtAvailable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.txtAvailable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::PUPiMed.Properties.Resources.truck_104px;
            this.pictureBox12.Location = new System.Drawing.Point(199, 5);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(85, 72);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 85;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PUPiMed.Properties.Resources.cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(730, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 192;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PUPiMed.Properties.Resources.save2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(592, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 191;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddDistribItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 592);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDCode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MaximizeBox = false;
            this.Name = "FormAddDistribItem";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FormAddDistribItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private System.Windows.Forms.PictureBox pictureBox12;
        private MetroFramework.Controls.MetroComboBox cbName;
        private MetroFramework.Controls.MetroComboBox cbType;
        private System.Windows.Forms.Label title;
        private MetroFramework.Controls.MetroDateTime dtDate;
        private MetroFramework.Controls.MetroTile status;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.CheckedListBox cbBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnAddBranch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel txtBalance;
        private MetroFramework.Controls.MetroLabel txtTotal;
        private MetroFramework.Controls.MetroLabel txtAvailable;
    }
}