using PUPiMed.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormSupplierSearch : MetroFramework.Forms.MetroForm
    {
        public UCSupplier  ucSupplier;
        public FormSupplierSearch()
        {
            InitializeComponent();
        }
        public FormSupplierSearch(UCSupplier ucSupplier)
        {
            InitializeComponent();
            this.ucSupplier = ucSupplier;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.ucSupplier.query =
                "SELECT " +
                "    a.strSuppCode AS `Code`, " +
                "    a.strSuppName AS `Supplier's Name`, " +
                "    CONCAT(b.strAddrNum, " +
                "            ' ', " +
                "            b.strAddrStreet, " +
                "            ', ', " +
                "            b.strAddrTown, " +
                "            ', ', " +
                "            b.strAddrCity) AS `Address`, " +
                "    a.strSuppEmail AS `Email`, " +
                "    a.strSuppContactNo AS `Contact No.` "+
                "FROM " +
                "    (tblsupplier a" +
                "    LEFT JOIN tbladdress b ON((a.strSuppAddrCode = b.strAddrCode))) " +
                "WHERE " +
                "     a.boolSuppDeleted = 0 AND" +
                "     a.strSuppCode LIKE '" + txtCode.Text + "%' AND" +
                "     a.strSuppName LIKE '" + txtName.Text + "%' AND" +
                "     a.strSuppEmail LIKE '" + txtEmail.Text +"%' AND" +
                "     a.strSuppContactNo LIKE '" + txtContact.Text + "%' AND" +
                "     b.strAddrNum LIKE '" + txtNo.Text + "%' AND" +
                "     b.strAddrStreet LIKE '" + txtStreet.Text + "%' AND" +
                "     b.strAddrTown LIKE '" + txtTown.Text + "%' AND" +
                "     b.strAddrCity LIKE '" + txtCity.Text + "%'" +
                "    ;";

            this.ucSupplier.updateTable();
            this.Dispose();
        }
    }
}
