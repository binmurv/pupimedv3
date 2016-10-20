namespace PUPiMed.UserControls
{
    partial class UCReportStockCard
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
            this.title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.btnSpecificShow = new MetroFramework.Controls.MetroButton();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(123, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(282, 58);
            this.title.TabIndex = 30;
            this.title.Text = "Stock Card";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(130, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 58;
            this.label7.Text = "From Date :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(407, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 27);
            this.label8.TabIndex = 57;
            this.label8.Text = "To Date :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtTo
            // 
            this.dtTo.AllowDrop = true;
            this.dtTo.Checked = false;
            this.dtTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTo.DisplayFocus = true;
            this.dtTo.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(494, 100);
            this.dtTo.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1916, 1, 1, 0, 0, 0, 0);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(165, 29);
            this.dtTo.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtTo.TabIndex = 56;
            this.dtTo.UseStyleColors = true;
            this.dtTo.Value = new System.DateTime(2016, 9, 30, 0, 0, 0, 0);
            // 
            // dtFrom
            // 
            this.dtFrom.AllowDrop = true;
            this.dtFrom.Checked = false;
            this.dtFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFrom.DisplayFocus = true;
            this.dtFrom.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(225, 100);
            this.dtFrom.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1916, 1, 1, 0, 0, 0, 0);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(165, 29);
            this.dtFrom.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtFrom.TabIndex = 55;
            this.dtFrom.UseStyleColors = true;
            this.dtFrom.Value = new System.DateTime(2016, 9, 30, 0, 0, 0, 0);
            // 
            // btnSpecificShow
            // 
            this.btnSpecificShow.AccessibleName = "btnadd";
            this.btnSpecificShow.BackColor = System.Drawing.Color.White;
            this.btnSpecificShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpecificShow.Highlight = true;
            this.btnSpecificShow.Location = new System.Drawing.Point(696, 100);
            this.btnSpecificShow.Name = "btnSpecificShow";
            this.btnSpecificShow.Size = new System.Drawing.Size(134, 29);
            this.btnSpecificShow.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSpecificShow.TabIndex = 54;
            this.btnSpecificShow.Text = "Show Report";
            this.btnSpecificShow.UseCustomBackColor = true;
            this.btnSpecificShow.UseSelectable = true;
            this.btnSpecificShow.UseStyleColors = true;
            this.btnSpecificShow.Click += new System.EventHandler(this.btnSpecificShow_Click);
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = -1;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Location = new System.Drawing.Point(17, 149);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(832, 513);
            this.crystalReportViewer4.TabIndex = 53;
            this.crystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.Image = global::PUPiMed.Properties.Resources.darkcombo_chart_96px;
            this.icon.Location = new System.Drawing.Point(17, 21);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(104, 110);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 29;
            this.icon.TabStop = false;
            // 
            // UCReportStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSpecificShow);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.crystalReportViewer4);
            this.Controls.Add(this.dtFrom);
            this.Name = "UCReportStockCard";
            this.Size = new System.Drawing.Size(863, 676);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public MetroFramework.Controls.MetroDateTime dtTo;
        public MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroButton btnSpecificShow;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
    }
}
