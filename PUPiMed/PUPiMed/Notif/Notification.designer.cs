namespace ToastNotifications
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.labelBody = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.icon_stock = new System.Windows.Forms.PictureBox();
            this.icon_expired = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_expired)).BeginInit();
            this.SuspendLayout();
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // labelBody
            // 
            this.labelBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBody.AutoEllipsis = true;
            this.labelBody.BackColor = System.Drawing.Color.Transparent;
            this.labelBody.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.ForeColor = System.Drawing.Color.Red;
            this.labelBody.Location = new System.Drawing.Point(64, 30);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(211, 58);
            this.labelBody.TabIndex = 0;
            this.labelBody.Text = "Body goes here and here and here and here and here and here and here and here and" +
    " here";
            this.labelBody.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBody.Click += new System.EventHandler(this.labelRO_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Red;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "title goes here";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // icon_stock
            // 
            this.icon_stock.BackgroundImage = global::PUPiMed.Properties.Resources.stocksshits;
            this.icon_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_stock.Location = new System.Drawing.Point(11, 29);
            this.icon_stock.Name = "icon_stock";
            this.icon_stock.Size = new System.Drawing.Size(47, 47);
            this.icon_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_stock.TabIndex = 1;
            this.icon_stock.TabStop = false;
            // 
            // icon_expired
            // 
            this.icon_expired.BackgroundImage = global::PUPiMed.Properties.Resources.expired;
            this.icon_expired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_expired.Location = new System.Drawing.Point(11, 29);
            this.icon_expired.Name = "icon_expired";
            this.icon_expired.Size = new System.Drawing.Size(47, 47);
            this.icon_expired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_expired.TabIndex = 2;
            this.icon_expired.TabStop = false;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(283, 93);
            this.ControlBox = false;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.icon_expired);
            this.Controls.Add(this.icon_stock);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Notification";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Notification_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notification_FormClosed);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.Click += new System.EventHandler(this.Notification_Click);
            ((System.ComponentModel.ISupportInitialize)(this.icon_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_expired)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.PictureBox icon_expired;
        public System.Windows.Forms.PictureBox icon_stock;
    }
}