using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCPatientLogs_DTR_ : UserControl
    {
        public UCPatientLogs_DTR_()
        {
            InitializeComponent();
            strQuery = "SELECT * FROM vwreceived WHERE `Item` LIKE '" + txtFilter.Text + "%';";
            updateTable();

        }

        private void gridDTR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addmedicine_Click(object sender, EventArgs e)
        {

        }

        private void editmedicine_Click(object sender, EventArgs e)
        {

        }

        private void deletemedicine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
