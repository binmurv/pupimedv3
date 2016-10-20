using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PUPiMed.UserControls;
using MetroFramework.Controls;

namespace PUPiMed
{
    public partial class UCMenuMaintenance : UserControl
    {
        private MainForm mainForm;
        private formMenu menu;
        private Color backColor1, backColor2, hover, selected;

        public UCMenuMaintenance(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public UCMenuMaintenance()
        {
            InitializeComponent();
        }

        private void UCMenuMaintenance_Load(object sender, EventArgs e)
        {
            menu = ((formMenu)this.ParentForm);
            menu.FormClosing += new FormClosingEventHandler(menu_FormClosing);
            backColor1 = Color.Teal;
            backColor2 = Color.LightSeaGreen;
            hover = Color.LightCoral;
            selected = Color.Firebrick;
        }

        private void tabItems_Click(object sender, EventArgs e)
        {
            try
            {
                resetColor(sender);
                formMenu menu = ((formMenu)this.ParentForm);
                menu.deact = false;
                UCMenuItems uc = new UCMenuItems(mainForm, menu);
                mainForm.showMenu(uc, ParentForm.Location.X + ParentForm.Width, ParentForm.Location.Y);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPatient_Click(object sender, EventArgs e)
        {
            try
            {
                resetColor(sender);
                formMenu menu = ((formMenu)this.ParentForm);
                menu.deact = false;
                UCMenuPatient uc = new UCMenuPatient(mainForm, menu);
                mainForm.showMenu(uc, ParentForm.Location.X + ParentForm.Width, ParentForm.Location.Y + this.tabPatient.Location.Y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TabSupplier_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCSupplier());
            menu.Close();
        }

        private void tabManufacturer_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCManufacturer());
            menu.Close();

        }

        private void tabBranches_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCBranches());
            menu.Close();

        }

        private void tabCollege_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCCollege());
            menu.Close();
        }
        private void tabDepartment_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCBranches());
            menu.Close();
        }

        private void tabDepartment_Click_1(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCCollege());
            menu.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UserControls.UCDepartment());
            menu.Close();
        }
        private void tabSupply_MouseEnter(object sender, EventArgs e)
        {
            menu.active = true;
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
                menu.active = false;
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


        private void UCMenuMaintenance_MouseEnter(object sender, EventArgs e)
        {
            menu.active = true;
        }

        private void UCMenuMaintenance_MouseLeave(object sender, EventArgs e)
        {
            menu.active = false;
        }

        private void menu_FormClosing (object sender, FormClosingEventArgs ex)
        {
            this.mainForm.Focus();
            this.mainForm.Activate();
        }

    }
}
