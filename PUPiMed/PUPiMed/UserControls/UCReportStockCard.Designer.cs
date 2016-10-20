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
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.title = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.reportschedule = new MetroFramework.Controls.MetroTabControl();
            this.tbDaily = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbMonthly = new MetroFramework.Controls.MetroTabPage();
            this.tbQuarterly = new MetroFramework.Controls.MetroTabPage();
            this.tbSemiAnnual = new MetroFramework.Controls.MetroTabPage();
            this.tbAnnual = new MetroFramework.Controls.MetroTabPage();
            this.tbSpecificDate = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.reportschedule.SuspendLayout();
            this.tbDaily.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDate
            // 
            this.dtDate.AllowDrop = true;
            this.dtDate.Checked = false;
            this.dtDate.DisplayFocus = true;
            this.dtDate.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(512, 18);
            this.dtDate.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1916, 1, 1, 0, 0, 0, 0);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(165, 29);
            this.dtDate.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtDate.TabIndex = 32;
            this.dtDate.UseStyleColors = true;
            this.dtDate.Value = new System.DateTime(2016, 9, 30, 0, 0, 0, 0);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 64);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(832, 489);
            this.crystalReportViewer1.TabIndex = 31;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(79, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(208, 42);
            this.title.TabIndex = 30;
            this.title.Text = "Stock Card";
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.Image = global::PUPiMed.Properties.Resources.report21;
            this.icon.Location = new System.Drawing.Point(7, 4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(66, 63);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 29;
            this.icon.TabStop = false;
            // 
            // reportschedule
            // 
            this.reportschedule.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.reportschedule.Controls.Add(this.tbDaily);
            this.reportschedule.Controls.Add(this.tbMonthly);
            this.reportschedule.Controls.Add(this.tbQuarterly);
            this.reportschedule.Controls.Add(this.tbSemiAnnual);
            this.reportschedule.Controls.Add(this.tbAnnual);
            this.reportschedule.Controls.Add(this.tbSpecificDate);
            this.reportschedule.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.reportschedule.Location = new System.Drawing.Point(11, 66);
            this.reportschedule.Name = "reportschedule";
            this.reportschedule.SelectedIndex = 0;
            this.reportschedule.Size = new System.Drawing.Size(840, 607);
            this.reportschedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.reportschedule.TabIndex = 37;
            this.reportschedule.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reportschedule.UseSelectable = true;
            this.reportschedule.UseStyleColors = true;
            // 
            // tbDaily
            // 
            this.tbDaily.BackColor = System.Drawing.Color.White;
            this.tbDaily.Controls.Add(this.label2);
            this.tbDaily.Controls.Add(this.metroButton1);
            this.tbDaily.Controls.Add(this.crystalReportViewer1);
            this.tbDaily.Controls.Add(this.dtDate);
            this.tbDaily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDaily.HorizontalScrollbarBarColor = true;
            this.tbDaily.HorizontalScrollbarHighlightOnWheel = true;
            this.tbDaily.HorizontalScrollbarSize = 10;
            this.tbDaily.Location = new System.Drawing.Point(4, 47);
            this.tbDaily.Name = "tbDaily";
            this.tbDaily.Size = new System.Drawing.Size(832, 556);
            this.tbDaily.TabIndex = 0;
            this.tbDaily.Text = "        Daily        ";
            this.tbDaily.VerticalScrollbarBarColor = true;
            this.tbDaily.VerticalScrollbarHighlightOnWheel = false;
            this.tbDaily.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(405, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pick a Date :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton1
            // 
            this.metroButton1.AccessibleName = "btnadd";
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(698, 18);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(134, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 37;
            this.metroButton1.Text = "Show Report";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // tbMonthly
            // 
            this.tbMonthly.HorizontalScrollbarBarColor = true;
            this.tbMonthly.HorizontalScrollbarHighlightOnWheel = false;
            this.tbMonthly.HorizontalScrollbarSize = 10;
            this.tbMonthly.Location = new System.Drawing.Point(4, 47);
            this.tbMonthly.Name = "tbMonthly";
            this.tbMonthly.Size = new System.Drawing.Size(832, 547);
            this.tbMonthly.TabIndex = 1;
            this.tbMonthly.Text = "   Monthly   ";
            this.tbMonthly.VerticalScrollbarBarColor = true;
            this.tbMonthly.VerticalScrollbarHighlightOnWheel = false;
            this.tbMonthly.VerticalScrollbarSize = 10;
            // 
            // tbQuarterly
            // 
            this.tbQuarterly.HorizontalScrollbarBarColor = true;
            this.tbQuarterly.HorizontalScrollbarHighlightOnWheel = false;
            this.tbQuarterly.HorizontalScrollbarSize = 10;
            this.tbQuarterly.Location = new System.Drawing.Point(4, 47);
            this.tbQuarterly.Name = "tbQuarterly";
            this.tbQuarterly.Size = new System.Drawing.Size(832, 547);
            this.tbQuarterly.TabIndex = 2;
            this.tbQuarterly.Text = "     Quarterly   ";
            this.tbQuarterly.VerticalScrollbarBarColor = true;
            this.tbQuarterly.VerticalScrollbarHighlightOnWheel = false;
            this.tbQuarterly.VerticalScrollbarSize = 10;
            // 
            // tbSemiAnnual
            // 
            this.tbSemiAnnual.HorizontalScrollbarBarColor = true;
            this.tbSemiAnnual.HorizontalScrollbarHighlightOnWheel = false;
            this.tbSemiAnnual.HorizontalScrollbarSize = 10;
            this.tbSemiAnnual.Location = new System.Drawing.Point(4, 47);
            this.tbSemiAnnual.Name = "tbSemiAnnual";
            this.tbSemiAnnual.Size = new System.Drawing.Size(832, 547);
            this.tbSemiAnnual.TabIndex = 3;
            this.tbSemiAnnual.Text = "   Semi-Annually   ";
            this.tbSemiAnnual.VerticalScrollbarBarColor = true;
            this.tbSemiAnnual.VerticalScrollbarHighlightOnWheel = false;
            this.tbSemiAnnual.VerticalScrollbarSize = 10;
            // 
            // tbAnnual
            // 
            this.tbAnnual.HorizontalScrollbarBarColor = true;
            this.tbAnnual.HorizontalScrollbarHighlightOnWheel = false;
            this.tbAnnual.HorizontalScrollbarSize = 10;
            this.tbAnnual.Location = new System.Drawing.Point(4, 47);
            this.tbAnnual.Name = "tbAnnual";
            this.tbAnnual.Size = new System.Drawing.Size(832, 547);
            this.tbAnnual.TabIndex = 4;
            this.tbAnnual.Text = "     Annually     ";
            this.tbAnnual.VerticalScrollbarBarColor = true;
            this.tbAnnual.VerticalScrollbarHighlightOnWheel = false;
            this.tbAnnual.VerticalScrollbarSize = 10;
            // 
            // tbSpecificDate
            // 
            this.tbSpecificDate.HorizontalScrollbarBarColor = true;
            this.tbSpecificDate.HorizontalScrollbarHighlightOnWheel = false;
            this.tbSpecificDate.HorizontalScrollbarSize = 10;
            this.tbSpecificDate.Location = new System.Drawing.Point(4, 47);
            this.tbSpecificDate.Name = "tbSpecificDate";
            this.tbSpecificDate.Size = new System.Drawing.Size(832, 547);
            this.tbSpecificDate.TabIndex = 5;
            this.tbSpecificDate.Text = "   Specific Date   ";
            this.tbSpecificDate.VerticalScrollbarBarColor = true;
            this.tbSpecificDate.VerticalScrollbarHighlightOnWheel = false;
            this.tbSpecificDate.VerticalScrollbarSize = 10;
            // 
            // UCReportStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reportschedule);
            this.Controls.Add(this.title);
            this.Controls.Add(this.icon);
            this.Name = "UCReportStockCard";
            this.Size = new System.Drawing.Size(863, 676);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.reportschedule.ResumeLayout(false);
            this.tbDaily.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroDateTime dtDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label title;
        private MetroFramework.Controls.MetroTabControl reportschedule;
        private MetroFramework.Controls.MetroTabPage tbDaily;
        private MetroFramework.Controls.MetroTabPage tbMonthly;
        private MetroFramework.Controls.MetroTabPage tbQuarterly;
        private MetroFramework.Controls.MetroTabPage tbSemiAnnual;
        private MetroFramework.Controls.MetroTabPage tbAnnual;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage tbSpecificDate;
    }
}
