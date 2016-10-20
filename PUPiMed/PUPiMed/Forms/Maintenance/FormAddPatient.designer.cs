namespace PUPiMed
{
    partial class FormAddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPatient));
            this.suppcode = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtFName = new MetroFramework.Controls.MetroTextBox();
            this.txtMName = new MetroFramework.Controls.MetroTextBox();
            this.txtLName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbPatientType = new MetroFramework.Controls.MetroComboBox();
            this.lblDept = new MetroFramework.Controls.MetroLabel();
            this.cbDept = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbCourse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.rbMale = new MetroFramework.Controls.MetroRadioButton();
            this.rbFemale = new MetroFramework.Controls.MetroRadioButton();
            this.txtSection = new MetroFramework.Controls.MetroTextBox();
            this.txtYear = new MetroFramework.Controls.MetroTextBox();
            this.status = new MetroFramework.Controls.MetroTile();
            this.height = new MetroFramework.Controls.MetroLabel();
            this.weight = new MetroFramework.Controls.MetroLabel();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.txtWeight = new MetroFramework.Controls.MetroTextBox();
            this.cm = new MetroFramework.Controls.MetroLabel();
            this.kg = new MetroFramework.Controls.MetroLabel();
            this.contactno = new MetroFramework.Controls.MetroLabel();
            this.txtContactNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.medicon = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.grpOptional = new System.Windows.Forms.GroupBox();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.dtBday = new MetroFramework.Controls.MetroDateTime();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSeyb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).BeginInit();
            this.grpOptional.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // suppcode
            // 
            this.suppcode.AccessibleName = "patientCode";
            this.suppcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppcode.AutoSize = true;
            this.suppcode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.suppcode.Location = new System.Drawing.Point(75, 312);
            this.suppcode.Name = "suppcode";
            this.suppcode.Size = new System.Drawing.Size(95, 19);
            this.suppcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.suppcode.TabIndex = 26;
            this.suppcode.Text = "Patient Code :";
            this.suppcode.Click += new System.EventHandler(this.suppcode_Click);
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "patientCode";
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(43, 344);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(159, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 1;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.EnabledChanged += new System.EventHandler(this.txtCode_EnabledChanged);
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "fname";
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(29, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "First Name :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "mname";
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(29, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Middle Name :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "lname";
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(30, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Last Name :";
            // 
            // txtFName
            // 
            this.txtFName.AccessibleName = "fname";
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFName.Lines = new string[0];
            this.txtFName.Location = new System.Drawing.Point(158, 90);
            this.txtFName.MaxLength = 50;
            this.txtFName.Name = "txtFName";
            this.txtFName.PasswordChar = '\0';
            this.txtFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFName.SelectedText = "";
            this.txtFName.Size = new System.Drawing.Size(185, 23);
            this.txtFName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtFName.TabIndex = 3;
            this.txtFName.UseCustomBackColor = true;
            this.txtFName.UseSelectable = true;
            this.txtFName.UseStyleColors = true;
            // 
            // txtMName
            // 
            this.txtMName.AccessibleName = "mname";
            this.txtMName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMName.Lines = new string[0];
            this.txtMName.Location = new System.Drawing.Point(158, 129);
            this.txtMName.MaxLength = 50;
            this.txtMName.Name = "txtMName";
            this.txtMName.PasswordChar = '\0';
            this.txtMName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMName.SelectedText = "";
            this.txtMName.Size = new System.Drawing.Size(185, 23);
            this.txtMName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMName.TabIndex = 4;
            this.txtMName.UseCustomBackColor = true;
            this.txtMName.UseSelectable = true;
            this.txtMName.UseStyleColors = true;
            this.txtMName.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // txtLName
            // 
            this.txtLName.AccessibleName = "lname";
            this.txtLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLName.Lines = new string[0];
            this.txtLName.Location = new System.Drawing.Point(158, 165);
            this.txtLName.MaxLength = 50;
            this.txtLName.Name = "txtLName";
            this.txtLName.PasswordChar = '\0';
            this.txtLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLName.SelectedText = "";
            this.txtLName.Size = new System.Drawing.Size(185, 23);
            this.txtLName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtLName.TabIndex = 5;
            this.txtLName.UseCustomBackColor = true;
            this.txtLName.UseSelectable = true;
            this.txtLName.UseStyleColors = true;
            this.txtLName.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "course";
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(366, 90);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Course :";
            // 
            // cbPatientType
            // 
            this.cbPatientType.AccessibleName = "ptype";
            this.cbPatientType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPatientType.BackColor = System.Drawing.Color.White;
            this.cbPatientType.FormattingEnabled = true;
            this.cbPatientType.ItemHeight = 23;
            this.cbPatientType.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Admin"});
            this.cbPatientType.Location = new System.Drawing.Point(158, 46);
            this.cbPatientType.Name = "cbPatientType";
            this.cbPatientType.Size = new System.Drawing.Size(185, 29);
            this.cbPatientType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbPatientType.TabIndex = 2;
            this.cbPatientType.UseCustomBackColor = true;
            this.cbPatientType.UseCustomForeColor = true;
            this.cbPatientType.UseSelectable = true;
            this.cbPatientType.UseStyleColors = true;
            this.cbPatientType.SelectedIndexChanged += new System.EventHandler(this.cbPatientType_SelectedIndexChanged);
            // 
            // lblDept
            // 
            this.lblDept.AccessibleName = "depOrCollege";
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDept.AutoSize = true;
            this.lblDept.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDept.Location = new System.Drawing.Point(366, 51);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(61, 19);
            this.lblDept.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblDept.TabIndex = 28;
            this.lblDept.Text = "College :";
            this.lblDept.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // cbDept
            // 
            this.cbDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDept.BackColor = System.Drawing.Color.White;
            this.cbDept.DropDownWidth = 500;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.ItemHeight = 23;
            this.cbDept.Location = new System.Drawing.Point(467, 46);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(168, 29);
            this.cbDept.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbDept.TabIndex = 7;
            this.cbDept.UseCustomBackColor = true;
            this.cbDept.UseCustomForeColor = true;
            this.cbDept.UseSelectable = true;
            this.cbDept.UseStyleColors = true;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "ptype";
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(29, 51);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Patient Type :";
            // 
            // cbCourse
            // 
            this.cbCourse.AccessibleName = "course";
            this.cbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCourse.BackColor = System.Drawing.Color.White;
            this.cbCourse.DropDownWidth = 500;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.ItemHeight = 23;
            this.cbCourse.Location = new System.Drawing.Point(467, 85);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(168, 29);
            this.cbCourse.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbCourse.TabIndex = 8;
            this.cbCourse.UseCustomBackColor = true;
            this.cbCourse.UseCustomForeColor = true;
            this.cbCourse.UseSelectable = true;
            this.cbCourse.UseStyleColors = true;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.cbCourse.EnabledChanged += new System.EventHandler(this.cbCourse_EnabledChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "year";
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(366, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Year :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AccessibleName = "section";
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(365, 169);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Section :";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "gender";
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(365, 211);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(61, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel10.TabIndex = 28;
            this.metroLabel10.Text = "Gender :";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // rbMale
            // 
            this.rbMale.AccessibleName = "male";
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.DisplayFocus = true;
            this.rbMale.Location = new System.Drawing.Point(483, 211);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 15);
            this.rbMale.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseSelectable = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AccessibleName = "female";
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(557, 211);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 15);
            this.rbFemale.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbFemale.TabIndex = 12;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseSelectable = true;
            // 
            // txtSection
            // 
            this.txtSection.AccessibleName = "section";
            this.txtSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSection.Lines = new string[0];
            this.txtSection.Location = new System.Drawing.Point(467, 165);
            this.txtSection.MaxLength = 2;
            this.txtSection.Name = "txtSection";
            this.txtSection.PasswordChar = '\0';
            this.txtSection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSection.SelectedText = "";
            this.txtSection.Size = new System.Drawing.Size(168, 23);
            this.txtSection.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtSection.TabIndex = 10;
            this.txtSection.UseCustomBackColor = true;
            this.txtSection.UseSelectable = true;
            this.txtSection.UseStyleColors = true;
            this.txtSection.EnabledChanged += new System.EventHandler(this.txtCode_EnabledChanged);
            // 
            // txtYear
            // 
            this.txtYear.AccessibleName = "year";
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYear.Lines = new string[0];
            this.txtYear.Location = new System.Drawing.Point(467, 129);
            this.txtYear.MaxLength = 1;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(168, 23);
            this.txtYear.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtYear.TabIndex = 9;
            this.txtYear.UseCustomBackColor = true;
            this.txtYear.UseSelectable = true;
            this.txtYear.UseStyleColors = true;
            this.txtYear.EnabledChanged += new System.EventHandler(this.txtCode_EnabledChanged);
            // 
            // status
            // 
            this.status.AccessibleName = "basicinfos";
            this.status.ActiveControl = null;
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Enabled = false;
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(-2, 84);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(937, 32);
            this.status.TabIndex = 35;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseCustomForeColor = true;
            this.status.UseSelectable = true;
            // 
            // height
            // 
            this.height.AccessibleName = "height";
            this.height.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.height.AutoSize = true;
            this.height.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.height.Location = new System.Drawing.Point(10, 27);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(57, 19);
            this.height.Style = MetroFramework.MetroColorStyle.Teal;
            this.height.TabIndex = 36;
            this.height.Text = "Height :";
            // 
            // weight
            // 
            this.weight.AccessibleName = "weight";
            this.weight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weight.AutoSize = true;
            this.weight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.weight.Location = new System.Drawing.Point(279, 27);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(60, 19);
            this.weight.Style = MetroFramework.MetroColorStyle.Teal;
            this.weight.TabIndex = 37;
            this.weight.Text = "Weight :";
            // 
            // txtHeight
            // 
            this.txtHeight.AccessibleName = "height";
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Lines = new string[] {
        "0"};
            this.txtHeight.Location = new System.Drawing.Point(100, 27);
            this.txtHeight.MaxLength = 3;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeight.SelectedText = "";
            this.txtHeight.Size = new System.Drawing.Size(116, 23);
            this.txtHeight.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtHeight.TabIndex = 13;
            this.txtHeight.Text = "0";
            this.txtHeight.UseCustomBackColor = true;
            this.txtHeight.UseSelectable = true;
            this.txtHeight.UseStyleColors = true;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height1_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.AccessibleName = "weight";
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Lines = new string[] {
        "0"};
            this.txtWeight.Location = new System.Drawing.Point(356, 27);
            this.txtWeight.MaxLength = 3;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(134, 23);
            this.txtWeight.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtWeight.TabIndex = 14;
            this.txtWeight.Text = "0";
            this.txtWeight.UseCustomBackColor = true;
            this.txtWeight.UseSelectable = true;
            this.txtWeight.UseStyleColors = true;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height1_KeyPress);
            // 
            // cm
            // 
            this.cm.AccessibleName = "cm";
            this.cm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(217, 27);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(27, 19);
            this.cm.Style = MetroFramework.MetroColorStyle.Teal;
            this.cm.TabIndex = 40;
            this.cm.Text = "cm";
            // 
            // kg
            // 
            this.kg.AccessibleName = "kg";
            this.kg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(495, 27);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(23, 19);
            this.kg.Style = MetroFramework.MetroColorStyle.Teal;
            this.kg.TabIndex = 41;
            this.kg.Text = "kg";
            // 
            // contactno
            // 
            this.contactno.AccessibleName = "Contactno";
            this.contactno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactno.AutoSize = true;
            this.contactno.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.contactno.Location = new System.Drawing.Point(563, 27);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(86, 19);
            this.contactno.Style = MetroFramework.MetroColorStyle.Teal;
            this.contactno.TabIndex = 42;
            this.contactno.Text = "Contact No :";
            // 
            // txtContactNo
            // 
            this.txtContactNo.AccessibleName = "cno";
            this.txtContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContactNo.Lines = new string[0];
            this.txtContactNo.Location = new System.Drawing.Point(665, 27);
            this.txtContactNo.MaxLength = 20;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.Size = new System.Drawing.Size(168, 23);
            this.txtContactNo.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtContactNo.TabIndex = 15;
            this.txtContactNo.UseCustomBackColor = true;
            this.txtContactNo.UseSelectable = true;
            this.txtContactNo.UseStyleColors = true;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cno_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "section";
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(29, 211);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Birth Day :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // medicon
            // 
            this.medicon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicon.BackColor = System.Drawing.Color.White;
            this.medicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.medicon.Image = global::PUPiMed.Properties.Resources.add_w_perseon;
            this.medicon.Location = new System.Drawing.Point(43, 141);
            this.medicon.Name = "medicon";
            this.medicon.Size = new System.Drawing.Size(159, 159);
            this.medicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicon.TabIndex = 25;
            this.medicon.TabStop = false;
            this.medicon.Click += new System.EventHandler(this.medicon_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(263, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(392, 101);
            this.title.TabIndex = 108;
            this.title.Text = "PATIENT REGISTRATION";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpOptional
            // 
            this.grpOptional.Controls.Add(this.txtContactNo);
            this.grpOptional.Controls.Add(this.contactno);
            this.grpOptional.Controls.Add(this.kg);
            this.grpOptional.Controls.Add(this.cm);
            this.grpOptional.Controls.Add(this.txtWeight);
            this.grpOptional.Controls.Add(this.txtHeight);
            this.grpOptional.Controls.Add(this.weight);
            this.grpOptional.Controls.Add(this.height);
            this.grpOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptional.Location = new System.Drawing.Point(31, 403);
            this.grpOptional.Name = "grpOptional";
            this.grpOptional.Size = new System.Drawing.Size(867, 65);
            this.grpOptional.TabIndex = 13;
            this.grpOptional.TabStop = false;
            this.grpOptional.Text = "Optional Data";
            // 
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.dtBday);
            this.grpPersonal.Controls.Add(this.txtSection);
            this.grpPersonal.Controls.Add(this.txtYear);
            this.grpPersonal.Controls.Add(this.rbFemale);
            this.grpPersonal.Controls.Add(this.rbMale);
            this.grpPersonal.Controls.Add(this.cbCourse);
            this.grpPersonal.Controls.Add(this.cbDept);
            this.grpPersonal.Controls.Add(this.cbPatientType);
            this.grpPersonal.Controls.Add(this.lblDept);
            this.grpPersonal.Controls.Add(this.metroLabel8);
            this.grpPersonal.Controls.Add(this.metroLabel10);
            this.grpPersonal.Controls.Add(this.metroLabel2);
            this.grpPersonal.Controls.Add(this.metroLabel9);
            this.grpPersonal.Controls.Add(this.metroLabel1);
            this.grpPersonal.Controls.Add(this.metroLabel5);
            this.grpPersonal.Controls.Add(this.metroLabel6);
            this.grpPersonal.Controls.Add(this.metroLabel4);
            this.grpPersonal.Controls.Add(this.metroLabel3);
            this.grpPersonal.Controls.Add(this.txtLName);
            this.grpPersonal.Controls.Add(this.txtMName);
            this.grpPersonal.Controls.Add(this.txtFName);
            this.grpPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonal.Location = new System.Drawing.Point(229, 133);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(669, 264);
            this.grpPersonal.TabIndex = 2;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Personal Data";
            // 
            // dtBday
            // 
            this.dtBday.AllowDrop = true;
            this.dtBday.Checked = false;
            this.dtBday.DisplayFocus = true;
            this.dtBday.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBday.Location = new System.Drawing.Point(158, 205);
            this.dtBday.MaxDate = new System.DateTime(2016, 9, 23, 0, 0, 0, 0);
            this.dtBday.MinDate = new System.DateTime(1916, 1, 1, 0, 0, 0, 0);
            this.dtBday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtBday.Name = "dtBday";
            this.dtBday.Size = new System.Drawing.Size(185, 29);
            this.dtBday.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtBday.TabIndex = 6;
            this.dtBday.UseStyleColors = true;
            this.dtBday.Value = new System.DateTime(2016, 9, 23, 0, 0, 0, 0);
            this.dtBday.ValueChanged += new System.EventHandler(this.dtBday_ValueChanged);
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
            this.btnCansel.Location = new System.Drawing.Point(800, 492);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(98, 37);
            this.btnCansel.TabIndex = 190;
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
            this.btnSeyb.Location = new System.Drawing.Point(682, 492);
            this.btnSeyb.Name = "btnSeyb";
            this.btnSeyb.Size = new System.Drawing.Size(99, 37);
            this.btnSeyb.TabIndex = 189;
            this.btnSeyb.UseVisualStyleBackColor = false;
            this.btnSeyb.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddPatient
            // 
            this.AccessibleName = "frmAddPatient";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 553);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSeyb);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpOptional);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.suppcode);
            this.Controls.Add(this.medicon);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddPatient";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.AddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).EndInit();
            this.grpOptional.ResumeLayout(false);
            this.grpOptional.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox medicon;
        public MetroFramework.Controls.MetroLabel suppcode;
        public MetroFramework.Controls.MetroTextBox txtCode;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroTextBox txtFName;
        public MetroFramework.Controls.MetroTextBox txtMName;
        public MetroFramework.Controls.MetroTextBox txtLName;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroComboBox cbPatientType;
        public MetroFramework.Controls.MetroLabel lblDept;
        public MetroFramework.Controls.MetroComboBox cbDept;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroComboBox cbCourse;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroRadioButton rbMale;
        public MetroFramework.Controls.MetroRadioButton rbFemale;
        public MetroFramework.Controls.MetroTextBox txtSection;
        public MetroFramework.Controls.MetroTextBox txtYear;
        public MetroFramework.Controls.MetroTile status;
        public MetroFramework.Controls.MetroLabel height;
        public MetroFramework.Controls.MetroLabel weight;
        public MetroFramework.Controls.MetroTextBox txtHeight;
        public MetroFramework.Controls.MetroTextBox txtWeight;
        public MetroFramework.Controls.MetroLabel cm;
        public MetroFramework.Controls.MetroLabel kg;
        public MetroFramework.Controls.MetroLabel contactno;
        public MetroFramework.Controls.MetroTextBox txtContactNo;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.GroupBox grpOptional;
        public System.Windows.Forms.GroupBox grpPersonal;
        public MetroFramework.Controls.MetroDateTime dtBday;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSeyb;
    }
}