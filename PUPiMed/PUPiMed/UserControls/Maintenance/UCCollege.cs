using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCCollege : UserControl
    {
        string strCode1, strName1, strAcronym1, strCode2, strName2, strAcronym2, query1, query2, query;
        bool newRecord1, newRecord2;
        
        public UCCollege()
        {
            InitializeComponent();
            query1 = "SELECT strCollCode AS 'Code', strCollName AS 'College', IFNULL(strCollShort,'') AS 'Acronym' FROM tblCollege WHERE boolCollDeleted=FALSE;";
            updateTable1();
        }

        #region College
        public void updateTable1()
        {
            using(LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query1, LoginNew.conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                grid.DataSource = dt;
                            }
                        }
                    }
                }
            }

        }

        private void grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                if (rb2.Checked)
                    query2 = "SELECT strCourCode AS 'Code', strCourName AS 'Course', IFNULL(strCourShort,'') AS 'Acronym' FROM tblCourse WHERE boolCourDeleted=FALSE AND strCourName LIKE '" + txtFilter.Text + "%' AND strCourCollCode LIKE '" + grid.CurrentRow.Cells[0].Value.ToString() + "';";
                else
                    query2 = "SELECT strCourCode AS 'Code', strCourName AS 'Course', IFNULL(strCourShort,'') AS 'Acronym' FROM tblCourse WHERE boolCourDeleted=FALSE AND strCourCollCode LIKE '" + grid.CurrentRow.Cells[0].Value.ToString() + "';";

                updateTable2();


                txtCode2.Enabled = false;
                txtName2.Enabled = true;
                txtAcronym2.Enabled = true;
                btnSave2.Enabled = true;
                btnEdit2.Enabled = true;
                btnDelete2.Enabled = true;
                btnAdd2.Enabled = true;
                btnClear2.Enabled = true;
            }
            else
            {
                txtCode2.Enabled = false;
                txtName2.Enabled = false;
                txtAcronym2.Enabled = false;
                btnSave2.Enabled = false;
                btnEdit2.Enabled = false;
                btnDelete2.Enabled = false;
                btnAdd2.Enabled = false;
                btnClear2.Enabled = false;
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            newRecord1 = true;
            clearContents1();
            getCode1();
            txtName1.Focus();
        }

        private bool everythingIsOkay1()
        {
            getCode1();
            strCode1 = txtCode1.Text;
            strAcronym1 = txtAcronym1.Text;
            strName1 = txtName1.Text;
            if (string.IsNullOrEmpty(strCode1) || string.IsNullOrEmpty(strAcronym1) || string.IsNullOrEmpty(strName1))
                return false;

            return true;
        }

        private void clearContents1()
        {
            txtAcronym1.Clear();
            txtName1.Clear();
        }

        private void getCode1()
        {
            strCode1 = Program.getPrevCode("SELECT strCollCode from tblCollege ORDER by char_length(strCollCode) DESC,strCollCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(strCode1))
            {
                txtCode1.Enabled = true;
            }
            else
            {
                strCode1 = Program.getNextCode(strCode1);
                txtCode1.Text = strCode1;
                txtCode1.Enabled = false;
            }
            txtCode1.BackColor = txtCode1.Enabled == true ? Color.White : Color.FromName("Control");
        }

        private void grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                txtCode1.Text = grid.CurrentRow.Cells[0].Value.ToString();
                txtName1.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtAcronym1.Text = grid.CurrentRow.Cells[2].Value.ToString();
            }

        }
        
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (Program.ExecuteQuery("UPDATE tblCollege SET boolCollDeleted = TRUE, dtmCollDeleted=NOW(), strCollDeleted=CURRENT_USER WHERE strCollCode = '" + grid.CurrentRow.Cells[0].Value.ToString() + "';"))
                    {
                        query1 = "SELECT strCollCode AS 'Code', strCollName AS 'College', IFNULL(strCollShort,'') AS 'Acronym' FROM tblCollege WHERE boolCollDeleted=FALSE;";
                        updateTable1();
                    }
                }
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                txtCode1.Text = grid.CurrentRow.Cells[0].Value.ToString();
                txtName1.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtAcronym1.Text = grid.CurrentRow.Cells[2].Value.ToString();

                newRecord1 = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearContents1();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (everythingIsOkay1())
            {
                if (newRecord1)
                    query = "INSERT INTO `dbmedicalclinic`.`tblcollege` (`strCollCode`, `strCollName`, `strCollShort`, `strCollAdded`) VALUES ('" + strCode1 + "', '" + strName1 +  "', '" + strAcronym1 + "', USER());";
                else
                    query = "UPDATE `dbmedicalclinic`.`tblcollege` SET `strCollName`='"+strName1+"', `strCollShort`='"+strAcronym1+"' WHERE `strCollCode`='"+strCode1+"';";

                if (!Program.ExecuteQuery(query))
                {
                    if (newRecord1)
                        error("Failed to save college");
                    else
                        error("Failed to update college");
                }
                else
                {
                    clearContents1();
                    status.Text = "Saved";
                    status.BackColor = Color.LimeGreen;
                    updateTable1();
                    getCode1();
                }
            }
            else
            {
                error("Please fill out empty fields");
            }
        }
        #endregion

        #region Course
        public void updateTable2()
        {
            using (LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query2, LoginNew.conn))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                grid2.DataSource = dt;
                            }
                        }
                    }
                }
            }
        }

        private void getCode2()
        {
            strCode2 = Program.getPrevCode("SELECT strCourCode from tblCourse ORDER by char_length(strCourCode) DESC, strCourCode DESC LIMIT 1;");
            
            if (string.IsNullOrEmpty(strCode2))
            {
                txtCode2.Enabled = true;
            }
            else
            {
                strCode2 = Program.getNextCode(strCode2);
                txtCode2.Text = strCode2;
                txtCode2.Enabled = false;
            }
            txtCode2.BackColor = txtCode2.Enabled == true ? Color.White : Color.FromName("Control");

        }

        private void clearContents2()
        {
            txtAcronym2.Clear();
            txtName2.Clear();
        }

        private void grid2_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid2.CurrentRow != null)
            {
                txtCode2.Text = grid2.CurrentRow.Cells[0].Value.ToString();
                txtName2.Text = grid2.CurrentRow.Cells[1].Value.ToString();
                txtAcronym2.Text = grid2.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private int everythingIsOkay2()
        {
            if (grid.CurrentRow != null)
            {
                strCode1 = grid.CurrentRow.Cells[0].Value.ToString();
                strCode2 = txtCode2.Text;
                strAcronym2 = txtAcronym2.Text;
                strName2 = txtName2.Text;
                if (string.IsNullOrEmpty(strCode2) || string.IsNullOrEmpty(strAcronym2) || string.IsNullOrEmpty(strName2))
                    return 1;
            }
            else return 2;

            return 0;
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (grid2.CurrentRow != null)
            {
                txtCode2.Text = grid2.CurrentRow.Cells[0].Value.ToString();
                txtName2.Text = grid2.CurrentRow.Cells[1].Value.ToString();
                txtAcronym2.Text = grid2.CurrentRow.Cells[2].Value.ToString();

                newRecord2 = false;
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (grid2.CurrentRow != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (Program.ExecuteQuery("UPDATE tblCourse SET boolCourDeleted = TRUE, dtmCourDeleted=NOW(), strCourDeleted=CURRENT_USER WHERE strCourCode = '" + grid2.CurrentRow.Cells[0].Value.ToString() + "';"))
                    {
                        query2 = "SELECT strCourCode AS 'Code', strCourName AS 'Course', IFNULL(strCourShort,'') AS 'Acronym' FROM tblCourse WHERE boolCourDeleted = FALSE AND strCourCollCode LIKE '"+grid.CurrentRow.Cells[0].Value.ToString()+"'";
                        updateTable2();
                    }
                }
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            clearContents2();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            switch (everythingIsOkay2())
            {
                case 0:
                    if (newRecord2)
                        query = "INSERT INTO `dbmedicalclinic`.`tblcourse` (`strCourCode`, `strCourName`, `strCourCollCode`, `strCourShort`, `strCourAdded`) VALUES ('" + strCode2 + "', '" + strName2 + "', '" + strCode1 + "', '" + strAcronym2 + "', USER());";
                    else
                        query = "UPDATE `dbmedicalclinic`.`tblcourse` SET `strCourName`= '"+strName2+"', `strCourCollCode`= '"+strCode1+"', `strCourShort`= '"+strAcronym2+"' WHERE `strCourCode`= '"+strCode2+"';";

                    if (!Program.ExecuteQuery(query))
                    {
                        if (newRecord2)
                            error("Failed to save course");
                        else
                            error("Failed to update course");
                    }
                    else
                    {
                        clearContents2();
                        status.Text = "Saved";
                        status.BackColor = Color.LimeGreen;
                        updateTable2();
                        getCode2();
                    }
                    break;

                case 1: 
                    error("Please fill out empty fields");
                    break;
                case 2:
                    error("No college selected");
                    break;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            newRecord2 = true;
            clearContents2();
            getCode2();
            txtName2.Focus();
            
        }

        private void grid2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        #endregion

        
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                query1 = "SELECT strCollCode AS 'Code', strCollName AS 'College', IFNULL(strCollShort,'') AS 'Acronym' FROM tblCollege WHERE boolCollDeleted=FALSE AND strCollName LIKE '%" + txtFilter.Text + "%';";
                updateTable1();
            }else
            {
                query2 = "SELECT strCourCode AS 'Code', strCourName AS 'Course', IFNULL(strCourShort,'') AS 'Acronym' FROM tblCourse WHERE strCourName LIKE '%" + txtFilter.Text + "%' AND boolCourDeleted=FALSE;";
                updateTable2();
            }
        }

        private void grid2_CurrentCellChanged(object sender, EventArgs e)
        {

        }     
        
        private void error (string errmsg)
        {
            status.Text = errmsg;
            status.BackColor = Color.Tomato;
        }

        private void UCCollege_Load(object sender, EventArgs e)
        {
        }
    }
}
