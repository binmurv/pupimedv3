using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace PUPiMed
{
    public partial class UCStudentTab : UserControl
    {
        public string strQuery;
        FormAddPatient form;

        public UCStudentTab()
        {
            InitializeComponent();
            strQuery = "SELECT * FROM vwstudentlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form = new FormAddPatient(this);
            form.ShowDialog();
        }

        public void updateTable()
        {
            try
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(strQuery, LoginNew.conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        try
                        {
                            sda.Fill(dt);
                            grid.DataSource = dt;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        finally
                        {
                            dt.Dispose();
                        }
                    }
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message.ToString());
            }
            finally
            {
                LoginNew.conn.Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            strQuery = "SELECT * FROM vwstudentlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getValues();
            form.grpOptional.Enabled = false;
            form.grpPersonal.Enabled = false;
            form.ShowDialog();
        }

        private void getValues()
        {
            int gender = 0, type = 0;
            string code = "", first = "", middle = "", last = "", birthday = "", height = "", weight = "", contact = "", college = "", course = "", year = "", section = "";
            code = grid.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT strPatiCode,intPatiType,strPatiLastName,strPatiFirstName,strPatiMiddleName,datPatiDOB,intPatiGender,fltPatiHeight,fltPatiWeight,strPatiContact,strStuICourCode,strStuIYear,strStuISection,strCourCollCode from dbmedicalclinic.tblpatient left join dbmedicalclinic.tblstudentinfo ON strpaticode = strstuiPatiCode left join dbmedicalclinic.tblcourse ON strStuICourCode=strCourCode where strpaticode = '" + code + "';", LoginNew.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        //Read the data and store them in the list
                        if (dataReader.Read())
                        {
                            code = dataReader.GetString(0);
                            type = dataReader.GetInt32(1);
                            last = dataReader.GetString(2);
                            first = dataReader.GetString(3);
                            middle = dataReader.GetString(4);
                            birthday = dataReader.GetString(5);
                            gender = dataReader.GetInt32(6);
                            height = dataReader.GetString(7);
                            weight = dataReader.GetString(8);
                            contact = dataReader.GetString(9);
                            course = dataReader.GetString(10);
                            year = dataReader.GetString(11);
                            section = dataReader.GetString(12);
                            college = dataReader.GetString(13);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoginNew.conn.Close();
            }

            form = new FormAddPatient(code, type, first, middle, last, birthday, gender, height, weight, contact, college, course, year, section);
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.updateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                var result = MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    string query;
                    string col1;
                    if (grid.CurrentRow.Cells[0] != null)
                    {
                        col1 = grid.CurrentRow.Cells[0].Value.ToString();

                        query = "UPDATE tblPatient SET boolPatiDeleted=1, dtmPatiDeleted=NOW(), strPatiDeleted=CURRENT_USER WHERE strPatiCode = '" + col1 + "';";

                        if (Program.ExecuteQuery(query))
                        {
                            //success
                            query = "SELECT * FROM vwstudentlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%';";
                            updateTable();
                        }
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            strQuery = "SELECT * FROM vwstudentlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%';";
            updateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                getValues();
                form.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this.Parent.Parent, "No results found.", "EMPTY GRID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblAdvanced_Click(object sender, EventArgs e)
        {
            FormPatientSearch form = new FormPatientSearch(this);
            strQuery = "SELECT * FROM vwstudentlogs WHERE `Last Name` LIKE '" + txtFilter.Text + "%' OR `Middle Name` LIKE '" + txtFilter.Text + "%' OR `First Name` LIKE '" + txtFilter.Text + "%' ";
            form.ShowDialog();
        }
    }
}
