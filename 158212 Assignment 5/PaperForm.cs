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
    public partial class PaperForm : Form
    {
        public PaperForm()
        {
            InitializeComponent();
        }
        
        private void BtnSubmitNewPaperClick(object sender, EventArgs e)
        {
            EnterNewPaper();
        }
        //this is made static so other forms can access this variable.
        public static List<string> newItemForComboBox = new List<string>();
        public void EnterNewPaper()
        {
            //Getting user information from text boxes
            string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBNameOfPaper.Text);
            string paperCode = txtBPaperCode.Text;
            string paperCoordinator = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBPaperCoordinator.Text);
            newItemForComboBox.Add(name);
            //creating a new file of papers when new paper is added.
            if(!HomePageForm.dictionaryWithPaperInfo.ContainsKey(name))
            {
                HomePageForm.dictionaryWithPaperInfo.Add(name, new Paper(name, paperCode, paperCoordinator, new List<string>()));
            } else
            {
                MessageBox.Show("A paper already exists with that paper name", "Paper already exists", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamWriter fileText = new StreamWriter(File.Create("Courses.txt"));
            foreach (KeyValuePair<string, Paper> item in HomePageForm.dictionaryWithPaperInfo)
            {
                //loop to write the dictionary to a new file.
                CreateNewPapersFile(item.Value, fileText);
            }
            fileText.Close();
            HomePageForm hpForm = new HomePageForm();
            hpForm.Show();
            Hide();
        }

        public static void CreateNewPapersFile(Paper listOfPapers, StreamWriter fileText)
        {
            //writes one papers details to file.
            //function should be used in a loop if wanting to write more than one paper to file.
            fileText.WriteLine(listOfPapers.Name);
            fileText.WriteLine(listOfPapers.PaperCode);
            fileText.WriteLine(listOfPapers.CourseCoordinator);
            foreach (string item in listOfPapers.ListOfStudents)
            {
                fileText.WriteLine(item);
            }
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
