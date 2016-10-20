using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;
using System.Data;

namespace PUPiMed.UserControls
{
    public partial class UCReportItemList : UserControl
    {
        public UCReportItemList()
        {
            InitializeComponent();
            String manu = "";
            String gname = "";
            String itemType = "";

            //Rpt(manu, itemType, gname);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string itemType = "";
            string manu = "";
            string gname = txtGName.Text;

            if (cbItemType.Text != "All")
            {
                
                itemType = cbItemType.Text;
            }

            if (cbManufacturer.Text != "All")
            {
                manu = cbManufacturer.Text;
            }

            Rpt(manu,itemType,gname);
            
        }

        public void Rpt(String manu, String itemType, String gname)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptItemList1.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = gname;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["genericName"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = itemType;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["itemType"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = manu;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["manufacturer"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(LoginNew.conn.ConnectionString);

            string ServerName = SqlConnectionStringBuilder.DataSource;
            string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
            Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
            string UserID = SqlConnectionStringBuilder.UserID;
            string Password = SqlConnectionStringBuilder.Password;


            foreach (CrystalDecisions.CrystalReports.Engine.Table Table in cryRpt.Database.Tables)
            {

                TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;

                TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                if (IntegratedSecurity != true)
                {
                    TableLogOnInfo.ConnectionInfo.UserID = UserID;
                    TableLogOnInfo.ConnectionInfo.Password = Password;
                }

                Table.ApplyLogOnInfo(TableLogOnInfo);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
        private void txtGName_Click(object sender, EventArgs e)
        {
            txtGName.Clear();
        }

        private void UCItemList_Load(object sender, EventArgs e)
        {
            using (LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT strManuName FROM tblManufacturer WHERE boolManuDeleted=FALSE;", LoginNew.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            cbManufacturer.Items.Add(dataReader.GetString(0));
                            while (dataReader.Read())
                            {
                                cbManufacturer.Items.Add(dataReader.GetString(0));
                            }
                        }
                        else
                        {
                            cbManufacturer.Items.Add("");
                        }
                        dataReader.Close();
                        cbManufacturer.Selec­tedIndex = 0;
                    }
                }
            }
            cbItemType.SelectedIndex = 0;
        }

        private void cbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
