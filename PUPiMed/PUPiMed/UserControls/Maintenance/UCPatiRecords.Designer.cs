namespace PUPiMed
{
    partial class UCRecords
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblResult = new MetroFramework.Controls.MetroLabel();
            this.rbEquipment = new MetroFramework.Controls.MetroRadioButton();
            this.rbSupply = new MetroFramework.Controls.MetroRadioButton();
            this.rbMedicine = new MetroFramework.Controls.MetroRadioButton();
            this.rbAll = new MetroFramework.Controls.MetroRadioButton();
            this.cbFilter = new MetroFramework.Controls.MetroComboBox();
            this.title = new System.Windows.Forms.Label();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.lblAdvanced = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(746, 112);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(105, 19);
            this.lblResult.TabIndex = 128;
            this.lblResult.Text = "No results found";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbEquipment
            // 
            this.rbEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEquipment.AutoSize = true;
            this.rbEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEquipment.DisplayFocus = true;
            this.rbEquipment.Location = new System.Drawing.Point(793, 56);
            this.rbEquipment.Name = "rbEquipment";
            this.rbEquipment.Size = new System.Drawing.Size(59, 15);
            this.rbEquipment.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbEquipment.TabIndex = 126;
            this.rbEquipment.Text = "Admin";
            this.rbEquipment.UseCustomForeColor = true;
            this.rbEquipment.UseSelectable = true;
            this.rbEquipment.UseStyleColors = true;
            // 
            // rbSupply
            // 
            this.rbSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSupply.AutoSize = true;
            this.rbSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSupply.DisplayFocus = true;
            this.rbSupply.Location = new System.Drawing.Point(691, 56);
            this.rbSupply.Name = "rbSupply";
            this.rbSupply.Size = new System.Drawing.Size(61, 15);
            this.rbSupply.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbSupply.TabIndex = 124;
            this.rbSupply.Text = "Faculty";
            this.rbSupply.UseCustomForeColor = true;
            this.rbSupply.UseSelectable = true;
            this.rbSupply.UseStyleColors = true;
            // 
            // rbMedicine
            // 
            this.rbMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMedicine.AutoSize = true;
            this.rbMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedicine.DisplayFocus = true;
            this.rbMedicine.Location = new System.Drawing.Point(588, 56);
            this.rbMedicine.Name = "rbMedicine";
            this.rbMedicine.Size = new System.Drawing.Size(64, 15);
            this.rbMedicine.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbMedicine.TabIndex = 123;
            this.rbMedicine.Text = "Student";
            this.rbMedicine.UseCustomForeColor = true;
            this.rbMedicine.UseSelectable = true;
            this.rbMedicine.UseStyleColors = true;
            // 
            // rbAll
            // 
            this.rbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAll.DisplayFocus = true;
            this.rbAll.Location = new System.Drawing.Point(512, 56);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(37, 15);
            this.rbAll.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbAll.TabIndex = 122;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseCustomForeColor = true;
            this.rbAll.UseSelectable = true;
            this.rbAll.UseStyleColors = true;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.DisplayFocus = true;
            this.cbFilter.DisplayMember = "0";
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ItemHeight = 23;
            this.cbFilter.Items.AddRange(new object[] {
            "Show All",
            "Item Name",
            "Generic Name",
            "Manufacturer"});
            this.cbFilter.Location = new System.Drawing.Point(512, 22);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(131, 29);
            this.cbFilter.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbFilter.TabIndex = 120;
            this.cbFilter.UseSelectable = true;
            this.cbFilter.UseStyleColors = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.title.ForeColor = System.Drawing.Color.Teal;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(150, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(179, 49);
            this.title.TabIndex = 127;
            this.title.Text = "Records";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFilter.Icon = global::PUPiMed.Properties.Resources.eto_na_talaga;
            this.txtFilter.IconRight = true;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(649, 22);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Search";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(203, 29);
            this.txtFilter.TabIndex = 121;
            this.txtFilter.UseCustomBackColor = true;
            this.txtFilter.UseSelectable = true;
            // 
            // icon
            // 
            this.icon.Image = global::PUPiMed.Properties.Resources.savAEDwqfedark1;
            this.icon.Location = new System.Drawing.Point(11, 11);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(130, 120);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 125;
            this.icon.TabStop = false;
            // 
            // grid
            // 
            this.grid.AccessibleName = "";
            this.grid.AllowDrop = true;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CausesValidation = false;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 28;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(11, 143);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid.RowTemplate.DividerHeight = 1;
            this.grid.RowTemplate.ErrorText = "n/a";
            this.grid.RowTemplate.Height = 30;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowCellErrors = false;
            this.grid.ShowEditingIcon = false;
            this.grid.ShowRowErrors = false;
            this.grid.Size = new System.Drawing.Size(841, 522);
            this.grid.StandardTab = true;
            this.grid.Style = MetroFramework.MetroColorStyle.Teal;
            this.grid.TabIndex = 129;
            this.grid.UseStyleColors = true;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::PUPiMed.Properties.Resources.refresh_icon_png_2;
            this.refresh.Location = new System.Drawing.Point(721, 79);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(27, 15);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 162;
            this.refresh.TabStop = false;
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdvanced.AutoSize = true;
            this.lblAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdvanced.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAdvanced.ForeColor = System.Drawing.Color.Navy;
            this.lblAdvanced.Location = new System.Drawing.Point(752, 79);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(100, 15);
            this.lblAdvanced.TabIndex = 161;
            this.lblAdvanced.Text = "Advanced Options";
            this.lblAdvanced.UseCustomBackColor = true;
            this.lblAdvanced.UseCustomForeColor = true;
            this.lblAdvanced.UseStyleColors = true;
            // 
            // UCRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.lblAdvanced);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rbEquipment);
            this.Controls.Add(this.rbSupply);
            this.Controls.Add(this.rbMedicine);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.title);
            this.Name = "UCRecords";
            this.Size = new System.Drawing.Size(863, 676);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblResult;
        private MetroFramework.Controls.MetroRadioButton rbEquipment;
        private MetroFramework.Controls.MetroRadioButton rbSupply;
        private MetroFramework.Controls.MetroRadioButton rbMedicine;
        private MetroFramework.Controls.MetroRadioButton rbAll;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private MetroFramework.Controls.MetroComboBox cbFilter;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label title;
        public MetroFramework.Controls.MetroGrid grid;
        private System.Windows.Forms.PictureBox refresh;
        private MetroFramework.Controls.MetroLabel lblAdvanced;
    }
}
