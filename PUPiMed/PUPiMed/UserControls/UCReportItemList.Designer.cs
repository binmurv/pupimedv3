namespace PUPiMed.UserControls
{
    partial class UCReportItemList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.icon = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnShow = new MetroFramework.Controls.MetroButton();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.cbItemType = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbManufacturer = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.Image = global::PUPiMed.Properties.Resources.report21;
            this.icon.Location = new System.Drawing.Point(11, 11);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(130, 120);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 14;
            this.icon.TabStop = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(11, 149);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(840, 515);
            this.crystalReportViewer1.TabIndex = 16;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnShow
            // 
            this.btnShow.AccessibleName = "btnadd";
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Highlight = true;
            this.btnShow.Location = new System.Drawing.Point(737, 65);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 29);
            this.btnShow.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseCustomBackColor = true;
            this.btnShow.UseSelectable = true;
            this.btnShow.UseStyleColors = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.Teal;
            this.lblFromDate.Location = new System.Drawing.Point(388, 100);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(116, 29);
            this.lblFromDate.TabIndex = 24;
            this.lblFromDate.Text = "Generic Name :";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(150, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(180, 49);
            this.title.TabIndex = 15;
            this.title.Text = "Item List";
            // 
            // cbItemType
            // 
            this.cbItemType.AccessibleName = "ptype";
            this.cbItemType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbItemType.BackColor = System.Drawing.Color.White;
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.ItemHeight = 23;
            this.cbItemType.Items.AddRange(new object[] {
            "All",
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbItemType.Location = new System.Drawing.Point(510, 30);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(196, 29);
            this.cbItemType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbItemType.TabIndex = 27;
            this.cbItemType.UseCustomBackColor = true;
            this.cbItemType.UseCustomForeColor = true;
            this.cbItemType.UseSelectable = true;
            this.cbItemType.UseStyleColors = true;
            this.cbItemType.SelectedIndexChanged += new System.EventHandler(this.cbItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(415, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Item Type :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGName
            // 
            this.txtGName.AccessibleName = "";
            this.txtGName.BackColor = System.Drawing.Color.White;
            this.txtGName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtGName.Lines = new string[0];
            this.txtGName.Location = new System.Drawing.Point(510, 100);
            this.txtGName.MaxLength = 32767;
            this.txtGName.Name = "txtGName";
            this.txtGName.PasswordChar = '\0';
            this.txtGName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGName.SelectedText = "";
            this.txtGName.Size = new System.Drawing.Size(196, 29);
            this.txtGName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGName.TabIndex = 29;
            this.txtGName.UseCustomBackColor = true;
            this.txtGName.UseSelectable = true;
            this.txtGName.UseStyleColors = true;
            this.txtGName.Click += new System.EventHandler(this.txtGName_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(384, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Manufacturer :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.AccessibleName = "ptype";
            this.cbManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbManufacturer.BackColor = System.Drawing.Color.White;
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.ItemHeight = 23;
            this.cbManufacturer.Items.AddRange(new object[] {
            "All"});
            this.cbManufacturer.Location = new System.Drawing.Point(510, 65);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(196, 29);
            this.cbManufacturer.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer.TabIndex = 31;
            this.cbManufacturer.UseCustomBackColor = true;
            this.cbManufacturer.UseCustomForeColor = true;
            this.cbManufacturer.UseSelectable = true;
            this.cbManufacturer.UseStyleColors = true;
            this.cbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbManufacturer_SelectedIndexChanged);
            // 
            // UCReportItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.title);
            this.Name = "UCReportItemList";
            this.Size = new System.Drawing.Size(863, 676);
            this.Load += new System.EventHandler(this.UCItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroButton btnShow;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label title;
        public MetroFramework.Controls.MetroComboBox cbItemType;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroTextBox txtGName;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroComboBox cbManufacturer;
    }
}
