namespace PUPiMed.UserControls
{
    partial class UCReportReceive
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
            this.icon = new System.Windows.Forms.PictureBox();
            this.reportschedule = new MetroFramework.Controls.MetroTabControl();
            this.tbQuarterly = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonth = new MetroFramework.Controls.MetroComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbSemiAnnual = new MetroFramework.Controls.MetroTabPage();
            this.btnShowSemi = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSemiYear = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSemiMonth = new MetroFramework.Controls.MetroComboBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbAnnual = new MetroFramework.Controls.MetroTabPage();
            this.btnShowAnnual = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAnnualYear = new MetroFramework.Controls.MetroComboBox();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbSpecificDate = new MetroFramework.Controls.MetroTabPage();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.btnSpecificShow = new MetroFramework.Controls.MetroButton();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.reportschedule.SuspendLayout();
            this.tbQuarterly.SuspendLayout();
            this.tbSemiAnnual.SuspendLayout();
            this.tbAnnual.SuspendLayout();
            this.tbSpecificDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.Location = new System.Drawing.Point(77, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(282, 42);
            this.title.TabIndex = 22;
            this.title.Text = "Received Items";
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.Image = global::PUPiMed.Properties.Resources.report21;
            this.icon.Location = new System.Drawing.Point(5, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(66, 63);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 21;
            this.icon.TabStop = false;
            // 
            // reportschedule
            // 
            this.reportschedule.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.reportschedule.Controls.Add(this.tbQuarterly);
            this.reportschedule.Controls.Add(this.tbSemiAnnual);
            this.reportschedule.Controls.Add(this.tbAnnual);
            this.reportschedule.Controls.Add(this.tbSpecificDate);
            this.reportschedule.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.reportschedule.Location = new System.Drawing.Point(11, 66);
            this.reportschedule.Name = "reportschedule";
            this.reportschedule.SelectedIndex = 0;
            this.reportschedule.Size = new System.Drawing.Size(840, 610);
            this.reportschedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.reportschedule.TabIndex = 38;
            this.reportschedule.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reportschedule.UseSelectable = true;
            this.reportschedule.UseStyleColors = true;
            // 
            // tbQuarterly
            // 
            this.tbQuarterly.Controls.Add(this.metroButton1);
            this.tbQuarterly.Controls.Add(this.label1);
            this.tbQuarterly.Controls.Add(this.cbYear);
            this.tbQuarterly.Controls.Add(this.label2);
            this.tbQuarterly.Controls.Add(this.cbMonth);
            this.tbQuarterly.Controls.Add(this.crystalReportViewer1);
            this.tbQuarterly.HorizontalScrollbarBarColor = true;
            this.tbQuarterly.HorizontalScrollbarHighlightOnWheel = false;
            this.tbQuarterly.HorizontalScrollbarSize = 10;
            this.tbQuarterly.Location = new System.Drawing.Point(4, 47);
            this.tbQuarterly.Name = "tbQuarterly";
            this.tbQuarterly.Size = new System.Drawing.Size(832, 559);
            this.tbQuarterly.TabIndex = 2;
            this.tbQuarterly.Text = "           Quarterly          ";
            this.tbQuarterly.VerticalScrollbarBarColor = true;
            this.tbQuarterly.VerticalScrollbarHighlightOnWheel = false;
            this.tbQuarterly.VerticalScrollbarSize = 10;
            this.tbQuarterly.Click += new System.EventHandler(this.tbQuarterly_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.AccessibleName = "btnadd";
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(612, 16);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(134, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 42;
            this.metroButton1.Text = "Show Report";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(358, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Year :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.ItemHeight = 23;
            this.cbYear.Location = new System.Drawing.Point(409, 16);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(166, 29);
            this.cbYear.TabIndex = 40;
            this.cbYear.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(95, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Month :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ItemHeight = 23;
            this.cbMonth.Items.AddRange(new object[] {
            "Quarter 1 (Jan-Mar)",
            "Quarter 2 (Apr-Jun)",
            "Quarter 3 (Jul-Sep)",
            "Quarter 4 (Oct-Dec)"});
            this.cbMonth.Location = new System.Drawing.Point(160, 16);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(166, 29);
            this.cbMonth.TabIndex = 3;
            this.cbMonth.UseSelectable = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 64);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(832, 489);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbSemiAnnual
            // 
            this.tbSemiAnnual.Controls.Add(this.btnShowSemi);
            this.tbSemiAnnual.Controls.Add(this.label3);
            this.tbSemiAnnual.Controls.Add(this.cbSemiYear);
            this.tbSemiAnnual.Controls.Add(this.label4);
            this.tbSemiAnnual.Controls.Add(this.cbSemiMonth);
            this.tbSemiAnnual.Controls.Add(this.crystalReportViewer2);
            this.tbSemiAnnual.HorizontalScrollbarBarColor = true;
            this.tbSemiAnnual.HorizontalScrollbarHighlightOnWheel = false;
            this.tbSemiAnnual.HorizontalScrollbarSize = 10;
            this.tbSemiAnnual.Location = new System.Drawing.Point(4, 47);
            this.tbSemiAnnual.Name = "tbSemiAnnual";
            this.tbSemiAnnual.Size = new System.Drawing.Size(832, 559);
            this.tbSemiAnnual.TabIndex = 3;
            this.tbSemiAnnual.Text = "        Semi-Annually        ";
            this.tbSemiAnnual.VerticalScrollbarBarColor = true;
            this.tbSemiAnnual.VerticalScrollbarHighlightOnWheel = false;
            this.tbSemiAnnual.VerticalScrollbarSize = 10;
            // 
            // btnShowSemi
            // 
            this.btnShowSemi.AccessibleName = "btnadd";
            this.btnShowSemi.BackColor = System.Drawing.Color.White;
            this.btnShowSemi.Highlight = true;
            this.btnShowSemi.Location = new System.Drawing.Point(612, 16);
            this.btnShowSemi.Name = "btnShowSemi";
            this.btnShowSemi.Size = new System.Drawing.Size(134, 29);
            this.btnShowSemi.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnShowSemi.TabIndex = 48;
            this.btnShowSemi.Text = "Show Report";
            this.btnShowSemi.UseCustomBackColor = true;
            this.btnShowSemi.UseSelectable = true;
            this.btnShowSemi.UseStyleColors = true;
            this.btnShowSemi.Click += new System.EventHandler(this.btnShowSemi_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(358, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Year :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSemiYear
            // 
            this.cbSemiYear.FormattingEnabled = true;
            this.cbSemiYear.ItemHeight = 23;
            this.cbSemiYear.Location = new System.Drawing.Point(409, 16);
            this.cbSemiYear.Name = "cbSemiYear";
            this.cbSemiYear.Size = new System.Drawing.Size(166, 29);
            this.cbSemiYear.TabIndex = 46;
            this.cbSemiYear.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(95, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Month :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSemiMonth
            // 
            this.cbSemiMonth.FormattingEnabled = true;
            this.cbSemiMonth.ItemHeight = 23;
            this.cbSemiMonth.Items.AddRange(new object[] {
            "1st Half (Jan-Jun)",
            "2nd Half (July-Dec)"});
            this.cbSemiMonth.Location = new System.Drawing.Point(160, 16);
            this.cbSemiMonth.Name = "cbSemiMonth";
            this.cbSemiMonth.Size = new System.Drawing.Size(166, 29);
            this.cbSemiMonth.TabIndex = 44;
            this.cbSemiMonth.UseSelectable = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 64);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(832, 489);
            this.crystalReportViewer2.TabIndex = 43;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbAnnual
            // 
            this.tbAnnual.Controls.Add(this.btnShowAnnual);
            this.tbAnnual.Controls.Add(this.label5);
            this.tbAnnual.Controls.Add(this.cbAnnualYear);
            this.tbAnnual.Controls.Add(this.crystalReportViewer3);
            this.tbAnnual.HorizontalScrollbarBarColor = true;
            this.tbAnnual.HorizontalScrollbarHighlightOnWheel = false;
            this.tbAnnual.HorizontalScrollbarSize = 10;
            this.tbAnnual.Location = new System.Drawing.Point(4, 47);
            this.tbAnnual.Name = "tbAnnual";
            this.tbAnnual.Size = new System.Drawing.Size(832, 559);
            this.tbAnnual.TabIndex = 4;
            this.tbAnnual.Text = "            Annually            ";
            this.tbAnnual.VerticalScrollbarBarColor = true;
            this.tbAnnual.VerticalScrollbarHighlightOnWheel = false;
            this.tbAnnual.VerticalScrollbarSize = 10;
            // 
            // btnShowAnnual
            // 
            this.btnShowAnnual.AccessibleName = "btnadd";
            this.btnShowAnnual.BackColor = System.Drawing.Color.White;
            this.btnShowAnnual.Highlight = true;
            this.btnShowAnnual.Location = new System.Drawing.Point(460, 16);
            this.btnShowAnnual.Name = "btnShowAnnual";
            this.btnShowAnnual.Size = new System.Drawing.Size(134, 29);
            this.btnShowAnnual.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnShowAnnual.TabIndex = 52;
            this.btnShowAnnual.Text = "Show Report";
            this.btnShowAnnual.UseCustomBackColor = true;
            this.btnShowAnnual.UseSelectable = true;
            this.btnShowAnnual.UseStyleColors = true;
            this.btnShowAnnual.Click += new System.EventHandler(this.btnShowAnnual_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(206, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Year :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAnnualYear
            // 
            this.cbAnnualYear.FormattingEnabled = true;
            this.cbAnnualYear.ItemHeight = 23;
            this.cbAnnualYear.Location = new System.Drawing.Point(257, 16);
            this.cbAnnualYear.Name = "cbAnnualYear";
            this.cbAnnualYear.Size = new System.Drawing.Size(166, 29);
            this.cbAnnualYear.TabIndex = 50;
            this.cbAnnualYear.UseSelectable = true;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 64);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(832, 489);
            this.crystalReportViewer3.TabIndex = 49;
            this.crystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbSpecificDate
            // 
            this.tbSpecificDate.Controls.Add(this.lblFromDate);
            this.tbSpecificDate.Controls.Add(this.label6);
            this.tbSpecificDate.Controls.Add(this.dtTo);
            this.tbSpecificDate.Controls.Add(this.dtFrom);
            this.tbSpecificDate.Controls.Add(this.btnSpecificShow);
            this.tbSpecificDate.Controls.Add(this.crystalReportViewer4);
            this.tbSpecificDate.HorizontalScrollbarBarColor = true;
            this.tbSpecificDate.HorizontalScrollbarHighlightOnWheel = false;
            this.tbSpecificDate.HorizontalScrollbarSize = 10;
            this.tbSpecificDate.Location = new System.Drawing.Point(4, 47);
            this.tbSpecificDate.Name = "tbSpecificDate";
            this.tbSpecificDate.Size = new System.Drawing.Size(832, 559);
            this.tbSpecificDate.TabIndex = 5;
            this.tbSpecificDate.Text = "          Specific Date          ";
            this.tbSpecificDate.VerticalScrollbarBarColor = true;
            this.tbSpecificDate.VerticalScrollbarHighlightOnWheel = false;
            this.tbSpecificDate.VerticalScrollbarSize = 10;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFromDate.BackColor = System.Drawing.Color.White;
            this.lblFromDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.Teal;
            this.lblFromDate.Location = new System.Drawing.Point(60, 14);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(89, 27);
            this.lblFromDate.TabIndex = 58;
            this.lblFromDate.Text = "From Date :";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(337, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 57;
            this.label6.Text = "To Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtTo
            // 
            this.dtTo.AllowDrop = true;
            this.dtTo.Checked = false;
            this.dtTo.DisplayFocus = true;
            this.dtTo.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(424, 14);
            this.dtTo.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1916, 1, 1, 0, 0, 0, 0);
            this.dtTo.MinimumSize = new System.Drawing.Size(4, 29);
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
            this.dtFrom.DisplayFocus = true;
            this.dtFrom.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(155, 14);
            this.dtFrom.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1916, 1, 1, 0, 0, 0, 0);
            this.dtFrom.MinimumSize = new System.Drawing.Size(4, 29);
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
            this.btnSpecificShow.Highlight = true;
            this.btnSpecificShow.Location = new System.Drawing.Point(626, 14);
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
            this.crystalReportViewer4.Location = new System.Drawing.Point(0, 64);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(832, 489);
            this.crystalReportViewer4.TabIndex = 53;
            this.crystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // UCReportReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reportschedule);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.title);
            this.Name = "UCReportReceive";
            this.Size = new System.Drawing.Size(863, 676);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.reportschedule.ResumeLayout(false);
            this.tbQuarterly.ResumeLayout(false);
            this.tbSemiAnnual.ResumeLayout(false);
            this.tbAnnual.ResumeLayout(false);
            this.tbSpecificDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label title;
        private MetroFramework.Controls.MetroTabControl reportschedule;
        private MetroFramework.Controls.MetroTabPage tbQuarterly;
        private MetroFramework.Controls.MetroTabPage tbSemiAnnual;
        private MetroFramework.Controls.MetroTabPage tbAnnual;
        private MetroFramework.Controls.MetroTabPage tbSpecificDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroComboBox cbMonth;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnShowSemi;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbSemiYear;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cbSemiMonth;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private MetroFramework.Controls.MetroButton btnShowAnnual;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbAnnualYear;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private MetroFramework.Controls.MetroButton btnSpecificShow;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label label6;
        public MetroFramework.Controls.MetroDateTime dtTo;
        public MetroFramework.Controls.MetroDateTime dtFrom;
    }
}
