using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace PUPiMed.UserControls
{
    public partial class UCReportStockCard : UserControl
    {
        public UCReportStockCard()
        {
            InitializeComponent();
            dtTo.Value = DateTime.Today;
            dtTo.MaxDate = DateTime.Today;

            dtFrom.Value = DateTime.Today;
            dtFrom.MaxDate = DateTime.Today;
        }
      

        private void btnSpecificShow_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptStocks.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dtFrom.Value.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["dateStart"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dtTo.Value.ToString();
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["dateEnd"];
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

            crystalReportViewer4.ReportSource = cryRpt;
            crystalReportViewer4.Refresh();
        }

        private void btnShowMonthly_Click(object sender, EventArgs e)
        {

        }
    }
}