namespace PUPiMed
{
    partial class FormItemSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemSearch));
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbltype = new MetroFramework.Controls.MetroLabel();
            this.lblManu1 = new MetroFramework.Controls.MetroLabel();
            this.txtMax = new System.Windows.Forms.NumericUpDown();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Title = new System.Windows.Forms.Label();
            this.status = new MetroFramework.Controls.MetroTile();
            this.txtDosage = new MetroFramework.Controls.MetroTextBox();
            this.txtGen = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.cbManufacturer = new MetroFramework.Controls.MetroComboBox();
            this.cbForm = new MetroFramework.Controls.MetroComboBox();
            this.chkMax = new MetroFramework.Controls.MetroCheckBox();
            this.chkMin = new MetroFramework.Controls.MetroCheckBox();
            this.chkManu = new MetroFramework.Controls.MetroCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "";
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(58, 185);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 29);
            this.metroLabel5.TabIndex = 132;
            this.metroLabel5.Text = "Item Type :";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DisplayFocus = true;
            this.cbType.DisplayMember = "Medicine";
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "",
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbType.Location = new System.Drawing.Point(226, 185);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(176, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbType.TabIndex = 3;
            this.cbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbType.UseCustomBackColor = true;
            this.cbType.UseCustomForeColor = true;
            this.cbType.UseSelectable = true;
            this.cbType.UseStyleColors = true;
            this.cbType.ValueMember = "Medicine";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            this.cbType.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(446, 135);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 29);
            this.metroLabel7.TabIndex = 133;
            this.metroLabel7.Text = "Item Name :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // lbltype
            // 
            this.lbltype.AccessibleName = "";
            this.lbltype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbltype.Location = new System.Drawing.Point(446, 202);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(109, 29);
            this.lbltype.TabIndex = 136;
            this.lbltype.Text = "Generic Name : ";
            this.lbltype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManu1
            // 
            this.lblManu1.AccessibleName = "";
            this.lblManu1.BackColor = System.Drawing.Color.Transparent;
            this.lblManu1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblManu1.Location = new System.Drawing.Point(58, 233);
            this.lblManu1.Name = "lblManu1";
            this.lblManu1.Size = new System.Drawing.Size(112, 29);
            this.lblManu1.TabIndex = 138;
            this.lblManu1.Text = "Manufacturer :";
            this.lblManu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManu1.UseCustomBackColor = true;
            // 
            // txtMax
            // 
            this.txtMax.Enabled = false;
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(226, 337);
            this.txtMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(156, 22);
            this.txtMax.TabIndex = 8;
            this.txtMax.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // txtMin
            // 
            this.txtMin.Enabled = false;
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(621, 337);
            this.txtMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(150, 22);
            this.txtMin.TabIndex = 9;
            this.txtMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMin.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "";
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(58, 337);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 148;
            this.metroLabel3.Text = "Maximum :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "";
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(446, 337);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 22);
            this.metroLabel4.TabIndex = 147;
            this.metroLabel4.Text = "Minimum :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "";
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(446, 269);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(89, 29);
            this.metroLabel8.TabIndex = 159;
            this.metroLabel8.Text = "Dosage : ";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AccessibleName = "";
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(58, 285);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 29);
            this.metroLabel9.TabIndex = 160;
            this.metroLabel9.Text = "Form : ";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "";
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(226, 135);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(176, 29);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 1;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AccessibleName = "";
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(58, 135);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(109, 29);
            this.metroLabel11.TabIndex = 161;
            this.metroLabel11.Text = "Item Code : ";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Teal;
            this.Title.Location = new System.Drawing.Point(-3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(859, 75);
            this.Title.TabIndex = 173;
            this.Title.Text = "ITEM SEARCH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-6, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(865, 29);
            this.status.TabIndex = 174;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // txtDosage
            // 
            this.txtDosage.AccessibleName = "";
            this.txtDosage.BackColor = System.Drawing.Color.White;
            this.txtDosage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDosage.Lines = new string[0];
            this.txtDosage.Location = new System.Drawing.Point(621, 269);
            this.txtDosage.MaxLength = 50;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDosage.SelectedText = "";
            this.txtDosage.Size = new System.Drawing.Size(176, 29);
            this.txtDosage.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDosage.TabIndex = 6;
            this.txtDosage.UseCustomBackColor = true;
            this.txtDosage.UseSelectable = true;
            this.txtDosage.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // txtGen
            // 
            this.txtGen.AccessibleName = "";
            this.txtGen.BackColor = System.Drawing.Color.White;
            this.txtGen.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtGen.Lines = new string[0];
            this.txtGen.Location = new System.Drawing.Point(621, 202);
            this.txtGen.MaxLength = 200;
            this.txtGen.Name = "txtGen";
            this.txtGen.PasswordChar = '\0';
            this.txtGen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGen.SelectedText = "";
            this.txtGen.Size = new System.Drawing.Size(176, 29);
            this.txtGen.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGen.TabIndex = 4;
            this.txtGen.UseCustomBackColor = true;
            this.txtGen.UseSelectable = true;
            this.txtGen.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(621, 135);
            this.txtName.MaxLength = 200;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(176, 29);
            this.txtName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName.TabIndex = 2;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbManufacturer.DisplayFocus = true;
            this.cbManufacturer.DisplayMember = "Medicine";
            this.cbManufacturer.Enabled = false;
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.ItemHeight = 23;
            this.cbManufacturer.Location = new System.Drawing.Point(226, 233);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(156, 29);
            this.cbManufacturer.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer.TabIndex = 5;
            this.cbManufacturer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbManufacturer.UseCustomBackColor = true;
            this.cbManufacturer.UseCustomForeColor = true;
            this.cbManufacturer.UseSelectable = true;
            this.cbManufacturer.UseStyleColors = true;
            this.cbManufacturer.ValueMember = "Medicine";
            this.cbManufacturer.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // cbForm
            // 
            this.cbForm.AccessibleName = "";
            this.cbForm.BackColor = System.Drawing.Color.Transparent;
            this.cbForm.DisplayFocus = true;
            this.cbForm.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbForm.ItemHeight = 19;
            this.cbForm.Items.AddRange(new object[] {
            "",
            "Tablet",
            "Capsule",
            "Syrup"});
            this.cbForm.Location = new System.Drawing.Point(226, 289);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(176, 25);
            this.cbForm.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbForm.TabIndex = 175;
            this.cbForm.UseCustomBackColor = true;
            this.cbForm.UseCustomForeColor = true;
            this.cbForm.UseSelectable = true;
            this.cbForm.UseStyleColors = true;
            this.cbForm.EnabledChanged += new System.EventHandler(this.metroLabel5_EnabledChanged);
            // 
            // chkMax
            // 
            this.chkMax.Location = new System.Drawing.Point(386, 336);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(20, 24);
            this.chkMax.TabIndex = 176;
            this.chkMax.UseSelectable = true;
            this.chkMax.CheckedChanged += new System.EventHandler(this.chkMax_CheckedChanged);
            // 
            // chkMin
            // 
            this.chkMin.Location = new System.Drawing.Point(777, 337);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(20, 24);
            this.chkMin.TabIndex = 176;
            this.chkMin.UseSelectable = true;
            this.chkMin.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
            // 
            // chkManu
            // 
            this.chkManu.Location = new System.Drawing.Point(388, 238);
            this.chkManu.Name = "chkManu";
            this.chkManu.Size = new System.Drawing.Size(20, 24);
            this.chkManu.TabIndex = 176;
            this.chkManu.UseSelectable = true;
            this.chkManu.CheckedChanged += new System.EventHandler(this.chkManu_CheckedChanged);
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
            this.button1.Location = new System.Drawing.Point(695, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 274;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PUPiMed.Properties.Resources.okay;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(557, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 273;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkMin);
            this.Controls.Add(this.chkManu);
            this.Controls.Add(this.chkMax);
            this.Controls.Add(this.cbForm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblManu1);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormItemSearch";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lbltype;
        private MetroFramework.Controls.MetroLabel lblManu1;
        public System.Windows.Forms.NumericUpDown txtMax;
        public System.Windows.Forms.NumericUpDown txtMin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroTile status;
        public MetroFramework.Controls.MetroTextBox txtDosage;
        public MetroFramework.Controls.MetroTextBox txtGen;
        public MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroComboBox cbManufacturer;
        public MetroFramework.Controls.MetroComboBox cbForm;
        private MetroFramework.Controls.MetroCheckBox chkMax;
        private MetroFramework.Controls.MetroCheckBox chkMin;
        private MetroFramework.Controls.MetroCheckBox chkManu;
        public MetroFramework.Controls.MetroComboBox cbType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}