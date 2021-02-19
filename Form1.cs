using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CsvHelper;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleLookup
{
    public partial class ScheduleLookupPage : Form
    {
        public ScheduleLookupPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string quarter = cbQuarter.Text;
            string year = cbYear.Text;
            Form sv = new ScheduleView(username, quarter, year, "user");
            sv.Show();
            this.Hide();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            string course = txtCourse.Text;
            string quarter = cbQuarter.Text;
            string year = cbYear.Text;
            Form sv = new ScheduleView(course, quarter, year, "course");
            sv.Show();
            this.Hide();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            string selDept = cbDept.SelectedValue.ToString();
            string quarter = cbQuarter.Text;
            string year = cbYear.Text;
            Form sv = new ScheduleView(selDept, quarter, year, "dept");
            sv.Show();
            this.Hide();
        }
        private void btnAdviseeView_Click(object sender, EventArgs e)
        {
            string advisorUser = txtAdvisor.Text;
            string quarter = cbQuarter.Text;
            string year = cbYear.Text;
            Form sv = new ScheduleView(advisorUser, quarter, year, "advisor");
            sv.Show();
            this.Hide();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            string prof = txtProf.Text;
            string quarter = cbQuarter.Text;
            string year = cbYear.Text;
            Form sv = new ScheduleView(prof, quarter, year, "professor");
            sv.Show();
            this.Hide();
        }
        private void loadPage()
        {
            string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
            var query = "SELECT * FROM [Department Table Function]()";
            using (var con = new SqlConnection(connectionString))
            using (var da = new SqlDataAdapter(query, con))
            {
                con.Open();
                var dt = new DataTable();
                Console.WriteLine("connection made");
                da.Fill(dt);
                cbDept.DataSource = dt;
                cbDept.DisplayMember = "Name";
                cbDept.ValueMember = "Name";
                con.Close();
            }
            var query2 = "SELECT * FROM [Term Table Function]()";
            using (var con = new SqlConnection(connectionString))
            using (var da = new SqlDataAdapter(query2, con))
            {
                con.Open();
                var dt = new DataTable();
                Console.WriteLine("connection made");
                da.Fill(dt);
                cbQuarter.DataSource = dt;
                cbQuarter.DisplayMember = "Quarter";
                cbQuarter.ValueMember = "Quarter";
                cbYear.DataSource = dt;
                cbYear.DisplayMember = "Year";
                cbYear.ValueMember = "Year";
                con.Close();
            }
        }


        private void ScheduleLookupPage_Load(object sender, EventArgs e)
        {
            this.loadPage();

        }

        Excel.Application xlApp; // = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorksheet;
        string sFileName;
        int row, col = 2;

        private void saveExcelData(string sFile)
        {
            double studentID = 0;
            double studentAdvisor = 0;
            double classYear = 0;
            double academicClass = 0;
            double courseID = 0;
            double departmentID = 0;
            string abbreviation = "";
            string major = "";
            string departmentName = "";
            double professorID = 0;
            double termID = 0;
            string quarterVal = "";
            string yearVal = "";
            string dayVal = "";
            string timeVal = "";
            string title = "";
            double creditHrs = 0;
            string finalExam = "";
            double cap = 0;
            string termSchedule = "";
            string comments = "";
            string username = "";
            double id = 0;
            string email = "";
            string fname = "";
            string lname = "";
            double cm = 0;
            string pwsalt = "";
            string pwhash = "";

            xlApp = new Excel.Application();
            //MessageBox.Show(sFile);
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            //xlWorksheet = xlWorkBook.Worksheets["Department"];

            string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DepartmentDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Department"];
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Abbreviation", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        departmentName = xlWorksheet.Cells[row, 1].value;
                        departmentID = xlWorksheet.Cells[row, 2].value;
                        abbreviation = xlWorksheet.Cells[row, 3].value;

                        cmd.Parameters["@Name"].Value = departmentName;
                        cmd.Parameters["@ID"].Value = departmentID;
                        cmd.Parameters["@Abbreviation"].Value = abbreviation;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert department successful");
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show("Department data failed to import"+ e);
                           // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("PersonDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Person"];
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@FName", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@LName", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@CampusMail", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@PasswordSalt", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        username = xlWorksheet.Cells[row, 1].value;
                        id = xlWorksheet.Cells[row, 2].value;
                        email = xlWorksheet.Cells[row, 3].value;
                        fname = xlWorksheet.Cells[row, 4].value;
                        lname = xlWorksheet.Cells[row, 5].value;
                        cm = xlWorksheet.Cells[row, 6].value;
                        pwsalt = xlWorksheet.Cells[row, 7].value;
                        pwhash = xlWorksheet.Cells[row, 8].value;

                        cmd.Parameters["@Username"].Value = username;
                        cmd.Parameters["@ID"].Value = id;
                        cmd.Parameters["@Email"].Value = email;
                        cmd.Parameters["@FName"].Value = fname;
                        cmd.Parameters["@LName"].Value = lname;
                        cmd.Parameters["@CampusMail"].Value = cm;
                        cmd.Parameters["@PasswordSalt"].Value = pwsalt;
                        cmd.Parameters["@PasswordHash"].Value = pwhash;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert person successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Person data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("ProfessorDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Professor"];
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        professorID = xlWorksheet.Cells[row, 1].value;

                        cmd.Parameters["@ID"].Value = professorID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert professor successful");
                        }
                        catch (Exception e)
                        {
                           // MessageBox.Show("Professor data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("StudentDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Student"];
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Advisor", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Year", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Class", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        studentID = xlWorksheet.Cells[row, 1].value;
                        studentAdvisor = xlWorksheet.Cells[row, 2].value;
                        classYear = xlWorksheet.Cells[row, 3].value;
                        academicClass = xlWorksheet.Cells[row, 3].value;

                        cmd.Parameters["@ID"].Value = studentID;
                        cmd.Parameters["@Advisor"].Value = studentAdvisor;
                        cmd.Parameters["@Year"].Value = classYear;
                        cmd.Parameters["@Class"].Value = academicClass;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert student successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Student data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("SectionDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Section"];
                    cmd.Parameters.Add("@CRN", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Capacity", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@TermSchedule", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        courseID = xlWorksheet.Cells[row, 1].value;
                        cap = xlWorksheet.Cells[row, 2].value;
                        termSchedule = xlWorksheet.Cells[row, 3].value;
                        comments = xlWorksheet.Cells[row, 4].value;

                        cmd.Parameters["@CRN"].Value = courseID;
                        cmd.Parameters["@Capacity"].Value = cap;
                        cmd.Parameters["@TermSchedule"].Value = termSchedule;
                        cmd.Parameters["@Comments"].Value = comments;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert section successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Section data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("CourseDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Course"];
                    cmd.Parameters.Add("@Course_ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@CreditHours", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@FinalExamSchedule", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Abbreviation", SqlDbType.NVarChar);

                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        courseID = xlWorksheet.Cells[row, 1].value;
                        title = xlWorksheet.Cells[row, 2].value;
                        creditHrs = xlWorksheet.Cells[row, 3].value;
                        finalExam = xlWorksheet.Cells[row, 4].value;
                        abbreviation = xlWorksheet.Cells[row, 5].value;
                        cmd.Parameters["@Course_ID"].Value = courseID;
                        cmd.Parameters["@Title"].Value = title;
                        cmd.Parameters["@CreditHours"].Value = creditHrs;
                        cmd.Parameters["@FinalExamSchedule"].Value = finalExam;
                        cmd.Parameters["@Abbreviation"].Value = abbreviation;

                        try
                        {
                            cmd.ExecuteNonQuery();
                          //  MessageBox.Show("Insert course successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Course data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("Enrolled_InDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Enrolled_In"];
                    cmd.Parameters.Add("@Student_ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Section_CRN", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        studentID = xlWorksheet.Cells[row, 1].value;
                        courseID = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@Student_ID"].Value = studentID;
                        cmd.Parameters["@Section_CRN"].Value = courseID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert enrolled in successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Enrolled in data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("Belong_ToDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Belong_To"];
                    cmd.Parameters.Add("@Course_ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Dept_ID", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        courseID = xlWorksheet.Cells[row, 1].value;
                        departmentID = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@Course_ID"].Value = courseID;
                        cmd.Parameters["@Dept_ID"].Value = departmentID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                         //   MessageBox.Show("Insert belongs to successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Belongs to data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("MajorDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Major"];
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Department_ID", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        major = xlWorksheet.Cells[row, 1].value;
                        departmentID = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@Name"].Value = major;
                        cmd.Parameters["@Department_ID"].Value = departmentID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert major successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Major data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("HasDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Has"];
                    cmd.Parameters.Add("@Student_ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Major_Name", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        studentID = xlWorksheet.Cells[row, 1].value;
                        major = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@Student_ID"].Value = studentID;
                        cmd.Parameters["@Major_Name"].Value = major;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert Has successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Has data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("TermDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Term"];
                    cmd.Parameters.Add("@Quarter", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Year", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Day", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Time", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        quarterVal = xlWorksheet.Cells[row, 1].value;
                        yearVal = xlWorksheet.Cells[row, 2].value;
                        dayVal = xlWorksheet.Cells[row, 3].value;
                        timeVal = Convert.ToString(xlWorksheet.Cells[row, 4].value);

                        cmd.Parameters["@Quarter"].Value = quarterVal;
                        cmd.Parameters["@Year"].Value = yearVal;
                        cmd.Parameters["@Day"].Value = dayVal;
                        cmd.Parameters["@Time"].Value = timeVal.ToString();

                        try
                        {
                            cmd.ExecuteNonQuery();
                         //   MessageBox.Show("Insert term successful");
                        }
                        catch (Exception e)
                        {
                           MessageBox.Show("Term data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("OfferedDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Offered"];
                    cmd.Parameters.Add("@SectionCRN", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@TermID", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        courseID = xlWorksheet.Cells[row, 1].value;
                        termID = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@SectionCRN"].Value = courseID;
                        cmd.Parameters["@TermID"].Value = termID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert offered successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Offered data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("TeachesDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Teaches"];
                    cmd.Parameters.Add("@Professor_ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Section_CRN", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        professorID = xlWorksheet.Cells[row, 1].value;
                        courseID = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@Professor_ID"].Value = professorID;
                        cmd.Parameters["@Section_CRN"].Value = courseID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                          //  MessageBox.Show("Insert teaches successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Teaches data failed to import" + e);
                            // break;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("Works_ForDataImport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   // conn.Open();
                    xlWorksheet = xlWorkBook.Worksheets["Works_For"];
                    cmd.Parameters.Add("@Professor_ID", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Dept_ID", SqlDbType.NVarChar);
                    for (row = 2; row <= xlWorksheet.Rows.Count; row++)
                    {
                        if (xlWorksheet.Cells[row, 1].value == null)
                        {
                            break;
                        }
                        professorID = xlWorksheet.Cells[row, 1].value;
                        departmentID = xlWorksheet.Cells[row, 2].value;

                        cmd.Parameters["@Professor_ID"].Value = professorID;
                        cmd.Parameters["@Dept_ID"].Value = departmentID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                           // MessageBox.Show("Insert Works For successful");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Works for data failed to import" + e);
                            // break;
                        }
                    }
                }
                conn.Close();
            }
            xlWorkBook.Close();
            xlApp.Quit();
        }

        private void classScheduleOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string quarter = cbQuarter.Text;
            string year = cbYear.Text;
            Form so = new inputCourses(quarter, year);
            so.Show();
            this.Hide();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Excel File to Import";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                sFileName = openFileDialog1.FileName;
                if (sFileName.Trim() != "")
                {
                    saveExcelData(sFileName);
                    this.loadPage();
                    MessageBox.Show("Data Import Completed");
                }
            }
        }
    }
}
