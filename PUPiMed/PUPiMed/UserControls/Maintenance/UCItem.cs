using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace PUPiMed
{
    public partial class UCItem : UserControl
    {
        public int itemType;
        public string strItem;
        public string query;
        FormAddItem itemForm;

        public UCItem(int itemType)
        {
            InitializeComponent();
            this.itemType = itemType;
        }

        private void ucMedicine_Load(object sender, EventArgs e)
        {
            switch (this.itemType)
            {
                case 1:
                    this.icon.Image = global::PUPiMed.Properties.Resources.mecidine_teal;
                    title.Text = "MEDICINES";
                    strItem = "Medicine";
                    break;
                case 2:
                    this.icon.Image = global::PUPiMed.Properties.Resources.suppliesdff;
                    title.Text = "SUPPLIES";
                    strItem = "Supply";
                    break;
                case 3:
                    this.icon.Image = global::PUPiMed.Properties.Resources.wheelchair_teal;
                    title.Text = "EQUIPMENT";
                    strItem = "Equipment";
                    break;
            }
            filter();
        }
        
        public void updateTable()
        {
            using (LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, LoginNew.conn))
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
        }

        private void mbView_Click(object sender, EventArgs e)
        {
            if(grid.CurrentRow!=null)
            {
                itemForm = new FormAddItem(this, itemType);
                getValues();
                itemForm.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                itemForm = new FormAddItem(this, itemType);
                getValues();
                itemForm.medicine.Enabled = false;
                itemForm.equipment.Enabled = false;
                itemForm.ShowDialog();
            }
        }

        private void getValues()
        {
            itemForm.choice = 1;
            if (this.itemType == 3)
            {
                itemForm.txtCode.Text = grid.CurrentRow.Cells[0].Value.ToString();
                itemForm.txtGeneric_.Text = grid.CurrentRow.Cells[1].Value.ToString();
                itemForm.txtName_.Text = grid.CurrentRow.Cells[2].Value.ToString();
                itemForm.cbManufacturer_.SelectedIndex = itemForm.cbManufacturer_.Items.IndexOf(grid.CurrentRow.Cells[3].Value.ToString());
                itemForm.txtMin_.Text = grid.CurrentRow.Cells[4].Value.ToString();
                itemForm.txtMax_.Text = grid.CurrentRow.Cells[5].Value.ToString();
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

        private void mbAdd_Click(object sender, EventArgs e)
        {
            itemForm = new FormAddItem(this, itemType);
            itemForm.choice = 0;
            itemForm.ShowDialog();
        }

        private void deletemedicine_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                var result = MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    string strQuery;
                    string col1;
                    if (grid.CurrentRow.Cells[0] != null)
                    {
                        col1 = grid.CurrentRow.Cells[0].Value.ToString();

                        strQuery = "UPDATE tblItem SET boolItemDeleted=1, dtmItemDeleted=NOW(), strItemDeleted=CURRENT_USER WHERE strItemCode = '" + col1 + "';";

                        if (Program.ExecuteQuery(strQuery))
                        {
                            //success
                            filter();
                        }
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            FormItemSearch form = new FormItemSearch(this, itemType);
            if (itemType == 3)
                query = "SELECT `Code`, `Generic Name`, `Name`, `Manufacturer`, `Minimum Level`, `Maximum Level` FROM vwitem WHERE `Type` LIKE '" + strItem + "' AND `Name` LIKE '" + txtFilter.Text + "%' ";
            else
                query = "SELECT * FROM vwitem WHERE `Type` LIKE '" + strItem + "' AND `Name` LIKE '" + txtFilter.Text + "%' ";
            form.ShowDialog();
        }
        

        private void filter()
        {
            if(itemType == 3)
                query = query = "SELECT `Code`, `Generic Name`, `Name`, `Manufacturer`, `Minimum Level`, `Maximum Level` FROM vwitem WHERE `Type` LIKE '" + strItem + "' AND `Name` LIKE '" + txtFilter.Text + "%';";
            else
                query = "SELECT * FROM vwitem WHERE `Type` LIKE '" + strItem + "' AND `Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }
    }
}
