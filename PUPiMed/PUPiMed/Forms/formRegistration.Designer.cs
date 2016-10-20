namespace PUPiMed.Forms
{
    partial class formRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistration));
            this.status = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtFName = new MetroFramework.Controls.MetroTextBox();
            this.txtJob = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAPassword = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAUsername = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMName = new MetroFramework.Controls.MetroTextBox();
            this.MiddleName = new System.Windows.Forms.Label();
            this.txtLName = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AccessibleName = "basicinfos";
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Enabled = false;
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(0, 62);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(469, 27);
            this.status.TabIndex = 110;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseCustomForeColor = true;
            this.status.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 54);
            this.label1.TabIndex = 111;
            this.label1.Text = "New Account Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MiddleName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtMName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtJob);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Account";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Job Description :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(25, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 23);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "First Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(163, 214);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(214, 23);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFName
            // 
            this.txtFName.Lines = new string[0];
            this.txtFName.Location = new System.Drawing.Point(163, 34);
            this.txtFName.MaxLength = 200;
            this.txtFName.Name = "txtFName";
            this.txtFName.PasswordChar = '\0';
            this.txtFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFName.SelectedText = "";
            this.txtFName.Size = new System.Drawing.Size(214, 23);
            this.txtFName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtFName.TabIndex = 0;
            this.txtFName.UseCustomBackColor = true;
            this.txtFName.UseSelectable = true;
            this.txtFName.UseStyleColors = true;
            // 
            // txtJob
            // 
            this.txtJob.Lines = new string[0];
            this.txtJob.Location = new System.Drawing.Point(163, 142);
            this.txtJob.MaxLength = 200;
            this.txtJob.Name = "txtJob";
            this.txtJob.PasswordChar = '\0';
            this.txtJob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJob.SelectedText = "";
            this.txtJob.Size = new System.Drawing.Size(214, 23);
            this.txtJob.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtJob.TabIndex = 3;
            this.txtJob.UseCustomBackColor = true;
            this.txtJob.UseSelectable = true;
            this.txtJob.UseStyleColors = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(163, 178);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(214, 23);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtUsername.TabIndex = 4;
            this.txtUsername.UseCustomBackColor = true;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAPassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAUsername);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin Account";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAPassword
            // 
            this.txtAPassword.Lines = new string[0];
            this.txtAPassword.Location = new System.Drawing.Point(163, 59);
            this.txtAPassword.MaxLength = 200;
            this.txtAPassword.Name = "txtAPassword";
            this.txtAPassword.PasswordChar = '●';
            this.txtAPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAPassword.SelectedText = "";
            this.txtAPassword.Size = new System.Drawing.Size(214, 23);
            this.txtAPassword.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtAPassword.TabIndex = 2;
            this.txtAPassword.UseCustomBackColor = true;
            this.txtAPassword.UseSelectable = true;
            this.txtAPassword.UseStyleColors = true;
            this.txtAPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAUsername
            // 
            this.txtAUsername.Lines = new string[0];
            this.txtAUsername.Location = new System.Drawing.Point(163, 22);
            this.txtAUsername.MaxLength = 200;
            this.txtAUsername.Name = "txtAUsername";
            this.txtAUsername.PasswordChar = '\0';
            this.txtAUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAUsername.SelectedText = "";
            this.txtAUsername.Size = new System.Drawing.Size(214, 23);
            this.txtAUsername.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtAUsername.TabIndex = 1;
            this.txtAUsername.UseCustomBackColor = true;
            this.txtAUsername.UseSelectable = true;
            this.txtAUsername.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Image = global::PUPiMed.Properties.Resources.add_group_25px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(180, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "       Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMName
            // 
            this.txtMName.Lines = new string[0];
            this.txtMName.Location = new System.Drawing.Point(163, 70);
            this.txtMName.MaxLength = 200;
            this.txtMName.Name = "txtMName";
            this.txtMName.PasswordChar = '\0';
            this.txtMName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMName.SelectedText = "";
            this.txtMName.Size = new System.Drawing.Size(214, 23);
            this.txtMName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMName.TabIndex = 1;
            this.txtMName.UseCustomBackColor = true;
            this.txtMName.UseSelectable = true;
            this.txtMName.UseStyleColors = true;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(25, 70);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(132, 23);
            this.MiddleName.TabIndex = 10;
            this.MiddleName.Text = "Middle Name :";
            this.MiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLName
            // 
            this.txtLName.Lines = new string[0];
            this.txtLName.Location = new System.Drawing.Point(163, 106);
            this.txtLName.MaxLength = 200;
            this.txtLName.Name = "txtLName";
            this.txtLName.PasswordChar = '\0';
            this.txtLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLName.SelectedText = "";
            this.txtLName.Size = new System.Drawing.Size(214, 23);
            this.txtLName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtLName.TabIndex = 2;
            this.txtLName.UseCustomBackColor = true;
            this.txtLName.UseSelectable = true;
            this.txtLName.UseStyleColors = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Last Name :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formRegistration
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRegistration";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.formRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTile status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtFName;
        private MetroFramework.Controls.MetroTextBox txtJob;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtAPassword;
        private MetroFramework.Controls.MetroTextBox txtAUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MiddleName;
        private MetroFramework.Controls.MetroTextBox txtLName;
        private MetroFramework.Controls.MetroTextBox txtMName;
    }
}