using MetroFramework.Forms;

namespace PUPiMed.Forms
{
    public partial class FormReceiveItemSearch : MetroForm
    {
        private UCReceive uCReceive;
        string strType;

        public FormReceiveItemSearch()
        {
            InitializeComponent();
        }

        private void cbType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (cbType.SelectedIndex)
            {
                case 0:
                    strType = "";
                    break;
                default:
                    strType = "c.intItemType = "+cbType.SelectedIndex+" AND ";
                    break;
            }
        }
        

        public FormReceiveItemSearch(UCReceive uCReceive) : this()
        {
            this.uCReceive = uCReceive;
        }

        private void btncancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void FormReceiveItemSearch_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string query =
                "SELECT " +
                "    `a`.`strRecHCode` AS `Receiving Code`, " +
                "    `c`.`strItemName` AS `Item Name`, " +
                "    `b`.`intRecDQty` AS `Quantity`, " +
                "    `b`.`datRecDExpDate` AS `Expiration Date`, " +
                "    `d`.`strSuppName` AS `Supplier`, " +
                "    `a`.`datRecHDateReceived` AS `Date Received` " +
                "FROM " +
                "    `dbmedicalclinic`.`tblreceiveheader` `a` " +
                "    LEFT JOIN `dbmedicalclinic`.`tblreceivedetail` `b` ON `a`.`strRecHCode` = `b`.`strRecDRecHCode`  " +
                "    JOIN `dbmedicalclinic`.`tblitem` `c` ON `b`.`strRecDItemCode` = `c`.`strItemCode`  " +
                "    JOIN `dbmedicalclinic`.`tblsupplier` `d` ON `a`.`strRecHSuppCode` = `d`.`strSuppCode`  " +
                "WHERE " +
                "    `c`.`boolItemDeleted` <> 1 AND " +
                strType +
                (string.IsNullOrEmpty(txtQty.Text)   ? "" :("    b.intRecDQty = " + txtQty.Text + " AND ")) +
                (dtReceived.Checked?("    a.datRecHDateReceived = '" + dtReceived.Value.ToString("yyyy-MM-dd") + "' AND "): "") +
                (dtExp.Checked     ?("    b.datRecDExpDate = '" + dtExp.Value.ToString("yyyy-MM-dd") + "' AND ")          : "") +
                "    c.strItemName LIKE '" + txtName.Text + "%' AND " +
                "    d.strSuppName LIKE '" + txtSupplier.Text + "%' AND " +
                "    b.strRecDBatchCode LIKE '" + txtBatch.Text + "%' AND " +
                "    a.strRecHCode LIKE '" + txtRCode.Text + "%' AND " +
                "    a.strRecHDeliveryReceipt LIKE '" + txtReceipt.Text + "%' " +
                
                "ORDER BY `a`.`strRecHCode`; ";

            this.uCReceive.strQuery = query;
            this.uCReceive.updateTable();
            this.Dispose();
        }
    }
}
