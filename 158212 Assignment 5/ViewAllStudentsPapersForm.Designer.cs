namespace _158212_Assignment_5
{
    partial class ViewAllStudentsPapersForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolInAPaperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolANewStudentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.submitANewPaperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboStudents = new System.Windows.Forms.ComboBox();
            this.comboPapers = new System.Windows.Forms.ComboBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblPapers = new System.Windows.Forms.Label();
            this.txtBDisplay = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem1,
            this.enrolInAPaperToolStripMenuItem1,
            this.enrolANewStudentToolStripMenuItem2,
            this.submitANewPaperToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // HomeToolStripMenuItem1
            // 
            this.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1";
            this.HomeToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.HomeToolStripMenuItem1.Text = "Home";
            this.HomeToolStripMenuItem1.Click += new System.EventHandler(this.HomeToolStripMenuItemClick);
            // 
            // enrolInAPaperToolStripMenuItem1
            // 
            this.enrolInAPaperToolStripMenuItem1.Name = "enrolInAPaperToolStripMenuItem1";
            this.enrolInAPaperToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.enrolInAPaperToolStripMenuItem1.Text = "Enrol in a paper";
            this.enrolInAPaperToolStripMenuItem1.Click += new System.EventHandler(this.EnrolInAPaperToolStripMenuItemClick);
            // 
            // enrolANewStudentToolStripMenuItem2
            // 
            this.enrolANewStudentToolStripMenuItem2.Name = "enrolANewStudentToolStripMenuItem2";
            this.enrolANewStudentToolStripMenuItem2.Size = new System.Drawing.Size(179, 22);
            this.enrolANewStudentToolStripMenuItem2.Text = "Enrol a new student";
            this.enrolANewStudentToolStripMenuItem2.Click += new System.EventHandler(this.EnrolANewStudentToolStripMenuItemClick);
            // 
            // submitANewPaperToolStripMenuItem1
            // 
            this.submitANewPaperToolStripMenuItem1.Name = "submitANewPaperToolStripMenuItem1";
            this.submitANewPaperToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.submitANewPaperToolStripMenuItem1.Text = "Submit a new paper";
            this.submitANewPaperToolStripMenuItem1.Click += new System.EventHandler(this.SubmitANewPaperToolStripMenuItemClick);
            // 
            // comboStudents
            // 
            this.comboStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStudents.FormattingEnabled = true;
            this.comboStudents.Location = new System.Drawing.Point(32, 82);
            this.comboStudents.Name = "comboStudents";
            this.comboStudents.Size = new System.Drawing.Size(251, 28);
            this.comboStudents.TabIndex = 0;
            this.comboStudents.Text = "(Students)";
            this.comboStudents.SelectedIndexChanged += new System.EventHandler(this.ComboStudentsSelectedIndexChanged);
            // 
            // comboPapers
            // 
            this.comboPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPapers.FormattingEnabled = true;
            this.comboPapers.Location = new System.Drawing.Point(323, 82);
            this.comboPapers.Name = "comboPapers";
            this.comboPapers.Size = new System.Drawing.Size(251, 28);
            this.comboPapers.TabIndex = 1;
            this.comboPapers.Text = "(Papers)";
            this.comboPapers.SelectedIndexChanged += new System.EventHandler(this.ComboPapersSelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(29, 50);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(74, 20);
            this.lblStudents.TabIndex = 4;
            this.lblStudents.Text = "Students";
            // 
            // lblPapers
            // 
            this.lblPapers.AutoSize = true;
            this.lblPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPapers.Location = new System.Drawing.Point(319, 50);
            this.lblPapers.Name = "lblPapers";
            this.lblPapers.Size = new System.Drawing.Size(59, 20);
            this.lblPapers.TabIndex = 5;
            this.lblPapers.Text = "Papers";
            // 
            // txtBDisplay
            // 
            this.txtBDisplay.Enabled = false;
            this.txtBDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDisplay.Location = new System.Drawing.Point(32, 158);
            this.txtBDisplay.Multiline = true;
            this.txtBDisplay.Name = "txtBDisplay";
            this.txtBDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBDisplay.Size = new System.Drawing.Size(542, 232);
            this.txtBDisplay.TabIndex = 2;
            // 
            // ViewAllStudentsPapersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.txtBDisplay);
            this.Controls.Add(this.lblPapers);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.comboPapers);
            this.Controls.Add(this.comboStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewAllStudentsPapersForm";
            this.Text = "ViewAllStudentsPapers";
            this.Load += new System.EventHandler(this.ViewAllStudentsPapersLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboStudents;
        private System.Windows.Forms.ComboBox comboPapers;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblPapers;
        private System.Windows.Forms.TextBox txtBDisplay;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enrolInAPaperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enrolANewStudentToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem submitANewPaperToolStripMenuItem1;
    }
}