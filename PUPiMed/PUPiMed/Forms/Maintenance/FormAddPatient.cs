using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormAddPatient : MetroForm
    {
        string strCode, strType, strLName, strFName, strMName, strGender, strDob, strHeight, strWeight, strContactNo, strDept, strCourse, strYear, strSection;
        List<String> listDept, listCourse, listCollege;
        FormAddPatientLogs log;
        private UCStudentTab uCStudentTab;
        private UCFacultyTab uCFacultyTab;
        private UCAdminTab uCAdminTab;
        int intType = 0;
        bool new_ = true;

        public FormAddPatient()
        {
            InitializeComponent();
            dtBday.MinDate = DateTime.Now.AddYears(-100);
            dtBday.MaxDate = DateTime.Now.AddYears(-10);
        }

        public FormAddPatient(FormAddPatientLogs log) : this()
        {
            this.intType = 0;
            this.log = log;
            this.cbPatientType.SelectedIndex = intType;
            loadType(); 
        }

        public FormAddPatient(UCStudentTab uCStudentTab) : this()
        {
            this.uCStudentTab = uCStudentTab;
            this.intType = 0;
            this.cbPatientType.SelectedIndex = intType;
            this.cbPatientType.Enabled = false;
            loadType();
        }

        public FormAddPatient(UCFacultyTab uCFacultyTab) : this()
        {
            this.uCFacultyTab = uCFacultyTab;
            this.intType = 1;
            this.cbPatientType.SelectedIndex = intType;
            this.cbPatientType.Enabled = false;
            loadType();
        }

        public FormAddPatient(UCAdminTab uCAdminTab) : this()
        {
            this.uCAdminTab = uCAdminTab;
            this.intType = 2;
            this.cbPatientType.SelectedIndex = intType;
            this.cbPatientType.Enabled = false;
            loadType();
        }

        public FormAddPatient(string code, int type, string first, string middle, string last, string birthday, int gender, string height, string weight, string contact, string college, string course, string year, string section) : this()
        {
            this.intType = type;
            this.cbPatientType.SelectedIndex = intType;
            loadType();

            this.cbDept.SelectedIndex = listDept.FindIndex(x => x.Equals(college));
            
            if (intType == 0)
            {
                this.loadCourse();
                this.cbCourse.SelectedIndex = listCourse.FindIndex(x => x.Equals(course));
                this.txtYear.Text = year;
                this.txtSection.Text = section;
            }

            this.txtCode.Text = code;
            this.txtCode.Enabled = false;
            this.cbPatientType.Enabled = false;
            this.txtFName.Text = first;
            this.txtMName.Text = middle;
            this.txtLName.Text = last;
            this.dtBday.Value = DateTime.Parse(birthday);
            
            rbMale.Checked = gender == 0;
            rbFemale.Checked = gender == 1;

            this.txtHeight.Text = height;
            this.txtWeight.Text = weight;
            this.txtContactNo.Text = contact;

            new_ = false;
        }

        private void loadType()
        {
            if (intType == 0)
            {
                cbCourse.Enabled = true;
                txtYear.Enabled = true;
                txtSection.Enabled = true;
                lblDept.Text = "College :";
                loadDepartment();
                loadCourse();
            }
            else if (intType == 1)
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

        private void AddPatient_Load(object sender, EventArgs e)
        {
            getCode();
        }

        private void getCode()
        {
            if (new_)
            {
                //check if theres an existing code
                string prevCode = PUPiMed.Program.getPrevCode("SELECT strPatiCode from tblPatient ORDER by char_length(strPatiCode) DESC, strPatiCode DESC LIMIT 1;");
                if (string.IsNullOrEmpty(prevCode))
                {
                    this.txtCode.BackColor = Color.White;
                    this.txtCode.Enabled = true;
                    this.txtCode.Focus();
                }
                else
                {
                    strCode = PUPiMed.Program.getNextCode(prevCode);
                    this.txtCode.Text = strCode;
                    this.txtCode.BackColor = Color.FromArgb(224, 224, 224);
                    this.txtCode.Enabled = false;
                    this.cbPatientType.Focus();
                }
            }
        }

        private void loadDepartment()
        {
            string strTable = "";
            if (intType == 2)
                strTable = "SELECT * FROM tbldepartment WHERE boolDeptDeleted = FALSE;";
            else
                strTable = "SELECT * FROM tblcollege WHERE boolCollDeleted = FALSE;";

            if (!Program.fillComboBox(cbDept, strTable, out listDept))
            {
                cbDept.PromptText = "Nothing Found!";
            }
            cbDept.SelectedIndex = 0;
        }

        private void loadCourse()
        {
            if(cbDept.Items.Count>1)
                if (!Program.fillComboBox(cbCourse, "SELECT * FROM tblCourse WHERE  boolCourDeleted = FALSE AND strCourCollCode = '" + listDept[cbDept.SelectedIndex].ToString() +"';", out listCourse))
                {
                    cbCourse.PromptText = "No Course Found!";
                }
        }
        
        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void medicon_Click(object sender, EventArgs e)
        {

        }

        private void suppcode_Click(object sender, EventArgs e)
        {

        }

        private void cbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.intType = cbPatientType.SelectedIndex;
            loadType();
        }

        private void txtCode_EnabledChanged(object sender, EventArgs e)
        {
            MetroTextBox txt = sender as MetroTextBox;
            if (txt.Enabled == false)
            {
                txt.BackColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }

        private void cbCourse_EnabledChanged(object sender, EventArgs e)
        {
            MetroComboBox cb = sender as MetroComboBox;
            if (cb.Enabled == false)
            {
                cb.BackColor = Color.FromArgb(224, 224, 224);
                cbCourse.PromptText = "";
            }
            else
            {
                cb.BackColor = Color.White;
                loadCourse();
            }
        }

        private void txtCode_Click(object sender, EventArgs e)
        {

        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatientType.SelectedIndex == 0)
            {
                loadCourse();
            }
            else
            {
                cbCourse.PromptText = "";
            }
        }

        private bool everythingIsOkay()
        {
            strCode = txtCode.Text;
            strType = cbPatientType.SelectedIndex.ToString();
            strDept = listDept[cbDept.SelectedIndex].ToString();
            strLName = txtLName.Text;
            strFName = txtFName.Text;
            strMName = txtMName.Text;
            strDob = dtBday.Value.ToString("yyyy-MM-dd");
            strGender = rbMale.Checked ? "0" : "1";
            strHeight = txtHeight.Text;
            strWeight = txtWeight.Text;
            strContactNo = txtContactNo.Text;

            if (string.IsNullOrEmpty(strCode) || string.IsNullOrEmpty(strLName)||
                string.IsNullOrEmpty(strFName)|| string.IsNullOrEmpty(strMName)|| 
                string.IsNullOrEmpty(strType) || string.IsNullOrEmpty(strDept) ||
                string.IsNullOrEmpty(strDob)  || string.IsNullOrEmpty(strGender))
            {
                return false;
            }

            if (intType == 0)
            {
                strCourse = listCourse[cbCourse.SelectedIndex].ToString();
                strYear = txtYear.Text;
                strSection = txtSection.Text;

                if(string.IsNullOrEmpty(strCourse) || string.IsNullOrEmpty(strYear) || string.IsNullOrEmpty(strSection))
                {
                    return false;
                }
            }
            return true;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            MetroTextBox txt = sender as MetroTextBox;
            float fltValue;
            if (!float.TryParse(txt.Text, out fltValue))
                txt.Text = "0";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCode();
            if (everythingIsOkay())
            {
                if (string.IsNullOrEmpty(PUPiMed.Program.getNextCode(strCode)))
                {
                    txtCode.Focus();
                    status.Text = "Invalid code";
                    status.BackColor = Color.Tomato;
                }
                else
                {
                    string query;
                    if (new_)
                        query =
                            "INSERT INTO tblPatient (strPatiCode, intPatiType ,strPatiLastName, strPatiFirstName, strPatiMiddleName, datPatiDOB, intPatiGender, fltPatiHeight, fltPatiWeight, strPatiContact, strPatiAdded) VALUES ('" +
                                strCode + "','" + intType + "','" + strLName + "','" + strFName + "','" + strMName + "','" + strDob + "','" + strGender + "','" + strHeight + "','" + strWeight + "','" + strContactNo + "', USER());";
                    else
                        query = "UPDATE `dbmedicalclinic`.`tblpatient` SET `intPatiType`='" + intType + "', `strPatiLastName`='" + strLName + "', `strPatiFirstName`='" + strFName + "', `strPatiMiddleName`='" + strMName + "', `datPatiDOB`='" + strDob + "', `intPatiGender`='" + strGender + "', `fltPatiHeight`='" + strHeight + "', `fltPatiWeight`='" + strWeight + "', `strPatiContact`='" + strContactNo+"' WHERE `strPatiCode`='"+strCode+"';";
                    
                    
                    //save to db
                    if (!PUPiMed.Program.ExecuteQuery(query))
                    {
                        //tell them something's wrong
                        status.Text = "Failed to save patient";
                        status.BackColor = Color.Tomato;
                    }
                    else
                    {
                        if (!saveOtherInfo())
                        {
                            //tell them something's wrong
                            status.Text = "Failed to save additional info";
                            status.BackColor = Color.Tomato;
                        }
                        else
                        {
                            getCode();
                            txtCode.Text = strCode;
                            txtLName.Clear();
                            txtFName.Clear();
                            txtMName.Clear();
                            dtBday.Value = dtBday.MaxDate;
                            rbMale.Checked = true;
                            cbPatientType.SelectedIndex = intType;
                            cbDept.SelectedIndex = 0;
                            txtYear.Clear();
                            txtSection.Clear();
                            txtHeight.Text = "0";
                            txtWeight.Text = "0";
                            txtContactNo.Clear();
                            status.Text = "Saved";
                            status.BackColor = Color.LimeGreen;
                            if (log != null)
                                log.loadPatients(null);
                            if (uCStudentTab != null)
                                uCStudentTab.updateTable();
                            if (uCAdminTab != null)
                                uCAdminTab.updateTable();
                            if (uCFacultyTab != null)
                                uCFacultyTab.updateTable();
                            if (!new_)
                            {
                                this.Dispose();
                            }
                        }
                    }
                }
            }
            else
            {
                //tell them it's not :(
                status.Text = "Please fill out all the required fields";
                status.BackColor = Color.Tomato;
            }
        }
    
        private bool saveOtherInfo()
        {
            string query = "";

            switch (intType)
            {
                case 0:
                    query = "INSERT INTO `dbmedicalclinic`.`tblstudentinfo` (`strStuIPatiCode`, `strStuICourCode`, `strStuIYear`, `strStuISection`) VALUES ('" + strCode + "', '" + strCourse + "', '" + strYear + "', '" + strSection + "');";
                    break;
                case 1:
                    query = "INSERT INTO `dbmedicalclinic`.`tblfacultyinfo` (`strFacIPatiCode`, `strFacICollCode`) VALUES ('" + strCode + "', '" + strDept + "');";
                    break;
                case 2:
                    query = "INSERT INTO `dbmedicalclinic`.`tbladmininfo` (`strAdmIPatiCode`, `strAdmIDeptCode`) VALUES ('" + strCode + "', '" + strDept + "');";
                    break;
            }

            if (PUPiMed.Program.ExecuteQuery(query))
                return true;
            return false;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void lblAddpatient_Click(object sender, EventArgs e)
        {

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            if(this.log!=null)
                this.log.loadPatients(null);
            if (this.uCAdminTab != null)
                this.uCAdminTab.updateTable();
            if (this.uCFacultyTab != null)
                this.uCFacultyTab.updateTable();
            if (this.uCStudentTab != null)
                this.uCStudentTab.updateTable();
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void height1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!= '.';
        }
        

        private void cno_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='(' && e.KeyChar!=')' && e.KeyChar!='+' && e.KeyChar!='-';
        }

        private void dtBday_ValueChanged(object sender, EventArgs e)
        {
            dtBday.MinDate = DateTime.Now.AddYears(-100);
                dtBday.MaxDate = DateTime.Now.AddYears(-10);
        }
    }
}
