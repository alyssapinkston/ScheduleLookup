namespace ScheduleLookup
{
    partial class CourseRoster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuScheduleLookup = new System.Windows.Forms.MenuStrip();
            this.scheduleLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseRosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleLookup30DataSet = new ScheduleLookup.ScheduleLookup30DataSet();
            this.course_RosterTableAdapter = new ScheduleLookup.ScheduleLookup30DataSetTableAdapters.Course_RosterTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseRoster1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_Roster1TableAdapter = new ScheduleLookup.ScheduleLookup30DataSetTableAdapters.Course_Roster1TableAdapter();
            this.mnuScheduleLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRosterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleLookup30DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRoster1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuScheduleLookup
            // 
            this.mnuScheduleLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuScheduleLookup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuScheduleLookup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleLookupToolStripMenuItem});
            this.mnuScheduleLookup.Location = new System.Drawing.Point(0, 0);
            this.mnuScheduleLookup.Name = "mnuScheduleLookup";
            this.mnuScheduleLookup.Size = new System.Drawing.Size(1304, 28);
            this.mnuScheduleLookup.TabIndex = 21;
            this.mnuScheduleLookup.Text = "menuStrip1";
            // 
            // scheduleLookupToolStripMenuItem
            // 
            this.scheduleLookupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.scheduleLookupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scheduleLookupToolStripMenuItem.Name = "scheduleLookupToolStripMenuItem";
            this.scheduleLookupToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.scheduleLookupToolStripMenuItem.Text = "Course Roster";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.majorNameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.advisorDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.campusMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseRosterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // courseRosterBindingSource
            // 
            this.courseRosterBindingSource.DataMember = "Course Roster";
            this.courseRosterBindingSource.DataSource = this.scheduleLookup30DataSet;
            // 
            // scheduleLookup30DataSet
            // 
            this.scheduleLookup30DataSet.DataSetName = "ScheduleLookup30DataSet";
            this.scheduleLookup30DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_RosterTableAdapter
            // 
            this.course_RosterTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorNameDataGridViewTextBoxColumn
            // 
            this.majorNameDataGridViewTextBoxColumn.DataPropertyName = "Major_Name";
            this.majorNameDataGridViewTextBoxColumn.HeaderText = "Major_Name";
            this.majorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorNameDataGridViewTextBoxColumn.Name = "majorNameDataGridViewTextBoxColumn";
            this.majorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // advisorDataGridViewTextBoxColumn
            // 
            this.advisorDataGridViewTextBoxColumn.DataPropertyName = "Advisor";
            this.advisorDataGridViewTextBoxColumn.HeaderText = "Advisor";
            this.advisorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.advisorDataGridViewTextBoxColumn.Name = "advisorDataGridViewTextBoxColumn";
            this.advisorDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // campusMailDataGridViewTextBoxColumn
            // 
            this.campusMailDataGridViewTextBoxColumn.DataPropertyName = "CampusMail";
            this.campusMailDataGridViewTextBoxColumn.HeaderText = "CampusMail";
            this.campusMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.campusMailDataGridViewTextBoxColumn.Name = "campusMailDataGridViewTextBoxColumn";
            this.campusMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // courseRoster1BindingSource
            // 
            this.courseRoster1BindingSource.DataMember = "Course Roster1";
            this.courseRoster1BindingSource.DataSource = this.scheduleLookup30DataSet;
            // 
            // course_Roster1TableAdapter
            // 
            this.course_Roster1TableAdapter.ClearBeforeFill = true;
            // 
            // CourseRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mnuScheduleLookup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseRoster";
            this.Text = "CourseRoster";
            this.Load += new System.EventHandler(this.CourseRoster_Load);
            this.mnuScheduleLookup.ResumeLayout(false);
            this.mnuScheduleLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRosterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleLookup30DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRoster1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuScheduleLookup;
        private System.Windows.Forms.ToolStripMenuItem scheduleLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ScheduleLookup30DataSet scheduleLookup30DataSet;
        private System.Windows.Forms.BindingSource courseRosterBindingSource;
        private ScheduleLookup30DataSetTableAdapters.Course_RosterTableAdapter course_RosterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.BindingSource courseRoster1BindingSource;
        private ScheduleLookup30DataSetTableAdapters.Course_Roster1TableAdapter course_Roster1TableAdapter;
    }
}