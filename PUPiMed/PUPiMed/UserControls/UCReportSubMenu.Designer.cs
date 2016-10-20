namespace PUPiMed.UserControls
{
    partial class UCReportSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReportSubMenu));
            this.tabList = new MetroFramework.Controls.MetroTile();
            this.tabDistrib = new MetroFramework.Controls.MetroTile();
            this.tabReceive = new MetroFramework.Controls.MetroTile();
            this.tabDTR = new MetroFramework.Controls.MetroTile();
            this.tabStockCard = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.tabList.SuspendLayout();
            this.tabDistrib.SuspendLayout();
            this.tabReceive.SuspendLayout();
            this.tabDTR.SuspendLayout();
            this.tabStockCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabList
            // 
            this.tabList.ActiveControl = null;
            this.tabList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabList.Controls.Add(this.pictureBox2);
            this.tabList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabList.ForeColor = System.Drawing.Color.White;
            this.tabList.Location = new System.Drawing.Point(2, 247);
            this.tabList.Name = "tabList";
            this.tabList.Size = new System.Drawing.Size(233, 62);
            this.tabList.TabIndex = 4;
            this.tabList.Text = "               List of Items";
            this.tabList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabList.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabList.UseCustomBackColor = true;
            this.tabList.UseCustomForeColor = true;
            this.tabList.UseSelectable = true;
            this.tabList.UseStyleColors = true;
            this.tabList.Click += new System.EventHandler(this.tabList_Click);
            this.tabList.MouseEnter += new System.EventHandler(this.tabStockCard_MouseEnter);
            this.tabList.MouseLeave += new System.EventHandler(this.tabSupply_MouseLeave);
            // 
            // tabDistrib
            // 
            this.tabDistrib.ActiveControl = null;
            this.tabDistrib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabDistrib.BackColor = System.Drawing.Color.Teal;
            this.tabDistrib.Controls.Add(this.pictureBox1);
            this.tabDistrib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDistrib.ForeColor = System.Drawing.Color.White;
            this.tabDistrib.Location = new System.Drawing.Point(2, 186);
            this.tabDistrib.Name = "tabDistrib";
            this.tabDistrib.Size = new System.Drawing.Size(233, 62);
            this.tabDistrib.TabIndex = 3;
            this.tabDistrib.Text = "               Item Distribution";
            this.tabDistrib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabDistrib.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabDistrib.UseCustomBackColor = true;
            this.tabDistrib.UseCustomForeColor = true;
            this.tabDistrib.UseSelectable = true;
            this.tabDistrib.UseStyleColors = true;
            this.tabDistrib.Click += new System.EventHandler(this.tabDistrib_Click);
            this.tabDistrib.MouseEnter += new System.EventHandler(this.tabStockCard_MouseEnter);
            this.tabDistrib.MouseLeave += new System.EventHandler(this.tabSupply_MouseLeave);
            // 
            // tabReceive
            // 
            this.tabReceive.ActiveControl = null;
            this.tabReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabReceive.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabReceive.Controls.Add(this.icon1);
            this.tabReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabReceive.ForeColor = System.Drawing.Color.White;
            this.tabReceive.Location = new System.Drawing.Point(2, 124);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.Size = new System.Drawing.Size(233, 62);
            this.tabReceive.TabIndex = 2;
            this.tabReceive.Text = "               Receive Inventory";
            this.tabReceive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabReceive.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabReceive.UseCustomBackColor = true;
            this.tabReceive.UseCustomForeColor = true;
            this.tabReceive.UseSelectable = true;
            this.tabReceive.UseStyleColors = true;
            this.tabReceive.Click += new System.EventHandler(this.tabReceive_Click);
            this.tabReceive.MouseEnter += new System.EventHandler(this.tabStockCard_MouseEnter);
            this.tabReceive.MouseLeave += new System.EventHandler(this.tabSupply_MouseLeave);
            // 
            // tabDTR
            // 
            this.tabDTR.ActiveControl = null;
            this.tabDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabDTR.BackColor = System.Drawing.Color.Teal;
            this.tabDTR.Controls.Add(this.pictureBox3);
            this.tabDTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDTR.ForeColor = System.Drawing.Color.White;
            this.tabDTR.Location = new System.Drawing.Point(2, 62);
            this.tabDTR.Name = "tabDTR";
            this.tabDTR.Size = new System.Drawing.Size(233, 62);
            this.tabDTR.TabIndex = 1;
            this.tabDTR.Text = "               Daily Treatment Record";
            this.tabDTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabDTR.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabDTR.UseCustomBackColor = true;
            this.tabDTR.UseCustomForeColor = true;
            this.tabDTR.UseSelectable = true;
            this.tabDTR.UseStyleColors = true;
            this.tabDTR.Click += new System.EventHandler(this.tabDTR_Click);
            this.tabDTR.MouseEnter += new System.EventHandler(this.tabStockCard_MouseEnter);
            this.tabDTR.MouseLeave += new System.EventHandler(this.tabSupply_MouseLeave);
            // 
            // tabStockCard
            // 
            this.tabStockCard.ActiveControl = null;
            this.tabStockCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabStockCard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabStockCard.Controls.Add(this.pictureBox4);
            this.tabStockCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabStockCard.ForeColor = System.Drawing.Color.White;
            this.tabStockCard.Location = new System.Drawing.Point(2, 0);
            this.tabStockCard.Name = "tabStockCard";
            this.tabStockCard.Size = new System.Drawing.Size(233, 62);
            this.tabStockCard.TabIndex = 0;
            this.tabStockCard.Text = "               Stock Card";
            this.tabStockCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabStockCard.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabStockCard.UseCustomBackColor = true;
            this.tabStockCard.UseCustomForeColor = true;
            this.tabStockCard.UseSelectable = true;
            this.tabStockCard.UseStyleColors = true;
            this.tabStockCard.Click += new System.EventHandler(this.tabStockCard_Click);
            this.tabStockCard.MouseEnter += new System.EventHandler(this.tabStockCard_MouseEnter);
            this.tabStockCard.MouseLeave += new System.EventHandler(this.tabSupply_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(22, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 45);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.tabDTR_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(22, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 42);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.tabStockCard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(21, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 45);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.tabList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(25, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.tabDistrib_Click);
            // 
            // icon1
            // 
            this.icon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.icon1.BackColor = System.Drawing.Color.Transparent;
            this.icon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon1.BackgroundImage")));
            this.icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon1.Location = new System.Drawing.Point(17, 2);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(47, 48);
            this.icon1.TabIndex = 0;
            this.icon1.TabStop = false;
            this.icon1.Click += new System.EventHandler(this.tabReceive_Click);
            // 
            // UCReportSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabDTR);
            this.Controls.Add(this.tabStockCard);
            this.Controls.Add(this.tabList);
            this.Controls.Add(this.tabDistrib);
            this.Controls.Add(this.tabReceive);
            this.Name = "UCReportSubMenu";
            this.Size = new System.Drawing.Size(235, 309);
            this.Load += new System.EventHandler(this.UCReportSubMenu_Load);
            this.MouseEnter += new System.EventHandler(this.UCReportSubMenu_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCReportSubMenu_MouseLeave);
            this.tabList.ResumeLayout(false);
            this.tabDistrib.ResumeLayout(false);
            this.tabReceive.ResumeLayout(false);
            this.tabDTR.ResumeLayout(false);
            this.tabStockCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tabList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile tabDistrib;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile tabReceive;
        private System.Windows.Forms.PictureBox icon1;
        private MetroFramework.Controls.MetroTile tabDTR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTile tabStockCard;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
