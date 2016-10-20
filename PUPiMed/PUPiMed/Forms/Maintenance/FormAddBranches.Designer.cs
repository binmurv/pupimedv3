namespace PUPiMed.Forms
{
    partial class FormAddBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBranches));
            this.title = new System.Windows.Forms.Label();
            this.status = new MetroFramework.Controls.MetroTile();
            this.suppcode = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.branch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTown = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtStreet = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSeyb = new System.Windows.Forms.Button();
            this.branch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(234, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(146, 59);
            this.title.TabIndex = 146;
            this.title.Text = "BRANCH";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-2, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(632, 29);
            this.status.TabIndex = 148;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // suppcode
            // 
            this.suppcode.AccessibleName = "suppcode";
            this.suppcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.suppcode.AutoSize = true;
            this.suppcode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.suppcode.Location = new System.Drawing.Point(57, 296);
            this.suppcode.Name = "suppcode";
            this.suppcode.Size = new System.Drawing.Size(94, 19);
            this.suppcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.suppcode.TabIndex = 152;
            this.suppcode.Text = "Branch Code :";
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "Eqcode";
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(23, 326);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(167, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 1;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // branch
            // 
            this.branch.Controls.Add(this.groupBox1);
            this.branch.Controls.Add(this.txtName);
            this.branch.Controls.Add(this.metroLabel1);
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Location = new System.Drawing.Point(211, 114);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(385, 240);
            this.branch.TabIndex = 2;
            this.branch.TabStop = false;
            this.branch.Text = "Branch\'s Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtTown);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtNo
            // 
            this.txtNo.AccessibleName = "";
            this.txtNo.BackColor = System.Drawing.Color.White;
            this.txtNo.Lines = new string[0];
            this.txtNo.Location = new System.Drawing.Point(131, 34);
            this.txtNo.MaxLength = 50;
            this.txtNo.Name = "txtNo";
            this.txtNo.PasswordChar = '\0';
            this.txtNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNo.SelectedText = "";
            this.txtNo.Size = new System.Drawing.Size(51, 23);
            this.txtNo.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNo.TabIndex = 3;
            this.txtNo.UseCustomBackColor = true;
            this.txtNo.UseSelectable = true;
            this.txtNo.UseStyleColors = true;
            this.txtNo.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "lbltype";
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(17, 34);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 140;
            this.metroLabel5.Text = "Building # :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtTown
            // 
            this.txtTown.AccessibleName = "";
            this.txtTown.BackColor = System.Drawing.Color.White;
            this.txtTown.Lines = new string[0];
            this.txtTown.Location = new System.Drawing.Point(131, 74);
            this.txtTown.MaxLength = 50;
            this.txtTown.Name = "txtTown";
            this.txtTown.PasswordChar = '\0';
            this.txtTown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTown.SelectedText = "";
            this.txtTown.Size = new System.Drawing.Size(215, 23);
            this.txtTown.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtTown.TabIndex = 5;
            this.txtTown.UseCustomBackColor = true;
            this.txtTown.UseSelectable = true;
            this.txtTown.UseStyleColors = true;
            this.txtTown.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // txtCity
            // 
            this.txtCity.AccessibleName = "";
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(131, 114);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.Size = new System.Drawing.Size(215, 23);
            this.txtCity.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCity.TabIndex = 6;
            this.txtCity.UseCustomBackColor = true;
            this.txtCity.UseSelectable = true;
            this.txtCity.UseStyleColors = true;
            this.txtCity.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "lbltype";
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(17, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 137;
            this.metroLabel4.Text = "*City/Province :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "lbltype";
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(17, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 136;
            this.metroLabel3.Text = "*Town/Brgy :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "lbltype";
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(188, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Street :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtStreet
            // 
            this.txtStreet.AccessibleName = "";
            this.txtStreet.BackColor = System.Drawing.Color.White;
            this.txtStreet.Lines = new string[0];
            this.txtStreet.Location = new System.Drawing.Point(254, 34);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.PasswordChar = '\0';
            this.txtStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStreet.SelectedText = "";
            this.txtStreet.Size = new System.Drawing.Size(92, 23);
            this.txtStreet.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtStreet.TabIndex = 4;
            this.txtStreet.UseCustomBackColor = true;
            this.txtStreet.UseSelectable = true;
            this.txtStreet.UseStyleColors = true;
            this.txtStreet.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(144, 35);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(214, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName.TabIndex = 2;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "lblmed";
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(29, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 124;
            this.metroLabel1.Text = "*Name :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "suppcode";
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel7.Location = new System.Drawing.Point(11, 395);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(162, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel7.TabIndex = 161;
            this.metroLabel7.Text = "* indicates required fields";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox12.Image = global::PUPiMed.Properties.Resources.branchesds__3_;
            this.pictureBox12.Location = new System.Drawing.Point(23, 121);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(167, 163);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 149;
            this.pictureBox12.TabStop = false;
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
            this.btnCansel.Location = new System.Drawing.Point(501, 368);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(98, 37);
            this.btnCansel.TabIndex = 190;
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSeyb.Location = new System.Drawing.Point(383, 368);
            this.btnSeyb.Name = "btnSeyb";
            this.btnSeyb.Size = new System.Drawing.Size(99, 37);
            this.btnSeyb.TabIndex = 189;
            this.btnSeyb.UseVisualStyleBackColor = false;
            this.btnSeyb.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSeyb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.suppcode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.status);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddBranches";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.branch.ResumeLayout(false);
            this.branch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox txtCode;
        public MetroFramework.Controls.MetroTextBox txtNo;
        public MetroFramework.Controls.MetroTextBox txtTown;
        public MetroFramework.Controls.MetroTextBox txtCity;
        public MetroFramework.Controls.MetroTextBox txtStreet;
        public MetroFramework.Controls.MetroTextBox txtName;
        public System.Windows.Forms.Label title;
        public MetroFramework.Controls.MetroTile status;
        public System.Windows.Forms.PictureBox pictureBox12;
        public MetroFramework.Controls.MetroLabel suppcode;
        public System.Windows.Forms.GroupBox branch;
        public System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSeyb;
    }
}