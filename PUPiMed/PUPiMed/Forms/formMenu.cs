using System;
using System.Drawing;
using System.Windows.Forms;
using ToastNotifications;

namespace PUPiMed
{
    public partial class formMenu : Form
    {
        public bool deact = true;
        public bool active = false;
        public formMenu(UserControl uc)
        {
            InitializeComponent();
            this.Size = uc.Size;
            this.Controls.Add(uc);
            this.Focus();

            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(2, 0, Width, Height, 20, 20));
        }

        private void formMenu_Deactivate(object sender, EventArgs e)
        {
            if(deact)
                this.Close();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void formMenu_Leave(object sender, EventArgs e)
        {
            this.active = false;
        }

        private void formMenu_MouseEnter(object sender, EventArgs e)
        {
            this.active = true;
        }
    }
}