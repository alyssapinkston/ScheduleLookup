namespace ScheduleLookup
{
    partial class ScheduleLookupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleLookupPage));
            this.btnUser = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mnuScheduleLookup = new System.Windows.Forms.MenuStrip();
            this.scheduleLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classScheduleOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAdviseeView = new System.Windows.Forms.Button();
            this.txtAdvisor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.btnProf = new System.Windows.Forms.Button();
            this.cbQuarter = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.mnuScheduleLookup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(449, 74);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(92, 23);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Username";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(311, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 1;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(311, 114);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 22);
            this.txtCourse.TabIndex = 2;
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(311, 159);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(230, 24);
            this.cbDept.TabIndex = 3;
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(449, 116);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(92, 23);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(561, 158);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(92, 24);
            this.btnDept.TabIndex = 5;
            this.btnDept.Text = "Dept";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(11, 336);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 162);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // mnuScheduleLookup
            // 
            this.mnuScheduleLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuScheduleLookup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuScheduleLookup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleLookupToolStripMenuItem});
            this.mnuScheduleLookup.Location = new System.Drawing.Point(0, 0);
            this.mnuScheduleLookup.Name = "mnuScheduleLookup";
            this.mnuScheduleLookup.Size = new System.Drawing.Size(801, 28);
            this.mnuScheduleLookup.TabIndex = 10;
            this.mnuScheduleLookup.Text = "menuStrip1";
            // 
            // scheduleLookupToolStripMenuItem
            // 
            this.scheduleLookupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.classScheduleOptionsToolStripMenuItem});
            this.scheduleLookupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scheduleLookupToolStripMenuItem.Name = "scheduleLookupToolStripMenuItem";
            this.scheduleLookupToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.scheduleLookupToolStripMenuItem.Text = "Schedule Lookup";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // classScheduleOptionsToolStripMenuItem
            // 
            this.classScheduleOptionsToolStripMenuItem.Name = "classScheduleOptionsToolStripMenuItem";
            this.classScheduleOptionsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.classScheduleOptionsToolStripMenuItem.Text = "Class Schedule Options";
            this.classScheduleOptionsToolStripMenuItem.Click += new System.EventHandler(this.classScheduleOptionsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAdviseeView
            // 
            this.btnAdviseeView.Location = new System.Drawing.Point(449, 189);
            this.btnAdviseeView.Name = "btnAdviseeView";
            this.btnAdviseeView.Size = new System.Drawing.Size(132, 23);
            this.btnAdviseeView.TabIndex = 26;
            this.btnAdviseeView.Text = "Advisee";
            this.btnAdviseeView.UseVisualStyleBackColor = true;
            this.btnAdviseeView.Click += new System.EventHandler(this.btnAdviseeView_Click);
            // 
            // txtAdvisor
            // 
            this.txtAdvisor.Location = new System.Drawing.Point(311, 189);
            this.txtAdvisor.Name = "txtAdvisor";
            this.txtAdvisor.Size = new System.Drawing.Size(132, 22);
            this.txtAdvisor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Advisor Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Professor Username:";
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(311, 226);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(132, 22);
            this.txtProf.TabIndex = 30;
            // 
            // btnProf
            // 
            this.btnProf.Location = new System.Drawing.Point(449, 226);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(132, 23);
            this.btnProf.TabIndex = 31;
            this.btnProf.Text = "Professor";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // cbQuarter
            // 
            this.cbQuarter.FormattingEnabled = true;
            this.cbQuarter.Location = new System.Drawing.Point(268, 44);
            this.cbQuarter.Name = "cbQuarter";
            this.cbQuarter.Size = new System.Drawing.Size(96, 24);
            this.cbQuarter.TabIndex = 32;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(442, 44);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(96, 24);
            this.cbYear.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Quarter: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Year:";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(311, 305);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(132, 25);
            this.btnImport.TabIndex = 37;
            this.btnImport.Text = "import data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ScheduleLookupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 535);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbQuarter);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdvisor);
            this.Controls.Add(this.btnAdviseeView);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDept);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.mnuScheduleLookup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuScheduleLookup;
            this.Name = "ScheduleLookupPage";
            this.Text = "ScheduleLookupPage";
            this.Load += new System.EventHandler(this.ScheduleLookupPage_Load);
            this.mnuScheduleLookup.ResumeLayout(false);
            this.mnuScheduleLookup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip mnuScheduleLookup;
        private System.Windows.Forms.ToolStripMenuItem scheduleLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAdviseeView;
        private System.Windows.Forms.ToolStripMenuItem classScheduleOptionsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAdvisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.ComboBox cbQuarter;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImport;
    }
}

