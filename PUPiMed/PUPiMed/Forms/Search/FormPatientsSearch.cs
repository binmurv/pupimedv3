using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormPatientSearch : MetroForm
    {

        string query = "", strCollege = "", strDept = "", strType, strGender = "";
        List<String> listDept, listCourse;
        private UCPatientLogs_DTR_ uCPatientLogs_DTR_;
        private UCStudentTab uCStudentTab;
        private int intType = 0;
        private UCFacultyTab uCFacultyTab;
        private UCAdminTab uCAdminTab;
        private FormAddPatientLogs formAddPatientLogs;

        public FormPatientSearch()
        {
            InitializeComponent();
        }

        public FormPatientSearch(UCPatientLogs_DTR_ uCPatientLogs_DTR_) : this()
        {
            this.uCPatientLogs_DTR_ = uCPatientLogs_DTR_;
            query = "SELECT `Date`, `Time In`, `First Name`, `Middle Name`, `Last Name`, `Department`, `Complaints` FROM vwlogs WHERE ";

        }

        public FormPatientSearch(UCStudentTab uCStudentTab) : this()
        {
            this.uCStudentTab = uCStudentTab;
            this.intType = 1;
            this.cbPatientType.SelectedIndex = intType;
            this.cbPatientType.Enabled = false;
            loadType();
            query = "SELECT * FROM vwstudentlogs WHERE ";
        }

        public FormPatientSearch(UCFacultyTab uCFacultyTab) : this()
        {
            this.uCFacultyTab = uCFacultyTab;
            this.intType = 2;
            this.cbPatientType.SelectedIndex = intType;
            this.cbPatientType.Enabled = false;
            loadType();
            query = "SELECT * FROM vwfacultylogs WHERE ";
        }

        public FormPatientSearch(UCAdminTab uCAdminTab) : this()
        {
            this.uCAdminTab = uCAdminTab;
            this.intType = 3;
            this.cbPatientType.SelectedIndex = intType;
            this.cbPatientType.Enabled = false;
            loadType();
            query = "SELECT * FROM vwadminlogs WHERE ";
        }

        public FormPatientSearch(FormAddPatientLogs formAddPatientLogs) : this()
        {
            this.formAddPatientLogs = formAddPatientLogs;
            query = "SELECT Code, `Name` from vwpatients WHERE ";
        }

        private void FormPatientSearch_Load(object sender, EventArgs e)
        {

        }

        private void loadType()
        {
            if (intType <= 1)
            {
                cbCourse.Enabled = true;
                txtYear.Enabled = true;
                txtSection.Enabled = true;
                lblDept.Text = "College :";
                loadDepartment();
                loadCourse();
            }
            else if (intType == 2)
            {
                cbCourse.Enabled = false;
                txtYear.Enabled = false;
                txtSection.Enabled = false;
                lblDept.Text = "College :";
                loadDepartment();
            }
            else
            {
                cbCourse.Enabled = false;
                txtYear.Enabled = false;
                txtSection.Enabled = false;
                lblDept.Text = "Department :";
                loadDepartment();
            }
        }

        private void loadDepartment()
        {
            if (chkDept.Checked)
            {
                string strTable = "";
                if (intType == 3)
                    strTable = "SELECT * FROM tbldepartment WHERE boolDeptDeleted = FALSE;";
                else
                    strTable = "SELECT * FROM tblcollege WHERE boolCollDeleted = FALSE;";

                if (!Program.fillComboBox(cbDept, strTable, out listDept))
                {
                    cbDept.PromptText = "Nothing Found!";
                }
                cbDept.SelectedIndex = 0;
            }
        }

        private void loadCourse()
        {
            if (chkCourse.Checked)
            {
                if (cbDept.Items.Count != 0)
                {
                    if (!Program.fillComboBox(cbCourse, "SELECT * FROM tblCourse WHERE strCourCollCode = '" + listDept[cbDept.SelectedIndex].ToString() + "';", out listCourse))
                    {
                        cbCourse.PromptText = "No Course Found!";
                    }
                }
            }
        }

        private void txtAge_EnabledChanged(object sender, EventArgs e)
        {
            (sender as Control).BackColor = (sender as Control).Enabled ? Color.White : Color.FromArgb(224, 224, 224);
        }

        private void chkDept_CheckedChanged(object sender, EventArgs e)
        {
            cbDept.Enabled = chkDept.Checked;
            if (cbDept.Enabled)
            {
                loadDepartment();
            }
        }

        private void chkCourse_CheckedChanged_1(object sender, EventArgs e)
        {
            cbCourse.Enabled = chkCourse.Checked;
            if (cbCourse.Enabled)
            {
                loadCourse();
            }
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkCourse.Checked)
            {
                loadCourse();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (intType <= 1)
            {
                if(chkCourse.Checked)
                    strCollege = (chkCourse.Checked==false ? "" : (" AND strPatiCode IN (SELECT strStuiPatiCode FROM tblstudentinfo WHERE strStuiCourCode LIKE '" + listCourse[cbCourse.SelectedIndex].ToString() + "%') "));
                strCollege+=(string.IsNullOrEmpty(txtYear.Text) ? "" : (" AND strPatiCode IN(SELECT strStuiPatiCode FROM tblstudentinfo WHERE strStuiYear LIKE '" + txtYear.Text + "%') "));
                strCollege+=(string.IsNullOrEmpty(txtSection.Text) ? "" : (" AND strPatiCode IN(SELECT strStuiPatiCode FROM tblstudentinfo WHERE strStuiSection LIKE '" + txtSection.Text + "%') "));
                strDept = "";
            }
            else
            {
                strCollege = "";
                if(chkDept.Checked)
                    if(intType==2)
                        strDept = (chkDept.Checked==false ? "" : (" AND strPatiCode IN (SELECT strFacIPatiCode FROM tblfacultyinfo WHERE strFacICollCode LIKE '" + listDept[cbDept.SelectedIndex].ToString() + "%') "));
                    else
                        strDept = (chkDept.Checked==false ? "" : (" AND strPatiCode IN (SELECT strAdmIPatiCode FROM tbladmininfo WHERE strAdmIDeptCode LIKE '" + listDept[cbDept.SelectedIndex].ToString() + "%') "));
            }
            
            if (rbAll.Checked)
                strGender = "";
            else if (rbMale.Checked)
                strGender = " AND intPatiGender = 0 ";
            else
                strGender = " AND intPatiGender = 1 ";

            query +=
                "  `Code` LIKE '" + txtCode.Text + "%' AND `Code` IN (" +
                "   SELECT strPatiCode FROM dbmedicalclinic.tblpatient " + 
                "   WHERE strPatiFirstName LIKE '" + txtFName.Text + "%' " + 
                "   AND strPatiMiddleName LIKE '" + txtMName.Text + "%' " + 
                "   AND strPatiLastName LIKE '" + txtLName.Text + "%' " + 
                (string.IsNullOrEmpty(txtHeight.Text) ? "" : " AND fltPatiHeight = " + txtHeight.Text) +
                (string.IsNullOrEmpty(txtWeight.Text) ? "" : " AND fltPatiWeight = " + txtWeight.Text) + 
                (string.IsNullOrEmpty(txtAge.Text)    ? "" : " AND TIMESTAMPDIFF(YEAR, datPatiDOB, CURDATE()) = " +txtAge.Text) +
                strGender + strType + strCollege + strDept + 
                " ); ";
            //MessageBox.Show(query);
            if (uCStudentTab != null)
            {
                this.uCStudentTab.strQuery =  query;
                this.uCStudentTab.updateTable();
            }
            if(uCPatientLogs_DTR_ != null)
            {
                this.uCPatientLogs_DTR_.strQuery = query;
                this.uCPatientLogs_DTR_.updateTable();
            }
            if (uCFacultyTab != null)
            {
                this.uCFacultyTab.strQuery =  query;
                this.uCFacultyTab.updateTable();
            }
            if (uCAdminTab!= null)
            {
                this.uCAdminTab.strQuery =  query;
                this.uCAdminTab.updateTable();
            }
            if (formAddPatientLogs != null)
            {
                formAddPatientLogs.loadPatients(query);
            }

            this.Dispose();
        }

        private void cbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.intType = cbPatientType.SelectedIndex;
            loadType();
            switch (cbPatientType.SelectedIndex)
            {
                case 0:
                    strType = "";
                    break;
                case 1:
                    strType = " AND intPatiType = 0  "; 
                    break;
                case 2:
                    strType = " AND intPatiType = 1  ";
                    break;
                case 3:
                    strType = " AND intPatiType = 2  ";
                    break;
            }
        }

        private void chkCourse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar));
        }


        
    }
}
