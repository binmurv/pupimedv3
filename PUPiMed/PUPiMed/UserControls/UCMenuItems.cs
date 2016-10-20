using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCMenuItems : UserControl
    {
        private MainForm mainForm;
        private formMenu menu;
        private Color backColor1, backColor2, hover, selected;

        public UCMenuItems(MainForm mainForm, formMenu menu)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.menu = menu;
        }

        private void UCMenuItems_Load(object sender, EventArgs e)
        {
            this.ParentForm.FormClosed += new FormClosedEventHandler(this.menu_FormClosed);
            backColor1 = Color.Teal;
            backColor2 = Color.LightSeaGreen;
            hover = Color.LightCoral;
            selected = Color.Firebrick;
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.menu.active)
            {
                this.menu.Close();
                this.mainForm.Focus();
                this.mainForm.Activate();
            }
            else
            {
                this.menu.Focus();
                this.menu.Activate();
            }
        }

        private void tabMedicine_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCItem(1));
            ParentForm.Close();
        }

        private void tabSuppy_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCItem(2));
            ParentForm.Close();
        }

        private void tabEquipment_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCItem(3));
            ParentForm.Close();
        }

        private void tabSupply_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                MetroTile mtile = new MetroTile();
                mtile = sender as MetroTile;
                if (mtile.BackColor != selected)
                    mtile.BackColor = hover;
            }
            catch { }
        }

        private void tabSupply_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                MetroTile tile = sender as MetroTile;
                if (tile.BackColor != selected)
                {
                    if (tile.TabIndex % 2 == 0)
                        tile.BackColor = backColor2;
                    else if (tile.TabIndex % 2 != 0)
                        tile.BackColor = backColor1;
                }
            }
            catch { }
       }
        private void resetColor(object sender)
        {
            try
            {
                MetroTile mtile = new MetroTile();
                mtile = sender as MetroTile;
                foreach (var tile in this.Controls.OfType<MetroTile>())
                {

                    if (tile.TabIndex % 2 == 0)
                        tile.BackColor = backColor2;
                    else if (tile.TabIndex % 2 != 0)
                        tile.BackColor = backColor1;
                }
                mtile.BackColor = selected;
            }
            catch { }
        }

        private void tabItemLibrary_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCItemLibrary());
            ParentForm.Close();
        }

    }
}
