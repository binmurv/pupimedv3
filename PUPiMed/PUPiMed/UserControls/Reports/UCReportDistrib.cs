using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PUPiMed.UserControls
{
    public partial class UCReportDistrib : UserControl
    {
        public UCReportDistrib()
        {
            InitializeComponent();
            int year = Convert.ToInt32(DateTime.Today.Year.ToString());
            for (int x = year; x != year - 20; x--)
            {
                cbYear.Items.Add(x);
                cbSemiYear.Items.Add(x);
                cbAnnualYear.Items.Add(x);
            }
            cbYear.SelectedIndex = 0;
            cbMonth.SelectedIndex = 0;
            //quart();
            cbSemiMonth.SelectedIndex = 0;
            cbSemiYear.SelectedIndex = 0;
            //semi();
            cbAnnualYear.SelectedIndex = 0;
            //annual();
            dtTo.MaxDate = DateTime.Today;
        }

        private void quart()
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptDistribQuarterly.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbMonth.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["month"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = cbYear.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["year"];
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

        private void semi()
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptDistribSemi.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbSemiMonth.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["month"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = cbSemiYear.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["year"];
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

            crystalReportViewer2.ReportSource = cryRpt;
            crystalReportViewer2.Refresh();
        }

        private void annual()
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptDistribAnnual.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbAnnualYear.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["year"];
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

            crystalReportViewer3.ReportSource = cryRpt;
            crystalReportViewer3.Refresh();
        }

        private void btnSpecificShow_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptDistribPickADate.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = dtFrom.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["fromDate"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = dtTo.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["toDate"];
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptDistribQuarterly.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbMonth.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["month"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = cbYear.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["year"];
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

        private void btnShowSemi_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory + @"\rptDistribSemi.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbSemiMonth.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["month"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = cbSemiYear.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["year"];
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

            crystalReportViewer2.ReportSource = cryRpt;
            crystalReportViewer2.Refresh();
        }

        private void btnShowAnnual_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(AppDomain.CurrentDomain.BaseDirectory+ @"\rptDistribAnnual.rpt");

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbAnnualYear.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["year"];
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

            crystalReportViewer3.ReportSource = cryRpt;
            crystalReportViewer3.Refresh();
        }
    }
}
