using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment_5
{
    public partial class ViewAllStudentsPapersForm : Form
    {
        public ViewAllStudentsPapersForm()
        {
            InitializeComponent();
        }

        private void ViewAllStudentsPapersLoad(object sender, EventArgs e)
        {
            //populates comboboxes with all students and papers enroled in the university
            txtBDisplay.Text = "";
            foreach (KeyValuePair<string, Paper> item in HomePageForm.dictionaryWithPaperInfo)
            {
                comboPapers.Items.Add(item.Key);
            }
            foreach (KeyValuePair<string, Student> item in HomePageForm.dictionaryWithStudentInfo)
            {
                comboStudents.Items.Add(item.Value.Name + " " + item.Key);
            }
        }

        private void ComboPapersSelectedIndexChanged(object sender, EventArgs e)
        {
            //finds and displays all students enrolled in selected paper
            txtBDisplay.Text = "";
            bool studentsInPaper = false;
            foreach (KeyValuePair<string, Paper> paperName in HomePageForm.dictionaryWithPaperInfo)
            {
                if (comboPapers.SelectedItem.ToString() == paperName.Key)
                {
                    foreach(string studentID in paperName.Value.ListOfStudents)
                    {
                        foreach(KeyValuePair<string, Student> studentID2 in HomePageForm.dictionaryWithStudentInfo)
                        {
                            if (studentID2.Key == studentID)
                            {
                                txtBDisplay.Text += studentID2.Value.Name + "\t" + studentID2.Value.ID + Environment.NewLine;
                                studentsInPaper = true;
                            }
                        }
                    }
                }
            }
            if(!studentsInPaper)
            {
                txtBDisplay.Text = "There are no students in this paper";
            }
        }

        private void ComboStudentsSelectedIndexChanged(object sender, EventArgs e)
        {
            //finds and displays all papers the selected student is enroled in.
            txtBDisplay.Text = "";
            bool studentsInPaper = false;
            foreach (KeyValuePair<string, Student> studentID in HomePageForm.dictionaryWithStudentInfo)
            {
                if (comboStudents.SelectedItem.ToString() == (studentID.Value.Name + " " + studentID.Key))
                {
                    foreach (string paperName in studentID.Value.Papers)
                    {
                        foreach(KeyValuePair<string, Paper> paperName2 in HomePageForm.dictionaryWithPaperInfo)
                        {
                            if(paperName2.Key == paperName)
                            {
                                txtBDisplay.Text += paperName2.Value.Name + "\t" + paperName2.Value.PaperCode + "\t"
                                    + paperName2.Value.CourseCoordinator + Environment.NewLine;
                                studentsInPaper = true;
                            }
                        }
                    }
                }
            }
            if (!studentsInPaper)
            {
                txtBDisplay.Text = "This student is not enroled in any papers";
            }
        }

        //The next  functions are for the menu. They are used to direct users to the correct page.
        private void HomeToolStripMenuItemClick(object sender, EventArgs e)
        {
            HomePageForm hpForm = new HomePageForm();
            hpForm.Show();
            Hide();
        }

        private void EnrolInAPaperToolStripMenuItemClick(object sender, EventArgs e)
        {
            //Checks to see if there are any papers in the University yet
            //If there are no papers user will be returned to home page.
            //this is to avoid any unnecessary errors that might occur.
            if (PaperForm.newItemForComboBox.Count != 0)
            {
                EnrolmentForm eForm = new EnrolmentForm();
                eForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("There are no papers to enrol in, please add a new paper before continuing.",
                    "No papers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnrolANewStudentToolStripMenuItemClick(object sender, EventArgs e)
        {
            StudentForm sForm = new StudentForm();
            sForm.Show();
            Hide();
        }

        private void SubmitANewPaperToolStripMenuItemClick(object sender, EventArgs e)
        {
            PaperForm pForm = new PaperForm();
            pForm.Show();
            Hide();
        }
    }
}
