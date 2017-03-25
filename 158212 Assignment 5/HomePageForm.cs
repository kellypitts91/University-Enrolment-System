using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158212_Assignment_5
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }
        //creating 2 dictioniaries, 1 with student info, other with paper info
        public static Dictionary<string, Paper> dictionaryWithPaperInfo = new Dictionary<string, Paper>();
        public static Dictionary<string, Student> dictionaryWithStudentInfo = new Dictionary<string, Student>();
        bool firstTimeFileLoaded = true;

        private void HomePageFormLoad(object sender, EventArgs e)
        {
            //This ensures that the files only load once when program is first run.
            if(firstTimeFileLoaded)
            {
                OpenStudentFile();
                OpenCoursesFile();
                firstTimeFileLoaded = false;
            }
        }

        private void OpenStudentFile()
        {
            //opens file for reading for students
            dictionaryWithStudentInfo = new Dictionary<string, Student>();
            StreamReader fileText = new StreamReader(File.OpenRead("Students.txt"));
            string fullName = "";
            //keeps reading file line by line until there is nothing left in the file.
            while ((fullName = fileText.ReadLine()) != null)
            {
                string address = fileText.ReadLine();
                string birthDate = fileText.ReadLine();
                string ID = fileText.ReadLine();
                string courseName = fileText.ReadLine();
                List<string> listOfPapers = new List<string>();
                //will keep adding papers to the list until -1 is found.
                while(courseName != "-1")
                {
                    listOfPapers.Add(courseName);
                    courseName = fileText.ReadLine();
                }
                dictionaryWithStudentInfo.Add(ID, new Student(fullName, address, birthDate, ID, listOfPapers));
            }
            fileText.Close();
        }

        private void OpenCoursesFile()
        {
            //opens file for reading for courses
            PaperForm.newItemForComboBox.Clear();
            StreamReader fileText = new StreamReader(File.OpenRead("Courses.txt"));
            string paperName = "";
            //keeps reading file line by line until there is nothing left in the file.
            while ((paperName = fileText.ReadLine()) != null)
            {
                string paperCode = fileText.ReadLine();
                string courseCoordinator = fileText.ReadLine();
                string studentName = fileText.ReadLine();
                List<string> listOfStudents = new List<string>();
                //will keep adding students to the list until -1 is found.
                while (studentName != "-1")
                {
                    listOfStudents.Add(studentName);
                    studentName = fileText.ReadLine();
                }
                if(!dictionaryWithPaperInfo.ContainsKey(paperName))
                {
                    dictionaryWithPaperInfo.Add(paperName, new Paper(paperName, paperCode, courseCoordinator, listOfStudents));
                }
                PaperForm.newItemForComboBox.Add(paperName);
            }
            fileText.Close();
        }

        //The next 4 functions are for the buttons to direct to correct page.
        private void BtnNewStudentClick(object sender, EventArgs e)
        {
            StudentForm sForm = new StudentForm();
            sForm.Show();
            Hide();
        }

        private void BtnEnrolClick(object sender, EventArgs e)
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

        private void BtnNewPaperClick(object sender, EventArgs e)
        {
            PaperForm pForm = new PaperForm();
            pForm.Show();
            Hide();
        }

        private void BtnViewClick(object sender, EventArgs e)
        {
            ViewAllStudentsPapersForm vForm = new ViewAllStudentsPapersForm();
            vForm.Show();
            Hide();
        }
    }
}
