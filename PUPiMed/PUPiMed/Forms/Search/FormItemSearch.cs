using MetroFramework.Forms;
using System;
using PUPiMed.UserControls;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace PUPiMed
{
    public partial class FormItemSearch : MetroForm
    {
        private int itemType = 0;
        private UCItem uCItem;
        private UCItemDistribution uCItemDistribution;
        private UCItemInventory uCItemInventory;

        List<String> listManuCode;
        string strType = "";

        public FormItemSearch()
        {
            InitializeComponent();
            loadManufacturer();
            cbForm.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
        }
        
        public FormItemSearch(UCItemDistribution uCItemDistribution) : this()
        {
            this.uCItemDistribution = uCItemDistribution;
        }

        public FormItemSearch(UCItem uCItem, int itemType) : this()
        {
            this.uCItem = uCItem;
            this.itemType = itemType;
            this.cbType.SelectedIndex = itemType;
            this.cbType.Enabled = false;
        }

        public FormItemSearch(UCItemInventory uCItemInventory) : this()
        {
            this.uCItemInventory = uCItemInventory;
        }

        private void metroLabel5_EnabledChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = (sender as Control).Enabled? Color.White : Color.FromArgb(224,224,224);
        }

        private void chkManu_CheckedChanged(object sender, EventArgs e)
        {
            cbManufacturer.Enabled = chkManu.Checked;
        }

        public void loadManufacturer()
        {
            string strManu = "";
            
            switch (cbType.SelectedIndex)
            {
                case 0:
                    strManu = "";
                    break;
                case 1:
                    strManu = " AND intManuType=1 ";
                    break;
                case 2:
                    strManu = " AND intManuType=2 ";
                    break;
                case 3:
                    strManu = " AND intManuType=3 ";
                    break;
            }
            if (Program.fillComboBox(cbManufacturer, "SELECT * FROM tblManufacturer WHERE boolManuDeleted = false "+strManu+";", out listManuCode))
            {
                cbManufacturer.PromptText = "Please add a new Manufacturer";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query =
                " AND Code in (SELECT strItemCode from tblItem left join tbladditional on strItemCode=strAddiItemCode WHERE " +
                 strType +
                " strItemName LIKE '" + txtName.Text + "%' " +
                " AND strItemCode LIKE '" + txtCode.Text + "%' " +
                " AND strItemGeneric LIKE '" + txtGen.Text + "%' " +
                (chkManu.Checked ? (" AND strItemManuCode LIKE '" + listManuCode[cbManufacturer.SelectedIndex].ToString() + "%'  ") : "") +
                (!string.IsNullOrEmpty(txtDosage.Text) ? (" AND strAddiDosage LIKE '" + txtDosage.Text + "%'  ") : "") +
                (cbForm.Enabled ? (string.IsNullOrEmpty(cbForm.Text)?"":(" AND strAddiForm LIKE '" + cbForm.Text + "%' ")) : "") +
                (chkMin.Checked ? (" AND intItemMin = " + txtMin.Text) : "") +
                (chkMax.Checked ? (" AND intItemMax = " + txtMax.Text) : "") +
                "); ";
            
            
            if (uCItem != null)
            {
                this.uCItem.query += query;
                this.uCItem.updateTable();
                this.Dispose();
            }
            if (uCItemDistribution != null)
            {
                this.uCItemDistribution.query += query;
                this.uCItemDistribution.updateTable();
                this.Dispose();
            }
            if(uCItemInventory != null)
            {
                this.uCItemInventory.query += query;
                //MessageBox.Show(uCItemInventory.query);
                this.uCItemInventory.updateTable(this.uCItemInventory.query, this.uCItemInventory.grid);
                this.Dispose();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemType = cbType.SelectedIndex;
            switch (itemType)
            {
                case 0:
                    strType = " ";
                    break;
                case 1:
                    strType = "  intItemType=1 AND";
                    txtDosage.Enabled = true;
                    cbForm.Enabled = true;
                    loadManufacturer();
                    break;
                case 2:
                    strType = "  intItemType=2 AND ";
                    txtDosage.Enabled = true;
                    cbForm.Enabled = true;
                    loadManufacturer();
                    break;
                case 3:
                    strType = "  intItemType=3 AND ";
                    txtDosage.Enabled = false;
                    cbForm.Enabled = false;
                    loadManufacturer();
                    break;

            }
            
        }

        private void chkMin_CheckedChanged(object sender, EventArgs e)
        {
            txtMin.Enabled = chkMin.Checked;
        }

        private void chkMax_CheckedChanged(object sender, EventArgs e)
        {
            txtMax.Enabled = chkMax.Checked;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
