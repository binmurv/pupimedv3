namespace PUPiMed
{
    partial class FormAdvanceSearch
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbltype = new MetroFramework.Controls.MetroLabel();
            this.lblManu1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.dtExp = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.txtMax = new System.Windows.Forms.NumericUpDown();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDeliveryNo = new MetroFramework.Controls.MetroTextBox();
            this.txtRCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtItemCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cbManufacturer = new MetroFramework.Controls.MetroComboBox();
            this.cbGenericName = new MetroFramework.Controls.MetroComboBox();
            this.cbItemName = new MetroFramework.Controls.MetroComboBox();
            this.cbSupplier = new MetroFramework.Controls.MetroComboBox();
            this.txtDosage = new MetroFramework.Controls.MetroTextBox();
            this.cbFormulation = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "";
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(62, 129);
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
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbType.Location = new System.Drawing.Point(230, 129);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(176, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbType.TabIndex = 131;
            this.cbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbType.UseCustomBackColor = true;
            this.cbType.UseCustomForeColor = true;
            this.cbType.UseSelectable = true;
            this.cbType.UseStyleColors = true;
            this.cbType.ValueMember = "Medicine";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(450, 83);
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
            this.lbltype.Location = new System.Drawing.Point(450, 129);
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
            this.lblManu1.Location = new System.Drawing.Point(62, 177);
            this.lblManu1.Name = "lblManu1";
            this.lblManu1.Size = new System.Drawing.Size(112, 29);
            this.lblManu1.TabIndex = 138;
            this.lblManu1.Text = "Manufacturer :";
            this.lblManu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManu1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "";
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(450, 177);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 29);
            this.metroLabel2.TabIndex = 139;
            this.metroLabel2.Text = "Supplier :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "";
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(450, 374);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(143, 29);
            this.metroLabel10.TabIndex = 142;
            this.metroLabel10.Text = "Expiration Date :";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // dtExp
            // 
            this.dtExp.AllowDrop = true;
            this.dtExp.Checked = false;
            this.dtExp.DisplayFocus = true;
            this.dtExp.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExp.Location = new System.Drawing.Point(230, 374);
            this.dtExp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtExp.Name = "dtExp";
            this.dtExp.Size = new System.Drawing.Size(176, 29);
            this.dtExp.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtExp.TabIndex = 141;
            this.dtExp.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "";
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(62, 374);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 29);
            this.metroLabel1.TabIndex = 143;
            this.metroLabel1.Text = "Date Received :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.AllowDrop = true;
            this.metroDateTime1.Checked = false;
            this.metroDateTime1.DisplayFocus = true;
            this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(645, 374);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(176, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroDateTime1.TabIndex = 144;
            this.metroDateTime1.UseStyleColors = true;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(645, 278);
            this.txtMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(176, 22);
            this.txtMax.TabIndex = 146;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(230, 278);
            this.txtMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(176, 22);
            this.txtMin.TabIndex = 145;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "";
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(450, 281);
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
            this.metroLabel4.Location = new System.Drawing.Point(62, 278);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 22);
            this.metroLabel4.TabIndex = 147;
            this.metroLabel4.Text = "Minimum :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.AccessibleName = "";
            this.txtDeliveryNo.BackColor = System.Drawing.Color.White;
            this.txtDeliveryNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDeliveryNo.Lines = new string[0];
            this.txtDeliveryNo.Location = new System.Drawing.Point(645, 322);
            this.txtDeliveryNo.MaxLength = 32767;
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.PasswordChar = '\0';
            this.txtDeliveryNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveryNo.SelectedText = "";
            this.txtDeliveryNo.Size = new System.Drawing.Size(176, 29);
            this.txtDeliveryNo.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDeliveryNo.TabIndex = 150;
            this.txtDeliveryNo.UseCustomBackColor = true;
            this.txtDeliveryNo.UseSelectable = true;
            // 
            // txtRCode
            // 
            this.txtRCode.AccessibleName = "";
            this.txtRCode.BackColor = System.Drawing.Color.White;
            this.txtRCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRCode.Lines = new string[0];
            this.txtRCode.Location = new System.Drawing.Point(230, 322);
            this.txtRCode.MaxLength = 32767;
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.PasswordChar = '\0';
            this.txtRCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRCode.SelectedText = "";
            this.txtRCode.Size = new System.Drawing.Size(176, 29);
            this.txtRCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtRCode.TabIndex = 149;
            this.txtRCode.UseCustomBackColor = true;
            this.txtRCode.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "";
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(450, 322);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(146, 29);
            this.metroLabel6.TabIndex = 151;
            this.metroLabel6.Text = "Delivery Receipt No. :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(62, 322);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 29);
            this.lblCode.TabIndex = 152;
            this.lblCode.Text = "Receiving Code :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCode.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "";
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(450, 227);
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
            this.metroLabel9.Location = new System.Drawing.Point(62, 227);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 29);
            this.metroLabel9.TabIndex = 160;
            this.metroLabel9.Text = "Form : ";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemCode
            // 
            this.txtItemCode.AccessibleName = "";
            this.txtItemCode.BackColor = System.Drawing.Color.White;
            this.txtItemCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtItemCode.Lines = new string[0];
            this.txtItemCode.Location = new System.Drawing.Point(230, 83);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.Size = new System.Drawing.Size(176, 29);
            this.txtItemCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtItemCode.TabIndex = 162;
            this.txtItemCode.UseCustomBackColor = true;
            this.txtItemCode.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AccessibleName = "";
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(62, 83);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(109, 29);
            this.metroLabel11.TabIndex = 161;
            this.metroLabel11.Text = "Item Code : ";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.BackColor = System.Drawing.Color.White;
            this.cbManufacturer.DisplayFocus = true;
            this.cbManufacturer.DisplayMember = "Medicine";
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.ItemHeight = 23;
            this.cbManufacturer.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbManufacturer.Location = new System.Drawing.Point(230, 177);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(176, 29);
            this.cbManufacturer.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer.TabIndex = 163;
            this.cbManufacturer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbManufacturer.UseCustomBackColor = true;
            this.cbManufacturer.UseCustomForeColor = true;
            this.cbManufacturer.UseSelectable = true;
            this.cbManufacturer.UseStyleColors = true;
            this.cbManufacturer.ValueMember = "Medicine";
            // 
            // cbGenericName
            // 
            this.cbGenericName.BackColor = System.Drawing.Color.White;
            this.cbGenericName.DisplayFocus = true;
            this.cbGenericName.DisplayMember = "Medicine";
            this.cbGenericName.FormattingEnabled = true;
            this.cbGenericName.ItemHeight = 23;
            this.cbGenericName.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbGenericName.Location = new System.Drawing.Point(645, 129);
            this.cbGenericName.Name = "cbGenericName";
            this.cbGenericName.Size = new System.Drawing.Size(176, 29);
            this.cbGenericName.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbGenericName.TabIndex = 164;
            this.cbGenericName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbGenericName.UseCustomBackColor = true;
            this.cbGenericName.UseCustomForeColor = true;
            this.cbGenericName.UseSelectable = true;
            this.cbGenericName.UseStyleColors = true;
            this.cbGenericName.ValueMember = "Medicine";
            // 
            // cbItemName
            // 
            this.cbItemName.BackColor = System.Drawing.Color.White;
            this.cbItemName.DisplayFocus = true;
            this.cbItemName.DisplayMember = "Medicine";
            this.cbItemName.FormattingEnabled = true;
            this.cbItemName.ItemHeight = 23;
            this.cbItemName.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbItemName.Location = new System.Drawing.Point(645, 83);
            this.cbItemName.Name = "cbItemName";
            this.cbItemName.Size = new System.Drawing.Size(176, 29);
            this.cbItemName.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbItemName.TabIndex = 165;
            this.cbItemName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbItemName.UseCustomBackColor = true;
            this.cbItemName.UseCustomForeColor = true;
            this.cbItemName.UseSelectable = true;
            this.cbItemName.UseStyleColors = true;
            this.cbItemName.ValueMember = "Medicine";
            // 
            // cbSupplier
            // 
            this.cbSupplier.BackColor = System.Drawing.Color.White;
            this.cbSupplier.DisplayFocus = true;
            this.cbSupplier.DisplayMember = "Medicine";
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.ItemHeight = 23;
            this.cbSupplier.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbSupplier.Location = new System.Drawing.Point(645, 177);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(176, 29);
            this.cbSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbSupplier.TabIndex = 166;
            this.cbSupplier.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbSupplier.UseCustomBackColor = true;
            this.cbSupplier.UseCustomForeColor = true;
            this.cbSupplier.UseSelectable = true;
            this.cbSupplier.UseStyleColors = true;
            this.cbSupplier.ValueMember = "Medicine";
            // 
            // txtDosage
            // 
            this.txtDosage.AccessibleName = "";
            this.txtDosage.BackColor = System.Drawing.Color.White;
            this.txtDosage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDosage.Lines = new string[0];
            this.txtDosage.Location = new System.Drawing.Point(645, 227);
            this.txtDosage.MaxLength = 32767;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDosage.SelectedText = "";
            this.txtDosage.Size = new System.Drawing.Size(176, 29);
            this.txtDosage.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDosage.TabIndex = 167;
            this.txtDosage.UseCustomBackColor = true;
            this.txtDosage.UseSelectable = true;
            // 
            // cbFormulation
            // 
            this.cbFormulation.BackColor = System.Drawing.Color.White;
            this.cbFormulation.DisplayFocus = true;
            this.cbFormulation.DisplayMember = "Medicine";
            this.cbFormulation.FormattingEnabled = true;
            this.cbFormulation.ItemHeight = 23;
            this.cbFormulation.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbFormulation.Location = new System.Drawing.Point(230, 227);
            this.cbFormulation.Name = "cbFormulation";
            this.cbFormulation.Size = new System.Drawing.Size(176, 29);
            this.cbFormulation.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbFormulation.TabIndex = 168;
            this.cbFormulation.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbFormulation.UseCustomBackColor = true;
            this.cbFormulation.UseCustomForeColor = true;
            this.cbFormulation.UseSelectable = true;
            this.cbFormulation.UseStyleColors = true;
            this.cbFormulation.ValueMember = "Medicine";
            // 
            // FormAdvanceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 452);
            this.Controls.Add(this.cbFormulation);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbItemName);
            this.Controls.Add(this.cbGenericName);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtDeliveryNo);
            this.Controls.Add(this.txtRCode);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.dtExp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblManu1);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbType);
            this.Name = "FormAdvanceSearch";
            this.Text = "Advanced Search Option";
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lbltype;
        private MetroFramework.Controls.MetroLabel lblManu1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime dtExp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        public System.Windows.Forms.NumericUpDown txtMax;
        public System.Windows.Forms.NumericUpDown txtMin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTextBox txtDeliveryNo;
        public MetroFramework.Controls.MetroTextBox txtRCode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroTextBox txtItemCode;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cbManufacturer;
        private MetroFramework.Controls.MetroComboBox cbGenericName;
        private MetroFramework.Controls.MetroComboBox cbItemName;
        private MetroFramework.Controls.MetroComboBox cbSupplier;
        public MetroFramework.Controls.MetroTextBox txtDosage;
        private MetroFramework.Controls.MetroComboBox cbFormulation;
    }
}