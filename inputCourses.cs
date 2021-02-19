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
    public partial class inputCourses : Form
    {
        private string type;
        private string v;
        private string quarter;
        private string year;
        public inputCourses(string quarter, string year)
        {
            this.type = type;
            this.v = v;
            this.quarter = quarter;
            this.year = year;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sch = new ScheduleLookupPage();
            sch.Show();
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string course1 = txtCourse1.Text;
            string course2 = txtCourse2.Text;
            string select = "Select * from [Schedule Maker]('" + course1 + "', '" + course2 + "', '" + quarter + "', '" + year + "')";
            string connectionString = "Data Source=" + Properties.Resources.server + "; Initial Catalog = " + Properties.Resources.dbName + "; User ID = ExampleStudent30; Password = $cheduleL00kup";
            var c = new SqlConnection(connectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            scheduleOptionsView.ReadOnly = true;
            scheduleOptionsView.DataSource = ds.Tables[0];

        }
    }
}
