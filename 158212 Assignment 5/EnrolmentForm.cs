using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment_5
{
    public partial class EnrolmentForm : Form
    {
        public EnrolmentForm()
        {
            InitializeComponent();
        }

        private void EnrolmentFormLoad(object sender, EventArgs e)
        {
            //As soon as page has loaded the combobox used to display the courses will be added 
            //with all the papers that are in the university
            if (PaperForm.newItemForComboBox.Count != 0)
            {
                for(int i = 0; i < PaperForm.newItemForComboBox.Count; i++)
                {
                    //This adds all the papers to the combobox with each word starting with a capitial letter.
                    comboBoxCourses.Items.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(PaperForm.newItemForComboBox[i]));
                }
            }
        }

        private void BtnEnrolClick(object sender, EventArgs e)
        {
            Enrolment();
        }

        public string course;
        private void ComboBoxCoursesSelectedIndexChanged(object sender, EventArgs e)
        {
            //geting the selected course to use later.
            course = comboBoxCourses.SelectedItem.ToString();
        }

        private void Enrolment()
        {
            if(CheckStudentExists())
            {
                return;
            }
            //checking that the student and paper both exist before continuing
            bool studentExists = false;
            studentExists = AddNewStudentToPaper(studentExists);
            if (!studentExists)
            {
                MessageBox.Show("Error: Student does not exist.");
            }
            studentExists = AddNewPaperToStudent(studentExists);
            if (!studentExists)
            {
                MessageBox.Show("Error: Paper does not exist.");
            }
            //updating file with new student list
            StreamWriter studentText = new StreamWriter(File.Create("Students.txt"));
            foreach (KeyValuePair<string, Student> item in HomePageForm.dictionaryWithStudentInfo)
            {
                //loop to write the dictionary to a new file.
                StudentForm.CreateNewStudentsFile(item.Value, studentText);
            }
            studentText.Close();
            //updating file with new papers list
            StreamWriter paperText = new StreamWriter(File.Create("Courses.txt"));
            foreach (KeyValuePair<string, Paper> item in HomePageForm.dictionaryWithPaperInfo)
            {
                //loop to write the dictionary to a new file.
                PaperForm.CreateNewPapersFile(item.Value, paperText);
            }
            paperText.Close();
            HomePageForm hpForm = new HomePageForm();
            hpForm.Show();
            Hide();
        }

        private bool CheckStudentExists()
        {
            string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBFirstNameEnrol.Text + " " + txtBLastNameEnrol.Text);
            string ID = txtBStudentID.Text;
            foreach (KeyValuePair<string, Student> studentID in HomePageForm.dictionaryWithStudentInfo)
            {
                //checking if the name or id match with name or id in the dictionaries
                if (name == studentID.Value.Name || ID == studentID.Key)
                {
                    return false;
                } else
                {
                    //if they are not in the dictionaries will display error and return true
                    MessageBox.Show("Student with ID: " + ID + " or Name: " + name + " is not enroled in the university.",
                       "Error enroling student into paper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBFirstNameEnrol.Text = "";
                    txtBLastNameEnrol.Text = "";
                    txtBStudentID.Text = "";
                    return true;
                }
            }
            //must have return false as there could be no students in the dictionary
            return false;
        }

        //The next 2 functions are similar but could not convert them into 1 function due to 
        //too many different variables.
        public bool AddNewStudentToPaper(bool studentExists)
        {
            //loops through all the papers
            foreach (KeyValuePair<string, Paper> paper in HomePageForm.dictionaryWithPaperInfo)
            {
                //loops through the list of students
                foreach (string studentID in paper.Value.ListOfStudents)
                {
                    //compares all the keys of the paper dictionary with the course that was selected 
                    //from the combobox
                    if (paper.Key == course)
                    {
                        //if it finds a match then checks that the student ID entered is not already enroled 
                        //in the paper.
                        if (txtBStudentID.Text != studentID)
                        {
                            //if it does not exist then checks that the ID is enroled in the university
                            foreach (KeyValuePair<string, Student> studentID2 in HomePageForm.dictionaryWithStudentInfo)
                            {
                                //once all requirements have been met will find the key of the paper 
                                //and add the new student to the end of the list
                                if (txtBStudentID.Text == studentID2.Key)
                                {
                                    HomePageForm.dictionaryWithPaperInfo[paper.Key].ListOfStudents.Add(txtBStudentID.Text);
                                    return studentExists = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student is already enroled in this paper.");
                            studentExists = true;
                        }
                    }
                }
                //if there is no students enroled in the paper yet will create a new list of students.
                if (paper.Value.ListOfStudents.Count == 0)
                {
                    if (paper.Key == course)
                    {
                        HomePageForm.dictionaryWithPaperInfo[paper.Key].ListOfStudents = new List<string> { txtBStudentID.Text };
                        return studentExists = true;
                    }
                }
            }
            return studentExists;
        }

        public bool AddNewPaperToStudent(bool studentExists)
        {
            //loops through all the students
            foreach (KeyValuePair<string, Student> studentID in HomePageForm.dictionaryWithStudentInfo)
            {
                //loops through the list of papers
                foreach (string paperName in studentID.Value.Papers)
                {
                    //compares all the keys of the students dictionary with the student ID entered in textbox 
                    if (studentID.Key == txtBStudentID.Text)
                    {
                        //if it finds a match then checks that the course from the combobox is not already in the 
                        //list of papers
                        if (course != paperName)
                        {
                            //if it does not exist then finds the student ID key and adds the course to the end of the list.
                            foreach (KeyValuePair<string, Paper> paperName2 in HomePageForm.dictionaryWithPaperInfo)
                            {
                                if (paperName2.Key == course)
                                {
                                    HomePageForm.dictionaryWithStudentInfo[studentID.Key].Papers.Add(course);
                                    return studentExists = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student is already enroled in this paper.");
                            studentExists = true;
                        }
                    }
                }
                //if the student is not enroled in any papers yet will create a new list of papers.
                if (studentID.Value.Papers.Count == 0)
                {
                    if (studentID.Key == txtBStudentID.Text)
                    {
                        HomePageForm.dictionaryWithStudentInfo[studentID.Key].Papers = new List<string> { course };
                        return studentExists = true;
                    }
                }
            }
            return studentExists;
        }
        //The next 4 functions are for the menu. They are used to direct users to the correct page.
        private void SubmitANewPaperToolStripMenuItemClick(object sender, EventArgs e)
        {
            PaperForm pForm = new PaperForm();
            pForm.Show();
            Hide();
        }

        private void EnrolANewStudentToolStripMenuItemClick(object sender, EventArgs e)
        {
            StudentForm sForm = new StudentForm();
            sForm.Show();
            Hide();
        }

        private void ViewAllStudentsAndPapersToolStripMenuItemClick(object sender, EventArgs e)
        {
            ViewAllStudentsPapersForm vForm = new ViewAllStudentsPapersForm();
            vForm.Show();
            Hide();
        }

        private void HomeToolStripMenuItemClick(object sender, EventArgs e)
        {
            HomePageForm hpForm = new HomePageForm();
            hpForm.Show();
            Hide();
        }
    }
}
