using MetroFramework.Forms;
using System;
using PUPiMed.UserControls;

namespace PUPiMed
{
    public partial class FormManufacturerSearch : MetroForm
    {
        private UCManufacturer uCManufacturer;

        public FormManufacturerSearch()
        {
            InitializeComponent();
        }

        public FormManufacturerSearch(UCManufacturer uCManufacturer)
        {
            InitializeComponent();
            this.uCManufacturer = uCManufacturer;
        }

        private void FormManufacturerSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strType ="";
            switch (cbItemType.SelectedIndex)
            {
                case 0:
                    strType = "";
                    break;
                case 1:
                    strType = " intManuType=1 AND";
                    break;
                case 2:
                    strType = " intManuType=2 AND";
                    break;
                case 3:
                    strType = " intManuType=3 AND";
                    break;
            }

            this.uCManufacturer.query =
                "SELECT " +
                "    a.strManuCode AS `Code`, " +
                "    a.strManuName AS `Manufacturer's Name`, " +
                "    (CASE " +
                "        WHEN(`a`.`intManuType` = 1) THEN 'Medicine' " +
                "        WHEN(`a`.`intManuType` = 2) THEN 'Supply' " +
                "        WHEN(`a`.`intManuType` = 3) THEN 'Equipment' " +
                "    END) AS `Item Type`, " +
                "    CONCAT(b.strAddrNum, " +
                "            ' ', " +
                "            b.strAddrStreet, " +
                "            ', ', " +
                "            b.strAddrTown, " +
                "            ', ', " +
                "            b.strAddrCity) AS `Address` " +
                "FROM " +
                "    tblmanufacturer a" +
                "    LEFT JOIN tbladdress b ON a.strManuAddrCode = b.strAddrCode " +
                "WHERE " +
                "     a.boolManuDeleted = 0 AND" +
                "     a.strManuCode LIKE '" + txtCode.Text + "%' AND" +
                strType + 
                "     a.strManuName LIKE '" + txtName.Text + "%' AND" +
                "     b.strAddrNum LIKE '" + txtNo.Text + "%' AND" +
                "     b.strAddrStreet LIKE '" + txtStreet.Text + "%' AND" +
                "     b.strAddrTown LIKE '" + txtTown.Text + "%' AND" +
                "     b.strAddrCity LIKE '" + txtCity.Text + "%'" +
                "    ;";

            this.uCManufacturer.updateTable();
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
