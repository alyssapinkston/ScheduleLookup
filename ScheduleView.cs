using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleLookup
{
    public partial class ScheduleView : Form
    {
        private string type;
        private string v;
        private string quarter;
        private string year;

        public ScheduleView(string type, string quarter, string year, string v)
        {
            InitializeComponent();
            this.type = type;
            this.v = v;
            this.quarter = quarter;
            this.year = year;
        }

        private void dayAndTimeView(string s)
        {
            string cs = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
            var con = new SqlConnection(cs);
            var dataAd = new SqlDataAdapter(s, con);
            var cb = new SqlCommandBuilder(dataAd);
            var d = new DataSet();
            dataAd.Fill(d);
            dayTimeView.ReadOnly = true;
            dayTimeView.DataSource = d.Tables[0];
        }
        private void scheduleView(string select)
        {
            string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
            var c = new SqlConnection(connectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            scheduleGridView.ReadOnly = true;
            scheduleGridView.DataSource = ds.Tables[0];
        }



        private void ScheduleView_Load(object sender, EventArgs e)
        {

            if (v.Equals("user"))
            {
                scheduleGridView.Visible = true;
                adviseeGridView.Visible = false;
                dayTimeView.Visible = true;
                instructorGridView.Visible = false;
                string fname = "";
                string lname = "";
                string id = "";
                string major = "";
                string classYear = "";
                string advisor = "";
                string email = "";

                //select statement with filter by username
                string select = "Select * from [Student View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                scheduleView(select);
                string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
                string s = "Select * from [Day and Time Username View Function]('" + type + "', '" + quarter + "', '" + year + "')";

                dayAndTimeView(s);

                var query = "SELECT Fname, Lname, ID, Major_Name, Year, Advisor, Email from [StudentInfo]('" + type + "')";
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            fname = reader[0] as string;
                            lname = reader[1] as string;
                            id = reader[2] as string;
                            major = reader[3] as string;
                            classYear = reader[4] as string;
                            advisor = reader[5] as string;
                            email = reader[6] as string;
                            break;
                        }
                    }
                    con.Close();
                }

                lblName.Text = "Name: " + fname + " " + lname;
                lblUser.Text = "Username: " + type;
                // lblID.Text = "Banner ID: " + id;
                lblMajor.Text = "Major: " + major;
                lblYear.Text = "Year: " + classYear;
                // lblAdvisor.Text = "Advisor: " + advisor;
                lblEmail.Text = "Email: " + email;
                lblUser.Visible = true;
                lblMajor.Visible = true;
                lblYear.Visible = true;
                lblEmail.Visible = true;
            }
            else if (v.Equals("course"))
            {
                scheduleGridView.Visible = true;
                adviseeGridView.Visible = false;
                instructorGridView.Visible = false;
                dayTimeView.Visible = true;
                string s = "Select * from [Day and Time View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                dayAndTimeView(s);

                //select statement with filter by course
                string select = "Select * from [Course View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
                scheduleView(select);

                lblName.Text = "Course: " + type;
                lblUser.Visible = false;
                lblMajor.Visible = false;
                lblYear.Visible = false;
                lblEmail.Visible = false;
            }
            else if (v.Equals("advisor"))
            {
                scheduleGridView.Visible = false;
                adviseeGridView.Visible = true;
                instructorGridView.Visible = false;
                dayTimeView.Visible = false;

                string select = "Select * from [Advisor Roster View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
                var c = new SqlConnection(connectionString); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                adviseeGridView.ReadOnly = true;
                adviseeGridView.DataSource = ds.Tables[0];

                lblName.Text = "Advisor: " + type;
                lblUser.Visible = false;
                lblMajor.Visible = false;
                lblYear.Visible = false;
                lblEmail.Visible = false;
            }else if (v.Equals("professor"))
            {
                scheduleGridView.Visible = false;
                adviseeGridView.Visible = false;
                instructorGridView.Visible = true;
                dayTimeView.Visible = true;
                string select = "Select * from [Instructor View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
                var c = new SqlConnection(connectionString); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                instructorGridView.ReadOnly = true;
                instructorGridView.DataSource = ds.Tables[0];
                string s = "Select * from [Day and Time Professor View Function]('" + type + "', '" + quarter + "', '" + year + "')";

                dayAndTimeView(s);

                lblName.Text = "Instructor: " + type;
                lblUser.Visible = false;
                lblMajor.Visible = false;
                lblYear.Visible = false;
                lblEmail.Visible = false;
            }
            else //v should be dept
            {
                scheduleGridView.Visible = true;
                adviseeGridView.Visible = false;
                instructorGridView.Visible = false;
                dayTimeView.Visible = true;
                string s = "Select * from [Day and Time Department View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                dayAndTimeView(s);
                //select statement with filter by dept
                string select = "Select * from [Department View Function]('" + type + "', '" + quarter + "', '" + year + "')";
                string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
                scheduleView(select);

                lblName.Text = "Department: " + type;
                lblUser.Visible = false;
                lblMajor.Visible = false;
                lblYear.Visible = false;
                lblEmail.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (scheduleGridView.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (scheduleGridView.CurrentCell != null && scheduleGridView.CurrentCell.Value != null)
                {
                    Form cr = new CourseRoster(scheduleGridView.CurrentCell.Value.ToString(), type, v, quarter, year);
                    cr.Show();
                    Hide();
                    //MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
                }
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sch = new ScheduleLookupPage();
            sch.Show();
            this.Close();
        }
    }
}
