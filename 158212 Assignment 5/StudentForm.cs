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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {
            EnterNewStudent();
        }

        private void EnterNewStudent()
        {
            //Getting user information from text boxes
            string studentID = txtBID.Text;
            string DOB = txtBDOB.Text;
            //Checking all text boxes for user validation
            if (CheckFullName())
            {
                return;
            }
            if (CheckDOB(DOB))
            {
                return;
            }
            if (CheckStudentID(studentID))
            {
                return;
            }
            if (CheckAddress())
            {
                return;
            }
            //Converting full name so that each word in string starts with a capital, for comparison later
            //only loading variables once error checks have been done to ensure correct information before procceding
            string fullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBFirstName.Text + " " + txtBLastName.Text);
            string address = txtBStreetNo.Text + " " + txtBStreetName.Text + ", " + txtBSuburb.Text + ", " + txtBCity.Text;

            //saving students to file everytime a new student is added.
            if (!HomePageForm.dictionaryWithStudentInfo.ContainsKey(studentID))
            {
                //New student will be added only if the student ID does not already exist.
                HomePageForm.dictionaryWithStudentInfo.Add(studentID, new Student(fullName, address, DOB, studentID, new List<string>()));
            }
            StreamWriter fileText = new StreamWriter(File.Create("Students.txt"));
            foreach (KeyValuePair<string, Student> item in HomePageForm.dictionaryWithStudentInfo)
            {
                //loop to write the dictionary to a new file.
                CreateNewStudentsFile(item.Value, fileText);
            }
            fileText.Close();
            //Returns to homepage after adding a new student.
            HomePageForm hpForm = new HomePageForm();
            hpForm.Show();
            Hide();
        }

        private bool CheckFullName()
        {
            //Displays error if there is no text in either first name or last name text boxes
            if (txtBFirstName.Text == "")
            {
                MessageBox.Show("Please enter a first name.", "First name has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFirstName.ForeColor = Color.Red;
                return true;
            }
            else if (txtBLastName.Text == "")
            {
                MessageBox.Show("Please enter a last name.", "Last name has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLastName.ForeColor = Color.Red;
                return true;
            }
            //returns false if no errors have been found.
            return false;
        }

        public bool CheckDOB(string DOB)
        {
            string[] pattern = new string[] { "dd/MM/yyyy", "dd-MM-yyyy", "dd/MM/yy", "dd-MM-yy" };
            string newDateFormat;
            DateTime parsedDate;
            //tries to parse string to datetime, if successful then uses the parsedDate variable 
            //to format the date of birth into a string with only the date variables (no time at the end)
            if (DateTime.TryParseExact(DOB, pattern, null,
                                   DateTimeStyles.None, out parsedDate))
            {
                newDateFormat = parsedDate.Day + "/" + parsedDate.Month + "/" + parsedDate.Year;
                //returns false if parsing of string to dateTime is successful
                return false;
            }
            else
            {
                MessageBox.Show("Please enter a correct date value.", "Date of birth is incorrect",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDOB.ForeColor = Color.Red;
                txtBDOB.Text = "";
                return true;
            }
        }

        public bool CheckStudentID(string studentID)
        {
            //checks the student ID for an empty string or if the id is less than 8 digits long
            //will return false if the requirements are met.
            if (studentID == "")
            {
                MessageBox.Show("Please enter a student ID number.", "Student ID has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblID.ForeColor = Color.Red;
                return true;
            }
            else if (studentID.Length < 8)
            {
                MessageBox.Show("Student ID must be atleast 8 digits long", "Invalid student ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblID.ForeColor = Color.Red;
                txtBID.Text = "";
                return true;
            }
            return false;
        }

        private bool CheckAddress()
        {
            //Checks every field in the address to make sure a valid address has been entered.
            //If just one of the text boxes are empty will return true.
            if (txtBStreetNo.Text == "")
            {
                MessageBox.Show("Please enter a street number", "Street number has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStreetNo.ForeColor = Color.Red;
                return true;
            }
            else if (txtBStreetName.Text == "")
            {
                MessageBox.Show("Please enter a street name", "Street name has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStreetName.ForeColor = Color.Red;
                return true;
            }
            else if (txtBSuburb.Text == "")
            {
                MessageBox.Show("Please enter a suburb", "Suburb has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSuburb.ForeColor = Color.Red;
                return true;
            }
            else if (txtBCity.Text == "")
            {
                MessageBox.Show("Please enter a city", "City has not been entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCity.ForeColor = Color.Red;
                return true;
            }
            return false;
        }

        public static void CreateNewStudentsFile(Student listOfStudents, StreamWriter fileText)
        {
            //writes one students details to file.
            //function should be used in a loop if wanting to write more than one student to file.
            fileText.WriteLine(listOfStudents.Name);
            fileText.WriteLine(listOfStudents.Address);
            fileText.WriteLine(listOfStudents.BirthDate);
            fileText.WriteLine(listOfStudents.ID);
            foreach (string item in listOfStudents.Papers)
            {
                fileText.WriteLine(item);
            }
            //ends with '-1' to establish the end of the student.
            fileText.WriteLine("-1");
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

        //The next 3 functions are for the menu. They are used to direct users to the correct page.
        private void SubmitANewPaperToolStripMenuItemClick(object sender, EventArgs e)
        {
            PaperForm pForm = new PaperForm();
            pForm.Show();
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
