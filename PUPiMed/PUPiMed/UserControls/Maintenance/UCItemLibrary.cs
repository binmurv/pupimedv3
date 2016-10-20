using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCItemLibrary : UserControl
    {
        string strSearch = "SELECT CASE WHEN INTITEMTYPE = 1 THEN 'Medicine' WHEN INTITEMTYPE = 2 THEN 'Supply' ELSE 'Equipment' END AS Type," +
                                " strItemCode AS 'Item Code', strItemName AS 'Item Name', strItemGeneric AS 'Generic Name', b.strManuName AS 'Manufacturer', intItemMin AS 'Min', intItemMax as 'Max' " +
                                " FROM tblItem, tblManufacturer b " +
                                " WHERE (boolItemDeleted=0 AND strItemManuCode=b.strManuCode);"
            , strType, strFilter;
        public UCItemLibrary()
        {
            InitializeComponent();
            updateTable();
            cbFilter.SelectedIndex = 0;
        }

        public void updateTable()
        {
            using (LoginNew.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand(strSearch, LoginNew.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                grid.DataSource = dt;
                            }
                        }
                    }
                }
            }
            
            setResult();
        }

        private void setResult()
        {
            if(grid.RowCount == 0)
            {
               lblResult.Text = "No results found.";
            }
            else if (grid.RowCount == 1)
            {
                lblResult.Text = "1 result found.";
            }
            else
            {
                lblResult.Text =  grid.RowCount.ToString()+" results found.";
            }
        }

        private void gridItemLibrary_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intType = 1;
            if (grid.CurrentRow.Cells[0].Value.ToString().Equals("Medicine"))
                intType = 1;
            else if (grid.CurrentRow.Cells[0].Value.ToString().Equals("Supply"))
                intType = 2;
            else if (grid.CurrentRow.Cells[0].Value.ToString().Equals("Equipment"))
                intType = 3;

            FormAddItem itemForm = new FormAddItem(this, intType);
            getValues(itemForm, intType);
            itemForm.ShowDialog();
        }

        private void getValues(FormAddItem itemForm, int itemType)
        {
            itemForm.choice = 1;
            if (itemType == 3)
            {
                itemForm.txtCode.Text = grid.CurrentRow.Cells[0].Value.ToString();
                itemForm.txtGeneric_.Text = grid.CurrentRow.Cells[2].Value.ToString();
                itemForm.txtName_.Text = grid.CurrentRow.Cells[3].Value.ToString();
                itemForm.cbManufacturer_.SelectedIndex = itemForm.cbManufacturer_.Items.IndexOf(grid.CurrentRow.Cells[6].Value.ToString());
                itemForm.txtMin_.Text = grid.CurrentRow.Cells[7].Value.ToString();
                itemForm.txtMax_.Text = grid.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                itemForm.txtCode.Text = grid.CurrentRow.Cells[0].Value.ToString();
                itemForm.txtGen.Text = grid.CurrentRow.Cells[2].Value.ToString();
                itemForm.txtName.Text = grid.CurrentRow.Cells[3].Value.ToString();
                itemForm.txtDosage.Text = grid.CurrentRow.Cells[4].Value.ToString();
                itemForm.cbForm.SelectedIndex = itemForm.cbForm.Items.IndexOf(grid.CurrentRow.Cells[5].Value.ToString());
                itemForm.cbManufacturer.SelectedIndex = itemForm.cbManufacturer.Items.IndexOf(grid.CurrentRow.Cells[6].Value.ToString());
                itemForm.txtMin.Text = grid.CurrentRow.Cells[7].Value.ToString();
                itemForm.txtMax.Text = grid.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFilter = txtFilter.Text;
            if (rbAll.Checked)
                strType = "";
            else if (rbEquipment.Checked)
                strType = " AND intItemType=3";
            else if (rbSupply.Checked)
                strType = " AND intItemType=2";
            else if (rbMedicine.Checked)
                strType = " AND intItemType=1";


            switch (cbFilter.SelectedIndex)
            {
                case 0: //All
                    txtFilter.Enabled = false;
                    txtFilter.BackColor = Color.FromArgb(224, 224, 224);
                    break;
                case 1: //Item Name
                    strFilter = "AND strItemName LIKE '" + strFilter + "%' ";
                    txtFilter.Enabled = true;
                    txtFilter.BackColor = Color.White;
                    break;
                case 2: //Generic Name
                    strFilter = "AND strItemGeneric LIKE '" + strFilter + "%' ";
                    txtFilter.Enabled = true;
                    txtFilter.BackColor = Color.White;
                    break;
                case 3: //Manufacturer
                    strFilter = "AND b.strManuName LIKE '" + strFilter + "%' ";
                    txtFilter.Enabled = true;
                    txtFilter.BackColor = Color.White;
                    break;
            }
            strSearch = "SELECT CASE WHEN INTITEMTYPE = 1 THEN 'Medicine' WHEN INTITEMTYPE = 2 THEN 'Supply' ELSE 'Equipment' END AS Type," +
                                " strItemCode AS 'Item Code', strItemName AS 'Item Name', strItemGeneric AS 'Generic Name', b.strManuName AS 'Manufacturer', intItemMin AS 'Min', intItemMax as 'Max' " +
                                " FROM tblItem, tblManufacturer b " +
                                " WHERE (boolItemDeleted=0 AND strItemManuCode=b.strManuCode " + strFilter + strType + ");";
            
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            strSearch = "SELECT CASE WHEN INTITEMTYPE = 1 THEN 'Medicine' WHEN INTITEMTYPE = 2 THEN 'Supply' ELSE 'Equipment' END AS Type," +
                                " strItemCode AS 'Item Code', strItemName AS 'Item Name', strItemGeneric AS 'Generic Name', b.strManuName AS 'Manufacturer', intItemMin AS 'Min', intItemMax as 'Max' " +
                                " FROM tblItem, tblManufacturer b " +
                                " WHERE (boolItemDeleted=0 AND strItemManuCode=b.strManuCode " + strFilter + strType + ");";
            updateTable();
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        

    }
}
