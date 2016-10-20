using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUPiMed.UserControls;

namespace PUPiMed
{
    public partial class FormBranchSearch : MetroForm
    {
        private UCBranches uCBranches;

        public FormBranchSearch()
        {
            InitializeComponent();
        }

        public FormBranchSearch(UCBranches uCBranches)
        {
            InitializeComponent();
            this.uCBranches = uCBranches;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.uCBranches.query = 
                "SELECT "+
                "    a.strBranCode AS `Code`, " +
                "    a.strBranDesc AS `Branch Name`, " +
                "    CONCAT(b.strAddrNum, " +
                "            ' ', " +
                "            b.strAddrStreet, " +
                "            ', ', " +
                "            b.strAddrTown, " +
                "            ', ', " +
                "            b.strAddrCity) AS `Address` " +
                "FROM " +
                "    (tblbranch a" +
                "    LEFT JOIN tbladdress b ON((a.strBranAddrCode = b.strAddrCode))) " +
                "WHERE " +
                "     a.boolBranDeleted = 0 AND" +
                "     a.strBranCode LIKE '"+txtCode.Text+"%' AND" +
                "     a.strBranDesc LIKE '" + txtName.Text + "%' AND" +
                "     b.strAddrNum LIKE '" + txtNo.Text + "%' AND" +
                "     b.strAddrStreet LIKE '" + txtStreet.Text + "%' AND" +
                "     b.strAddrTown LIKE '" + txtTown.Text + "%' AND" +
                "     b.strAddrCity LIKE '" + txtCity.Text + "%'" +
                "    ;";

            this.uCBranches.updateTable();
            this.Dispose();
        }
    }
}
