namespace ScheduleLookup
{
    partial class inputCourses
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
            this.scheduleOptionsView = new System.Windows.Forms.DataGridView();
            this.scheduleMakerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleLookup30DataSet6 = new ScheduleLookup.ScheduleLookup30DataSet6();
            this.mnuScheduleLookup = new System.Windows.Forms.MenuStrip();
            this.scheduleLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCourse1 = new System.Windows.Forms.TextBox();
            this.txtCourse2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schedule_MakerTableAdapter = new ScheduleLookup.ScheduleLookup30DataSet6TableAdapters.Schedule_MakerTableAdapter();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.course1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crHrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleOptionsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleMakerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleLookup30DataSet6)).BeginInit();
            this.mnuScheduleLookup.SuspendLayout();
            this.SuspendLayout();
            // 
            // scheduleOptionsView
            // 
            this.scheduleOptionsView.AllowUserToAddRows = false;
            this.scheduleOptionsView.AllowUserToDeleteRows = false;
            this.scheduleOptionsView.AutoGenerateColumns = false;
            this.scheduleOptionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleOptionsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course1DataGridViewTextBoxColumn,
            this.cRNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.capDataGridViewTextBoxColumn,
            this.termScheduleDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.crHrsDataGridViewTextBoxColumn,
            this.course2DataGridViewTextBoxColumn});
            this.scheduleOptionsView.DataSource = this.scheduleMakerBindingSource;
            this.scheduleOptionsView.Location = new System.Drawing.Point(53, 218);
            this.scheduleOptionsView.Name = "scheduleOptionsView";
            this.scheduleOptionsView.ReadOnly = true;
            this.scheduleOptionsView.RowHeadersWidth = 51;
            this.scheduleOptionsView.Size = new System.Drawing.Size(935, 208);
            this.scheduleOptionsView.TabIndex = 0;
            // 
            // scheduleMakerBindingSource
            // 
            this.scheduleMakerBindingSource.DataMember = "Schedule Maker";
            this.scheduleMakerBindingSource.DataSource = this.scheduleLookup30DataSet6;
            // 
            // scheduleLookup30DataSet6
            // 
            this.scheduleLookup30DataSet6.DataSetName = "ScheduleLookup30DataSet6";
            this.scheduleLookup30DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnuScheduleLookup
            // 
            this.mnuScheduleLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuScheduleLookup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuScheduleLookup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleLookupToolStripMenuItem});
            this.mnuScheduleLookup.Location = new System.Drawing.Point(0, 0);
            this.mnuScheduleLookup.Name = "mnuScheduleLookup";
            this.mnuScheduleLookup.Size = new System.Drawing.Size(1035, 28);
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
            this.scheduleLookupToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.scheduleLookupToolStripMenuItem.Text = "Schedule Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // txtCourse1
            // 
            this.txtCourse1.Location = new System.Drawing.Point(122, 90);
            this.txtCourse1.Name = "txtCourse1";
            this.txtCourse1.Size = new System.Drawing.Size(325, 22);
            this.txtCourse1.TabIndex = 22;
            // 
            // txtCourse2
            // 
            this.txtCourse2.Location = new System.Drawing.Point(122, 132);
            this.txtCourse2.Name = "txtCourse2";
            this.txtCourse2.Size = new System.Drawing.Size(322, 22);
            this.txtCourse2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Input desired course abbreviation (example CHEM111):";
            // 
            // schedule_MakerTableAdapter
            // 
            this.schedule_MakerTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(762, 153);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(226, 41);
            this.btnGenerate.TabIndex = 25;
            this.btnGenerate.Text = "Generate Schedule Options";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // course1DataGridViewTextBoxColumn
            // 
            this.course1DataGridViewTextBoxColumn.DataPropertyName = "Course1";
            this.course1DataGridViewTextBoxColumn.HeaderText = "Course1";
            this.course1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.course1DataGridViewTextBoxColumn.Name = "course1DataGridViewTextBoxColumn";
            this.course1DataGridViewTextBoxColumn.ReadOnly = true;
            this.course1DataGridViewTextBoxColumn.Width = 125;
            // 
            // cRNDataGridViewTextBoxColumn
            // 
            this.cRNDataGridViewTextBoxColumn.DataPropertyName = "CRN";
            this.cRNDataGridViewTextBoxColumn.HeaderText = "CRN";
            this.cRNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cRNDataGridViewTextBoxColumn.Name = "cRNDataGridViewTextBoxColumn";
            this.cRNDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRNDataGridViewTextBoxColumn.Width = 75;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // capDataGridViewTextBoxColumn
            // 
            this.capDataGridViewTextBoxColumn.DataPropertyName = "Cap";
            this.capDataGridViewTextBoxColumn.HeaderText = "Cap";
            this.capDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capDataGridViewTextBoxColumn.Name = "capDataGridViewTextBoxColumn";
            this.capDataGridViewTextBoxColumn.ReadOnly = true;
            this.capDataGridViewTextBoxColumn.Width = 60;
            // 
            // termScheduleDataGridViewTextBoxColumn
            // 
            this.termScheduleDataGridViewTextBoxColumn.DataPropertyName = "TermSchedule";
            this.termScheduleDataGridViewTextBoxColumn.HeaderText = "TermSchedule";
            this.termScheduleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.termScheduleDataGridViewTextBoxColumn.Name = "termScheduleDataGridViewTextBoxColumn";
            this.termScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.termScheduleDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crHrsDataGridViewTextBoxColumn
            // 
            this.crHrsDataGridViewTextBoxColumn.DataPropertyName = "CrHrs";
            this.crHrsDataGridViewTextBoxColumn.HeaderText = "CrHrs";
            this.crHrsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crHrsDataGridViewTextBoxColumn.Name = "crHrsDataGridViewTextBoxColumn";
            this.crHrsDataGridViewTextBoxColumn.ReadOnly = true;
            this.crHrsDataGridViewTextBoxColumn.Width = 60;
            // 
            // course2DataGridViewTextBoxColumn
            // 
            this.course2DataGridViewTextBoxColumn.DataPropertyName = "Course2";
            this.course2DataGridViewTextBoxColumn.HeaderText = "Course2";
            this.course2DataGridViewTextBoxColumn.MinimumWidth = 2;
            this.course2DataGridViewTextBoxColumn.Name = "course2DataGridViewTextBoxColumn";
            this.course2DataGridViewTextBoxColumn.ReadOnly = true;
            this.course2DataGridViewTextBoxColumn.Width = 2;
            // 
            // inputCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse2);
            this.Controls.Add(this.txtCourse1);
            this.Controls.Add(this.mnuScheduleLookup);
            this.Controls.Add(this.scheduleOptionsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inputCourses";
            this.Text = "inputCourses";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleOptionsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleMakerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleLookup30DataSet6)).EndInit();
            this.mnuScheduleLookup.ResumeLayout(false);
            this.mnuScheduleLookup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleOptionsView;
        private System.Windows.Forms.MenuStrip mnuScheduleLookup;
        private System.Windows.Forms.ToolStripMenuItem scheduleLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCourse1;
        private System.Windows.Forms.TextBox txtCourse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource scheduleMakerBindingSource;
        private ScheduleLookup30DataSet6 scheduleLookup30DataSet6;
        private ScheduleLookup30DataSet6TableAdapters.Schedule_MakerTableAdapter schedule_MakerTableAdapter;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn course1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crHrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course2DataGridViewTextBoxColumn;
    }
}