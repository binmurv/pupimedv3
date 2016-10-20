namespace PUPiMed.Forms
{
    partial class FormReceiveItemSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiveItemSearch));
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.status = new MetroFramework.Controls.MetroTile();
            this.Title = new System.Windows.Forms.Label();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.txtBatch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtReceipt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtExp = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtReceived = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplier = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(632, 124);
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
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-6, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(865, 29);
            this.status.TabIndex = 198;
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
            this.Title.Size = new System.Drawing.Size(859, 75);
            this.Title.TabIndex = 197;
            this.Title.Text = "RECEIVED ITEMS SEARCH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "";
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(457, 124);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 29);
            this.metroLabel7.TabIndex = 187;
            this.metroLabel7.Text = "Item Name :";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "";
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(39, 124);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 29);
            this.metroLabel5.TabIndex = 186;
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
            this.cbType.Location = new System.Drawing.Point(225, 124);
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
            // 
            // txtBatch
            // 
            this.txtBatch.AccessibleName = "";
            this.txtBatch.BackColor = System.Drawing.Color.White;
            this.txtBatch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBatch.Lines = new string[0];
            this.txtBatch.Location = new System.Drawing.Point(225, 167);
            this.txtBatch.MaxLength = 32767;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.PasswordChar = '\0';
            this.txtBatch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBatch.SelectedText = "";
            this.txtBatch.Size = new System.Drawing.Size(176, 29);
            this.txtBatch.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtBatch.TabIndex = 3;
            this.txtBatch.UseCustomBackColor = true;
            this.txtBatch.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "";
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(39, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 29);
            this.metroLabel1.TabIndex = 200;
            this.metroLabel1.Text = "Batch Code :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtRCode
            // 
            this.txtRCode.AccessibleName = "";
            this.txtRCode.BackColor = System.Drawing.Color.White;
            this.txtRCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRCode.Lines = new string[0];
            this.txtRCode.Location = new System.Drawing.Point(632, 238);
            this.txtRCode.MaxLength = 20;
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.PasswordChar = '\0';
            this.txtRCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRCode.SelectedText = "";
            this.txtRCode.Size = new System.Drawing.Size(176, 29);
            this.txtRCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtRCode.TabIndex = 8;
            this.txtRCode.UseCustomBackColor = true;
            this.txtRCode.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "";
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(457, 238);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 29);
            this.metroLabel2.TabIndex = 202;
            this.metroLabel2.Text = "Receiving Code :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // txtReceipt
            // 
            this.txtReceipt.AccessibleName = "";
            this.txtReceipt.BackColor = System.Drawing.Color.White;
            this.txtReceipt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtReceipt.Lines = new string[0];
            this.txtReceipt.Location = new System.Drawing.Point(225, 253);
            this.txtReceipt.MaxLength = 32767;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.PasswordChar = '\0';
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceipt.SelectedText = "";
            this.txtReceipt.Size = new System.Drawing.Size(176, 29);
            this.txtReceipt.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtReceipt.TabIndex = 9;
            this.txtReceipt.UseCustomBackColor = true;
            this.txtReceipt.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "";
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(39, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 29);
            this.metroLabel3.TabIndex = 204;
            this.metroLabel3.Text = "Delivery Receipt Code :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // dtExp
            // 
            this.dtExp.AllowDrop = true;
            this.dtExp.Checked = false;
            this.dtExp.DisplayFocus = true;
            this.dtExp.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExp.Location = new System.Drawing.Point(225, 210);
            this.dtExp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtExp.Name = "dtExp";
            this.dtExp.ShowCheckBox = true;
            this.dtExp.Size = new System.Drawing.Size(176, 29);
            this.dtExp.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtExp.TabIndex = 7;
            this.dtExp.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "";
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(39, 210);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 29);
            this.metroLabel4.TabIndex = 206;
            this.metroLabel4.Text = "Expiration Date :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "";
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(39, 296);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 29);
            this.metroLabel6.TabIndex = 208;
            this.metroLabel6.Text = "Supplier :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "";
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(457, 295);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(130, 29);
            this.metroLabel8.TabIndex = 210;
            this.metroLabel8.Text = "Date Received :";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // dtReceived
            // 
            this.dtReceived.AllowDrop = true;
            this.dtReceived.Checked = false;
            this.dtReceived.DisplayFocus = true;
            this.dtReceived.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceived.Location = new System.Drawing.Point(632, 295);
            this.dtReceived.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReceived.Name = "dtReceived";
            this.dtReceived.ShowCheckBox = true;
            this.dtReceived.Size = new System.Drawing.Size(176, 29);
            this.dtReceived.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtReceived.TabIndex = 10;
            this.dtReceived.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "";
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(457, 181);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(95, 29);
            this.metroLabel10.TabIndex = 214;
            this.metroLabel10.Text = "Quantity :";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.AccessibleName = "";
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(632, 181);
            this.txtQty.MaxLength = 7;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(176, 29);
            this.txtQty.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtQty.TabIndex = 4;
            this.txtQty.UseCustomBackColor = true;
            this.txtQty.UseSelectable = true;
            // 
            // txtSupplier
            // 
            this.txtSupplier.AccessibleName = "";
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSupplier.Lines = new string[0];
            this.txtSupplier.Location = new System.Drawing.Point(225, 296);
            this.txtSupplier.MaxLength = 100;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(176, 29);
            this.txtSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtSupplier.TabIndex = 218;
            this.txtSupplier.UseCustomBackColor = true;
            this.txtSupplier.UseSelectable = true;
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
            this.button1.Location = new System.Drawing.Point(706, 346);
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
            this.button2.Location = new System.Drawing.Point(568, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 277;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormReceiveItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dtReceived);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtExp);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtRCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReceiveItemSearch";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.FormReceiveItemSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTile status;
        private System.Windows.Forms.Label Title;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbType;
        public MetroFramework.Controls.MetroTextBox txtBatch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox txtRCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtReceipt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtExp;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtReceived;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroTextBox txtQty;
        public MetroFramework.Controls.MetroTextBox txtSupplier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}