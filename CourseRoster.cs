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
    public partial class CourseRoster : Form
    {
        private string crn;
        private string type;
        private string v;
        private string quarter;
        private string year;

        public CourseRoster(string crn)
        {
            InitializeComponent();
            this.crn = crn;
            Console.WriteLine(crn);
        }

        public CourseRoster(string crn, string type, string v, string quarter, string year) : this(crn)
        {
            this.type = type;
            this.v = v;
            this.crn = crn;
            this.quarter = quarter;
            this.year = year;
        }

        private void CourseRoster_Load(object sender, EventArgs e)
        {
            string select = "Select * from [Course Roster Function]('" + crn + "', '" + quarter + "', '" + year + "')";
            string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
            var c = new SqlConnection(connectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sch = new ScheduleView(type, quarter, year, v);
            sch.Show();
            this.Close();
        }
    }
}
