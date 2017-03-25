namespace _158212_Assignment_5
{
    partial class HomePageForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.btnNewPaper = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(62, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(311, 26);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Massey University";
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.Location = new System.Drawing.Point(121, 62);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(180, 41);
            this.btnNewStudent.TabIndex = 0;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.BtnNewStudentClick);
            // 
            // btnEnrol
            // 
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrol.Location = new System.Drawing.Point(121, 127);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(180, 41);
            this.btnEnrol.TabIndex = 1;
            this.btnEnrol.Text = "Enrol in Paper";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.BtnEnrolClick);
            // 
            // btnNewPaper
            // 
            this.btnNewPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPaper.Location = new System.Drawing.Point(121, 195);
            this.btnNewPaper.Name = "btnNewPaper";
            this.btnNewPaper.Size = new System.Drawing.Size(180, 41);
            this.btnNewPaper.TabIndex = 2;
            this.btnNewPaper.Text = "New Paper";
            this.btnNewPaper.UseVisualStyleBackColor = true;
            this.btnNewPaper.Click += new System.EventHandler(this.BtnNewPaperClick);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(121, 260);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(180, 68);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View all students and papers";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnViewClick);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 386);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnNewPaper);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Button btnNewPaper;
        private System.Windows.Forms.Button btnView;
    }
}