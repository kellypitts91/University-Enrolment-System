namespace _158212_Assignment_5
{
    partial class EnrolmentForm
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
            this.lblFirstNameEnrol = new System.Windows.Forms.Label();
            this.lblLastNameEnrol = new System.Windows.Forms.Label();
            this.txtBFirstNameEnrol = new System.Windows.Forms.TextBox();
            this.txtBLastNameEnrol = new System.Windows.Forms.TextBox();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtBStudentID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitANewPaperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolANewStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentsAndPapersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstNameEnrol
            // 
            this.lblFirstNameEnrol.AutoSize = true;
            this.lblFirstNameEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameEnrol.Location = new System.Drawing.Point(35, 76);
            this.lblFirstNameEnrol.Name = "lblFirstNameEnrol";
            this.lblFirstNameEnrol.Size = new System.Drawing.Size(76, 17);
            this.lblFirstNameEnrol.TabIndex = 7;
            this.lblFirstNameEnrol.Text = "First Name";
            // 
            // lblLastNameEnrol
            // 
            this.lblLastNameEnrol.AutoSize = true;
            this.lblLastNameEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameEnrol.Location = new System.Drawing.Point(295, 76);
            this.lblLastNameEnrol.Name = "lblLastNameEnrol";
            this.lblLastNameEnrol.Size = new System.Drawing.Size(76, 17);
            this.lblLastNameEnrol.TabIndex = 8;
            this.lblLastNameEnrol.Text = "Last Name";
            // 
            // txtBFirstNameEnrol
            // 
            this.txtBFirstNameEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBFirstNameEnrol.Location = new System.Drawing.Point(38, 96);
            this.txtBFirstNameEnrol.Name = "txtBFirstNameEnrol";
            this.txtBFirstNameEnrol.Size = new System.Drawing.Size(155, 23);
            this.txtBFirstNameEnrol.TabIndex = 0;
            // 
            // txtBLastNameEnrol
            // 
            this.txtBLastNameEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBLastNameEnrol.Location = new System.Drawing.Point(298, 96);
            this.txtBLastNameEnrol.Name = "txtBLastNameEnrol";
            this.txtBLastNameEnrol.Size = new System.Drawing.Size(145, 23);
            this.txtBLastNameEnrol.TabIndex = 1;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(38, 231);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(405, 24);
            this.comboBoxCourses.TabIndex = 3;
            this.comboBoxCourses.Text = "(Select Course)";
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCoursesSelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(35, 211);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(96, 17);
            this.lblSelectCourse.TabIndex = 10;
            this.lblSelectCourse.Text = "Select Course";
            // 
            // btnEnrol
            // 
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrol.Location = new System.Drawing.Point(160, 322);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(151, 36);
            this.btnEnrol.TabIndex = 4;
            this.btnEnrol.Text = "Enrol";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.BtnEnrolClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enrolment";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(35, 141);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(74, 17);
            this.lblStudentID.TabIndex = 9;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtBStudentID
            // 
            this.txtBStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBStudentID.Location = new System.Drawing.Point(38, 161);
            this.txtBStudentID.Name = "txtBStudentID";
            this.txtBStudentID.Size = new System.Drawing.Size(155, 23);
            this.txtBStudentID.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.submitANewPaperToolStripMenuItem1,
            this.enrolANewStudentToolStripMenuItem1,
            this.viewAllStudentsAndPapersToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // submitANewPaperToolStripMenuItem1
            // 
            this.submitANewPaperToolStripMenuItem1.Name = "submitANewPaperToolStripMenuItem1";
            this.submitANewPaperToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.submitANewPaperToolStripMenuItem1.Text = "Submit a new paper";
            this.submitANewPaperToolStripMenuItem1.Click += new System.EventHandler(this.SubmitANewPaperToolStripMenuItemClick);
            // 
            // enrolANewStudentToolStripMenuItem1
            // 
            this.enrolANewStudentToolStripMenuItem1.Name = "enrolANewStudentToolStripMenuItem1";
            this.enrolANewStudentToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.enrolANewStudentToolStripMenuItem1.Text = "Enrol a new student";
            this.enrolANewStudentToolStripMenuItem1.Click += new System.EventHandler(this.EnrolANewStudentToolStripMenuItemClick);
            // 
            // viewAllStudentsAndPapersToolStripMenuItem1
            // 
            this.viewAllStudentsAndPapersToolStripMenuItem1.Name = "viewAllStudentsAndPapersToolStripMenuItem1";
            this.viewAllStudentsAndPapersToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.viewAllStudentsAndPapersToolStripMenuItem1.Text = "View all students and papers";
            this.viewAllStudentsAndPapersToolStripMenuItem1.Click += new System.EventHandler(this.ViewAllStudentsAndPapersToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem2.Text = "Home";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.HomeToolStripMenuItemClick);
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 465);
            this.Controls.Add(this.txtBStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.txtBLastNameEnrol);
            this.Controls.Add(this.txtBFirstNameEnrol);
            this.Controls.Add(this.lblLastNameEnrol);
            this.Controls.Add(this.lblFirstNameEnrol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EnrolmentForm";
            this.Text = "EnrolmentForm";
            this.Load += new System.EventHandler(this.EnrolmentFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNameEnrol;
        private System.Windows.Forms.Label lblLastNameEnrol;
        private System.Windows.Forms.TextBox txtBFirstNameEnrol;
        private System.Windows.Forms.TextBox txtBLastNameEnrol;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtBStudentID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem submitANewPaperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enrolANewStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentsAndPapersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}