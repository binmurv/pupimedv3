using System;

namespace PUPiMed
{
    partial class FormAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddItem));
            this.lblMax = new MetroFramework.Controls.MetroLabel();
            this.lblMin = new MetroFramework.Controls.MetroLabel();
            this.txtGen = new MetroFramework.Controls.MetroTextBox();
            this.lblGen = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.status = new MetroFramework.Controls.MetroTile();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.lblManu = new MetroFramework.Controls.MetroLabel();
            this.Title = new System.Windows.Forms.Label();
            this.medicine = new System.Windows.Forms.GroupBox();
            this.cbManufacturer = new MetroFramework.Controls.MetroComboBox();
            this.cbForm = new MetroFramework.Controls.MetroComboBox();
            this.lblForm = new MetroFramework.Controls.MetroLabel();
            this.pbAddSupplier = new System.Windows.Forms.PictureBox();
            this.lblDosage = new MetroFramework.Controls.MetroLabel();
            this.txtMax = new System.Windows.Forms.NumericUpDown();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.txtDosage = new MetroFramework.Controls.MetroTextBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.cbManufacturer_ = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMax_ = new System.Windows.Forms.NumericUpDown();
            this.txtMin_ = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtGeneric_ = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtName_ = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.equipment = new System.Windows.Forms.GroupBox();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSeyb = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.medicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin_)).BeginInit();
            this.equipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMax
            // 
            this.lblMax.AccessibleName = "";
            this.lblMax.AutoSize = true;
            this.lblMax.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMax.Location = new System.Drawing.Point(173, 197);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(83, 19);
            this.lblMax.TabIndex = 110;
            this.lblMax.Text = "*Maximum :";
            // 
            // lblMin
            // 
            this.lblMin.AccessibleName = "";
            this.lblMin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMin.Location = new System.Drawing.Point(11, 194);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(89, 25);
            this.lblMin.TabIndex = 109;
            this.lblMin.Text = "*Minimum :";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGen
            // 
            this.txtGen.AccessibleName = "";
            this.txtGen.BackColor = System.Drawing.Color.White;
            this.txtGen.Lines = new string[0];
            this.txtGen.Location = new System.Drawing.Point(120, 68);
            this.txtGen.MaxLength = 200;
            this.txtGen.Name = "txtGen";
            this.txtGen.PasswordChar = '\0';
            this.txtGen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGen.SelectedText = "";
            this.txtGen.Size = new System.Drawing.Size(216, 23);
            this.txtGen.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGen.TabIndex = 4;
            this.txtGen.UseCustomBackColor = true;
            this.txtGen.UseSelectable = true;
            this.txtGen.UseStyleColors = true;
            this.txtGen.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtGen.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtGen.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblGen
            // 
            this.lblGen.AccessibleName = "";
            this.lblGen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblGen.Location = new System.Drawing.Point(11, 72);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(116, 19);
            this.lblGen.TabIndex = 107;
            this.lblGen.Text = "*Generic Name : ";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(120, 27);
            this.txtName.MaxLength = 200;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(216, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName.TabIndex = 3;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtName.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "";
            this.lblName.AutoSize = true;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(11, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 106;
            this.lblName.Text = "*Name :";
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-6, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(594, 29);
            this.status.TabIndex = 100;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "";
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(30, 313);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(143, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 1;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(30, 288);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 19);
            this.lblCode.TabIndex = 94;
            this.lblCode.Text = "Medicine Code :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManu
            // 
            this.lblManu.AccessibleName = "";
            this.lblManu.BackColor = System.Drawing.Color.Transparent;
            this.lblManu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblManu.Location = new System.Drawing.Point(11, 153);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(116, 25);
            this.lblManu.TabIndex = 113;
            this.lblManu.Text = "*Manufacturer :";
            this.lblManu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManu.UseCustomBackColor = true;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Title.Location = new System.Drawing.Point(-3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(577, 75);
            this.Title.TabIndex = 115;
            this.Title.Text = "MEDICINE";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicine
            // 
            this.medicine.Controls.Add(this.cbManufacturer);
            this.medicine.Controls.Add(this.cbForm);
            this.medicine.Controls.Add(this.lblForm);
            this.medicine.Controls.Add(this.pbAddSupplier);
            this.medicine.Controls.Add(this.lblDosage);
            this.medicine.Controls.Add(this.txtMax);
            this.medicine.Controls.Add(this.txtMin);
            this.medicine.Controls.Add(this.lblManu);
            this.medicine.Controls.Add(this.lblMax);
            this.medicine.Controls.Add(this.txtGen);
            this.medicine.Controls.Add(this.lblGen);
            this.medicine.Controls.Add(this.txtName);
            this.medicine.Controls.Add(this.lblName);
            this.medicine.Controls.Add(this.txtDosage);
            this.medicine.Controls.Add(this.lblMin);
            this.medicine.Location = new System.Drawing.Point(205, 107);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(352, 242);
            this.medicine.TabIndex = 2;
            this.medicine.TabStop = false;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.AccessibleName = "";
            this.cbManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.ItemHeight = 23;
            this.cbManufacturer.Location = new System.Drawing.Point(120, 153);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(187, 29);
            this.cbManufacturer.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer.TabIndex = 7;
            this.cbManufacturer.UseCustomBackColor = true;
            this.cbManufacturer.UseCustomForeColor = true;
            this.cbManufacturer.UseSelectable = true;
            this.cbManufacturer.UseStyleColors = true;
            // 
            // cbForm
            // 
            this.cbForm.AccessibleName = "";
            this.cbForm.BackColor = System.Drawing.Color.Transparent;
            this.cbForm.DisplayFocus = true;
            this.cbForm.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbForm.ItemHeight = 19;
            this.cbForm.Items.AddRange(new object[] {
            " ",
            "Tablet",
            "Capsule",
            "Syrup"});
            this.cbForm.Location = new System.Drawing.Point(264, 110);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(72, 25);
            this.cbForm.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbForm.TabIndex = 6;
            this.cbForm.UseCustomBackColor = true;
            this.cbForm.UseCustomForeColor = true;
            this.cbForm.UseSelectable = true;
            this.cbForm.UseStyleColors = true;
            // 
            // lblForm
            // 
            this.lblForm.AccessibleName = "";
            this.lblForm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblForm.Location = new System.Drawing.Point(199, 110);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(59, 25);
            this.lblForm.TabIndex = 107;
            this.lblForm.Text = "*Form : ";
            this.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbAddSupplier
            // 
            this.pbAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.pbAddSupplier.BackgroundImage = global::PUPiMed.Properties.Resources.adad;
            this.pbAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddSupplier.Location = new System.Drawing.Point(311, 153);
            this.pbAddSupplier.Name = "pbAddSupplier";
            this.pbAddSupplier.Size = new System.Drawing.Size(25, 25);
            this.pbAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSupplier.TabIndex = 116;
            this.pbAddSupplier.TabStop = false;
            this.pbAddSupplier.Click += new System.EventHandler(this.pbAddSupplier_Click);
            // 
            // lblDosage
            // 
            this.lblDosage.AccessibleName = "";
            this.lblDosage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDosage.Location = new System.Drawing.Point(11, 110);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(80, 25);
            this.lblDosage.TabIndex = 107;
            this.lblDosage.Text = "*Dosage : ";
            this.lblDosage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(264, 197);
            this.txtMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(72, 22);
            this.txtMax.TabIndex = 9;
            this.txtMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax.ValueChanged += new System.EventHandler(this.txtMax_ValueChanged);
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(95, 197);
            this.txtMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(72, 22);
            this.txtMin.TabIndex = 8;
            this.txtMin.ValueChanged += new System.EventHandler(this.txtMin_ValueChanged);
            // 
            // txtDosage
            // 
            this.txtDosage.AccessibleName = "";
            this.txtDosage.BackColor = System.Drawing.Color.White;
            this.txtDosage.Lines = new string[0];
            this.txtDosage.Location = new System.Drawing.Point(120, 110);
            this.txtDosage.MaxLength = 50;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDosage.SelectedText = "";
            this.txtDosage.Size = new System.Drawing.Size(72, 25);
            this.txtDosage.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDosage.TabIndex = 5;
            this.txtDosage.UseCustomBackColor = true;
            this.txtDosage.UseCustomForeColor = true;
            this.txtDosage.UseSelectable = true;
            this.txtDosage.UseStyleColors = true;
            this.txtDosage.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtDosage.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtDosage.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.White;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon.Image = global::PUPiMed.Properties.Resources.pill_teal;
            this.icon.Location = new System.Drawing.Point(30, 121);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(143, 143);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 93;
            this.icon.TabStop = false;
            // 
            // cbManufacturer_
            // 
            this.cbManufacturer_.AccessibleName = "";
            this.cbManufacturer_.BackColor = System.Drawing.Color.Transparent;
            this.cbManufacturer_.FormattingEnabled = true;
            this.cbManufacturer_.ItemHeight = 23;
            this.cbManufacturer_.Location = new System.Drawing.Point(120, 132);
            this.cbManufacturer_.Name = "cbManufacturer_";
            this.cbManufacturer_.Size = new System.Drawing.Size(187, 29);
            this.cbManufacturer_.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer_.TabIndex = 5;
            this.cbManufacturer_.UseCustomBackColor = true;
            this.cbManufacturer_.UseCustomForeColor = true;
            this.cbManufacturer_.UseSelectable = true;
            this.cbManufacturer_.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources.adad;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(311, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pbAddSupplier_Click);
            // 
            // txtMax_
            // 
            this.txtMax_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax_.Location = new System.Drawing.Point(275, 186);
            this.txtMax_.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtMax_.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax_.Name = "txtMax_";
            this.txtMax_.Size = new System.Drawing.Size(61, 22);
            this.txtMax_.TabIndex = 7;
            this.txtMax_.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax_.ValueChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtMin_
            // 
            this.txtMin_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin_.Location = new System.Drawing.Point(120, 186);
            this.txtMin_.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtMin_.Name = "txtMin_";
            this.txtMin_.Size = new System.Drawing.Size(61, 22);
            this.txtMin_.TabIndex = 6;
            this.txtMin_.ValueChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "";
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(11, 132);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(116, 25);
            this.metroLabel6.TabIndex = 113;
            this.metroLabel6.Text = "*Manufacturer :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(187, 186);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 110;
            this.metroLabel7.Text = "*Maximum :";
            // 
            // txtGeneric_
            // 
            this.txtGeneric_.AccessibleName = "";
            this.txtGeneric_.BackColor = System.Drawing.Color.White;
            this.txtGeneric_.Lines = new string[0];
            this.txtGeneric_.Location = new System.Drawing.Point(120, 83);
            this.txtGeneric_.MaxLength = 200;
            this.txtGeneric_.Name = "txtGeneric_";
            this.txtGeneric_.PasswordChar = '\0';
            this.txtGeneric_.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGeneric_.SelectedText = "";
            this.txtGeneric_.Size = new System.Drawing.Size(216, 23);
            this.txtGeneric_.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGeneric_.TabIndex = 4;
            this.txtGeneric_.UseCustomBackColor = true;
            this.txtGeneric_.UseSelectable = true;
            this.txtGeneric_.UseStyleColors = true;
            this.txtGeneric_.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "";
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(11, 87);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 107;
            this.metroLabel8.Text = "*Generic Name : ";
            // 
            // txtName_
            // 
            this.txtName_.AccessibleName = "";
            this.txtName_.BackColor = System.Drawing.Color.White;
            this.txtName_.Lines = new string[0];
            this.txtName_.Location = new System.Drawing.Point(120, 34);
            this.txtName_.MaxLength = 200;
            this.txtName_.Name = "txtName_";
            this.txtName_.PasswordChar = '\0';
            this.txtName_.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName_.SelectedText = "";
            this.txtName_.Size = new System.Drawing.Size(216, 23);
            this.txtName_.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName_.TabIndex = 3;
            this.txtName_.UseCustomBackColor = true;
            this.txtName_.UseSelectable = true;
            this.txtName_.UseStyleColors = true;
            this.txtName_.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AccessibleName = "";
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(11, 36);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 106;
            this.metroLabel9.Text = "*Name :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "";
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(11, 183);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 25);
            this.metroLabel10.TabIndex = 109;
            this.metroLabel10.Text = "*Minimum :";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment
            // 
            this.equipment.Controls.Add(this.cbManufacturer_);
            this.equipment.Controls.Add(this.pictureBox1);
            this.equipment.Controls.Add(this.txtMax_);
            this.equipment.Controls.Add(this.txtMin_);
            this.equipment.Controls.Add(this.metroLabel6);
            this.equipment.Controls.Add(this.metroLabel7);
            this.equipment.Controls.Add(this.txtGeneric_);
            this.equipment.Controls.Add(this.metroLabel8);
            this.equipment.Controls.Add(this.txtName_);
            this.equipment.Controls.Add(this.metroLabel9);
            this.equipment.Controls.Add(this.metroLabel10);
            this.equipment.Enabled = false;
            this.equipment.Location = new System.Drawing.Point(205, 107);
            this.equipment.Name = "equipment";
            this.equipment.Size = new System.Drawing.Size(352, 242);
            this.equipment.TabIndex = 2;
            this.equipment.TabStop = false;
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
            this.btnCansel.Location = new System.Drawing.Point(456, 361);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(98, 37);
            this.btnCansel.TabIndex = 190;
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btncancel_Click_1);
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
            this.btnSeyb.Location = new System.Drawing.Point(338, 361);
            this.btnSeyb.Name = "btnSeyb";
            this.btnSeyb.Size = new System.Drawing.Size(99, 37);
            this.btnSeyb.TabIndex = 189;
            this.btnSeyb.UseVisualStyleBackColor = false;
            this.btnSeyb.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "suppcode";
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel1.Location = new System.Drawing.Point(11, 379);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 191;
            this.metroLabel1.Text = "* indicates required fields";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // FormAddItem
            // 
            this.AccessibleName = "frmAddMedicine";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 412);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSeyb);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.medicine);
            this.Controls.Add(this.equipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddItem";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.medicine.ResumeLayout(false);
            this.medicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin_)).EndInit();
            this.equipment.ResumeLayout(false);
            this.equipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblMax;
        private MetroFramework.Controls.MetroLabel lblMin;
        public MetroFramework.Controls.MetroTextBox txtGen;
        private MetroFramework.Controls.MetroLabel lblGen;
        public MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTile status;
        public MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel lblCode;
        private System.Windows.Forms.PictureBox icon;
        private MetroFramework.Controls.MetroLabel lblManu;
        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.NumericUpDown txtMax;
        public System.Windows.Forms.NumericUpDown txtMin;
        private System.Windows.Forms.PictureBox pbAddSupplier;
        public MetroFramework.Controls.MetroComboBox cbForm;
        private MetroFramework.Controls.MetroLabel lblForm;
        private MetroFramework.Controls.MetroLabel lblDosage;
        public MetroFramework.Controls.MetroTextBox txtDosage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroComboBox cbManufacturer_;
        public System.Windows.Forms.NumericUpDown txtMax_;
        public System.Windows.Forms.NumericUpDown txtMin_;
        public MetroFramework.Controls.MetroTextBox txtGeneric_;
        public MetroFramework.Controls.MetroTextBox txtName_;
        public System.Windows.Forms.GroupBox medicine;
        public System.Windows.Forms.GroupBox equipment;
        public MetroFramework.Controls.MetroComboBox cbManufacturer;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSeyb;
        public MetroFramework.Controls.MetroLabel metroLabel1;
    }
}