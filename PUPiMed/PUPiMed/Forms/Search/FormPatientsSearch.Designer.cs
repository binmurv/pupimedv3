namespace PUPiMed
{
    partial class FormPatientSearch
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
            this.status = new MetroFramework.Controls.MetroTile();
            this.Title = new System.Windows.Forms.Label();
            this.txtSection = new MetroFramework.Controls.MetroTextBox();
            this.txtYear = new MetroFramework.Controls.MetroTextBox();
            this.rbFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rbMale = new MetroFramework.Controls.MetroRadioButton();
            this.cbCourse = new MetroFramework.Controls.MetroComboBox();
            this.cbDept = new MetroFramework.Controls.MetroComboBox();
            this.cbPatientType = new MetroFramework.Controls.MetroComboBox();
            this.lblDept = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtLName = new MetroFramework.Controls.MetroTextBox();
            this.txtMName = new MetroFramework.Controls.MetroTextBox();
            this.txtFName = new MetroFramework.Controls.MetroTextBox();
            this.kg = new MetroFramework.Controls.MetroLabel();
            this.cm = new MetroFramework.Controls.MetroLabel();
            this.txtWeight = new MetroFramework.Controls.MetroTextBox();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.weight = new MetroFramework.Controls.MetroLabel();
            this.height = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.suppcode = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.rbAll = new MetroFramework.Controls.MetroRadioButton();
            this.chkCourse = new MetroFramework.Controls.MetroCheckBox();
            this.chkDept = new MetroFramework.Controls.MetroCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-6, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(879, 29);
            this.status.TabIndex = 176;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Teal;
            this.Title.Location = new System.Drawing.Point(-3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(836, 75);
            this.Title.TabIndex = 175;
            this.Title.Text = "PATIENT SEARCH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSection
            // 
            this.txtSection.AccessibleName = "section";
            this.txtSection.Lines = new string[0];
            this.txtSection.Location = new System.Drawing.Point(599, 238);
            this.txtSection.MaxLength = 2;
            this.txtSection.Name = "txtSection";
            this.txtSection.PasswordChar = '\0';
            this.txtSection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSection.SelectedText = "";
            this.txtSection.Size = new System.Drawing.Size(185, 23);
            this.txtSection.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtSection.TabIndex = 8;
            this.txtSection.UseCustomBackColor = true;
            this.txtSection.UseSelectable = true;
            this.txtSection.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // txtYear
            // 
            this.txtYear.AccessibleName = "year";
            this.txtYear.Lines = new string[0];
            this.txtYear.Location = new System.Drawing.Point(186, 264);
            this.txtYear.MaxLength = 1;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(185, 23);
            this.txtYear.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtYear.TabIndex = 7;
            this.txtYear.UseCustomBackColor = true;
            this.txtYear.UseSelectable = true;
            this.txtYear.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // rbFemale
            // 
            this.rbFemale.AccessibleName = "female";
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(723, 396);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 15);
            this.rbFemale.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbFemale.TabIndex = 15;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseSelectable = true;
            // 
            // rbMale
            // 
            this.rbMale.AccessibleName = "male";
            this.rbMale.AutoSize = true;
            this.rbMale.DisplayFocus = true;
            this.rbMale.Location = new System.Drawing.Point(657, 396);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 15);
            this.rbMale.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbMale.TabIndex = 14;
            this.rbMale.Text = "Male";
            this.rbMale.UseSelectable = true;
            // 
            // cbCourse
            // 
            this.cbCourse.AccessibleName = "course";
            this.cbCourse.DropDownWidth = 500;
            this.cbCourse.Enabled = false;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.ItemHeight = 23;
            this.cbCourse.Location = new System.Drawing.Point(599, 285);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(161, 29);
            this.cbCourse.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbCourse.TabIndex = 10;
            this.cbCourse.UseSelectable = true;
            this.cbCourse.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // cbDept
            // 
            this.cbDept.DropDownWidth = 500;
            this.cbDept.Enabled = false;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.ItemHeight = 23;
            this.cbDept.Location = new System.Drawing.Point(186, 306);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(161, 29);
            this.cbDept.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbDept.TabIndex = 9;
            this.cbDept.UseSelectable = true;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            this.cbDept.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // cbPatientType
            // 
            this.cbPatientType.AccessibleName = "ptype";
            this.cbPatientType.FormattingEnabled = true;
            this.cbPatientType.ItemHeight = 23;
            this.cbPatientType.Items.AddRange(new object[] {
            "",
            "Student",
            "Faculty",
            "Admin"});
            this.cbPatientType.Location = new System.Drawing.Point(186, 132);
            this.cbPatientType.Name = "cbPatientType";
            this.cbPatientType.Size = new System.Drawing.Size(185, 29);
            this.cbPatientType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbPatientType.TabIndex = 1;
            this.cbPatientType.UseSelectable = true;
            this.cbPatientType.SelectedIndexChanged += new System.EventHandler(this.cbPatientType_SelectedIndexChanged);
            this.cbPatientType.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // lblDept
            // 
            this.lblDept.AccessibleName = "depOrCollege";
            this.lblDept.AutoSize = true;
            this.lblDept.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDept.Location = new System.Drawing.Point(57, 313);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(90, 19);
            this.lblDept.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblDept.TabIndex = 188;
            this.lblDept.Text = "Department :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "ptype";
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(57, 137);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel8.TabIndex = 189;
            this.metroLabel8.Text = "Patient Type :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "gender";
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(452, 392);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(61, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel10.TabIndex = 197;
            this.metroLabel10.Text = "Gender :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "section";
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(57, 401);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 190;
            this.metroLabel2.Text = "Age :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AccessibleName = "section";
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(452, 239);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel9.TabIndex = 191;
            this.metroLabel9.Text = "Section :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "year";
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(57, 269);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 192;
            this.metroLabel1.Text = "Year :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "course";
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(452, 290);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 193;
            this.metroLabel5.Text = "Course :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "lname";
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(57, 225);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 194;
            this.metroLabel6.Text = "Last Name :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "mname";
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(452, 188);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 195;
            this.metroLabel4.Text = "Middle Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "fname";
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(57, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 196;
            this.metroLabel3.Text = "First Name :";
            // 
            // txtLName
            // 
            this.txtLName.AccessibleName = "lname";
            this.txtLName.Lines = new string[0];
            this.txtLName.Location = new System.Drawing.Point(186, 222);
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
            this.txtLName.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // txtMName
            // 
            this.txtMName.AccessibleName = "mname";
            this.txtMName.Lines = new string[0];
            this.txtMName.Location = new System.Drawing.Point(599, 185);
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
            this.txtMName.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // txtFName
            // 
            this.txtFName.AccessibleName = "fname";
            this.txtFName.Lines = new string[0];
            this.txtFName.Location = new System.Drawing.Point(186, 180);
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
            this.txtFName.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // kg
            // 
            this.kg.AccessibleName = "kg";
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(761, 342);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(23, 19);
            this.kg.TabIndex = 204;
            this.kg.Text = "kg";
            // 
            // cm
            // 
            this.cm.AccessibleName = "cm";
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(344, 358);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(27, 19);
            this.cm.TabIndex = 203;
            this.cm.Text = "cm";
            // 
            // txtWeight
            // 
            this.txtWeight.AccessibleName = "weight";
            this.txtWeight.Lines = new string[0];
            this.txtWeight.Location = new System.Drawing.Point(599, 342);
            this.txtWeight.MaxLength = 3;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(156, 23);
            this.txtWeight.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtWeight.TabIndex = 12;
            this.txtWeight.UseCustomBackColor = true;
            this.txtWeight.UseSelectable = true;
            this.txtWeight.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.AccessibleName = "height";
            this.txtHeight.Lines = new string[0];
            this.txtHeight.Location = new System.Drawing.Point(186, 354);
            this.txtHeight.MaxLength = 3;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeight.SelectedText = "";
            this.txtHeight.Size = new System.Drawing.Size(152, 23);
            this.txtHeight.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtHeight.TabIndex = 11;
            this.txtHeight.UseCustomBackColor = true;
            this.txtHeight.UseSelectable = true;
            this.txtHeight.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // weight
            // 
            this.weight.AccessibleName = "weight";
            this.weight.AutoSize = true;
            this.weight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.weight.Location = new System.Drawing.Point(452, 341);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(60, 19);
            this.weight.Style = MetroFramework.MetroColorStyle.Teal;
            this.weight.TabIndex = 202;
            this.weight.Text = "Weight :";
            // 
            // height
            // 
            this.height.AccessibleName = "height";
            this.height.AutoSize = true;
            this.height.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.height.Location = new System.Drawing.Point(57, 357);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(57, 19);
            this.height.Style = MetroFramework.MetroColorStyle.Teal;
            this.height.TabIndex = 201;
            this.height.Text = "Height :";
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "patientCode";
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(599, 132);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(185, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 2;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseCustomForeColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            // 
            // suppcode
            // 
            this.suppcode.AccessibleName = "patientCode";
            this.suppcode.AutoSize = true;
            this.suppcode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.suppcode.Location = new System.Drawing.Point(452, 137);
            this.suppcode.Name = "suppcode";
            this.suppcode.Size = new System.Drawing.Size(95, 19);
            this.suppcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.suppcode.TabIndex = 218;
            this.suppcode.Text = "Patient Code :";
            this.suppcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAge
            // 
            this.txtAge.AccessibleName = "lname";
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(186, 396);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(185, 23);
            this.txtAge.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtAge.TabIndex = 13;
            this.txtAge.UseCustomBackColor = true;
            this.txtAge.UseSelectable = true;
            this.txtAge.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // rbAll
            // 
            this.rbAll.AccessibleName = "male";
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.DisplayFocus = true;
            this.rbAll.Location = new System.Drawing.Point(599, 395);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(37, 15);
            this.rbAll.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbAll.TabIndex = 14;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseSelectable = true;
            // 
            // chkCourse
            // 
            this.chkCourse.Location = new System.Drawing.Point(765, 288);
            this.chkCourse.Name = "chkCourse";
            this.chkCourse.Size = new System.Drawing.Size(18, 26);
            this.chkCourse.TabIndex = 223;
            this.chkCourse.Text = " ";
            this.chkCourse.UseSelectable = true;
            this.chkCourse.CheckedChanged += new System.EventHandler(this.chkCourse_CheckedChanged_1);
            // 
            // chkDept
            // 
            this.chkDept.Location = new System.Drawing.Point(353, 306);
            this.chkDept.Name = "chkDept";
            this.chkDept.Size = new System.Drawing.Size(18, 26);
            this.chkDept.TabIndex = 223;
            this.chkDept.Text = " ";
            this.chkDept.UseSelectable = true;
            this.chkDept.CheckedChanged += new System.EventHandler(this.chkDept_CheckedChanged);
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
            this.button1.Location = new System.Drawing.Point(682, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 278;
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
            this.button2.Location = new System.Drawing.Point(544, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 277;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkDept);
            this.Controls.Add(this.chkCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.suppcode);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.cbPatientType);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Title);
            this.Name = "FormPatientSearch";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.FormPatientSearch_Load);
            this.EnabledChanged += new System.EventHandler(this.txtAge_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile status;
        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroTextBox txtSection;
        private MetroFramework.Controls.MetroTextBox txtYear;
        private MetroFramework.Controls.MetroRadioButton rbFemale;
        private MetroFramework.Controls.MetroRadioButton rbMale;
        private MetroFramework.Controls.MetroComboBox cbCourse;
        private MetroFramework.Controls.MetroComboBox cbDept;
        private MetroFramework.Controls.MetroComboBox cbPatientType;
        private MetroFramework.Controls.MetroLabel lblDept;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtLName;
        private MetroFramework.Controls.MetroTextBox txtMName;
        private MetroFramework.Controls.MetroTextBox txtFName;
        private MetroFramework.Controls.MetroLabel kg;
        private MetroFramework.Controls.MetroLabel cm;
        private MetroFramework.Controls.MetroTextBox txtWeight;
        private MetroFramework.Controls.MetroTextBox txtHeight;
        private MetroFramework.Controls.MetroLabel weight;
        private MetroFramework.Controls.MetroLabel height;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel suppcode;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroRadioButton rbAll;
        private MetroFramework.Controls.MetroCheckBox chkCourse;
        private MetroFramework.Controls.MetroCheckBox chkDept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}