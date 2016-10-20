using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PUPiMed.UserControls
{
    public partial class UCReportSubMenu : UserControl
    {
        private MainForm mainForm;
        private formMenu menu;
        private Color backColor1, backColor2, hover, selected;

        public UCReportSubMenu(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UCReportSubMenu_Load(object sender, EventArgs e)
        {
            menu = ((formMenu)this.ParentForm);
            menu.FormClosing += new FormClosingEventHandler(menu_FormClosing);
            backColor1 = Color.Teal;
            backColor2 = Color.LightSeaGreen;
            hover = Color.LightCoral;
            selected = Color.Firebrick;
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs ex)
        {
            this.mainForm.Focus();
            this.mainForm.Activate();
        }

        private void resetColor(object sender)
        {
            try
            {
                MetroTile mtile = sender as MetroTile;
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

        private void tabStockCard_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCReportStockCard());
            menu.Close();
        }

        private void tabDTR_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCReports());
            menu.Close();
        }

        private void tabReceive_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCReportReceive());
            menu.Close();
        }

        private void tabDistrib_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCReportDistrib());
            menu.Close();
        }

        private void tabList_Click(object sender, EventArgs e)
        {
            resetColor(sender);
            mainForm.changeUC(new UCReportItemList());
            menu.Close();
        }

        private void tabStockCard_MouseEnter(object sender, EventArgs e)
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
        private void UCReportSubMenu_MouseEnter(object sender, EventArgs e)
        {
            menu.active = true;
        }

        private void UCReportSubMenu_MouseLeave(object sender, EventArgs e)
        {
            menu.active = false;
        }

    }
}
