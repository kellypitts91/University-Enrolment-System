using Microsoft.VisualStudio.TestTools.UnitTesting;
using _158212_Assignment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158212_Assignment_5.Tests
{
    [TestClass()]
    public class UniversityTests
    {
        // Student Tests ---------------------------------------------------------------------
        [TestMethod()]
        public void StudentConstructorNameTest()
        {
            string expected = "Fred";
            Student s = new Student("Fred", "38C Smith Street", "25/05/1991", "09098321", new List<string>());
            Assert.AreEqual(expected, s.Name);
        }

        [TestMethod()]
        public void StudentConstructorAddressTest()
        {
            string expected = "38C Smith Street";
            Student s = new Student("Fred", "38C Smith Street", "25/05/1991", "09098321", new List<string>());
            Assert.AreEqual(expected, s.Address);
        }

        [TestMethod()]
        public void StudentConstructorDateTest()
        {
            string expected = "25/05/1991";
            Student s = new Student("Fred", "38C Smith Street", "25/05/1991", "09098321", new List<string>());
            Assert.AreEqual(expected, s.BirthDate);
        }

        [TestMethod()]
        public void StudentConstructorIDTest()
        {
            string expected = "09098321";
            Student s = new Student("Fred", "38C Smith Street", "25/05/1991", "09098321", new List<string>());
            Assert.AreEqual(expected, s.ID);
        }

        [TestMethod()]
        public void StudentConstructorListTest()
        {
            List<string> expected = new List<string>();
            Student s = new Student("Fred", "38C Smith Street", "25/05/1991", "09098321", new List<string>());
            CollectionAssert.AreEqual(expected, s.Papers);
        }

        // End of student tests --------------------------------------------------------------

        // Paper Tests ------------------------------------------------------------------------
        [TestMethod()]
        public void PaperConstructorNameTest()
        {
            string expected = "Application Software Development";
            Paper p = new Paper("Application Software Development", "158.212", "Teo Susnjak", new List<string>());
            Assert.AreEqual(expected, p.Name);
        }

        [TestMethod()]
        public void PaperConstructorPaperCodeTest()
        {
            string expected = "158.212";
            Paper p = new Paper("Application Software Development", "158.212", "Teo Susnjak", new List<string>());
            Assert.AreEqual(expected, p.PaperCode);
        }

        [TestMethod()]
        public void PaperConstructorCourseCoordinatorTest()
        {
            string expected = "Teo Susnjak";
            Paper p = new Paper("Application Software Development", "158.212", "Teo Susnjak", new List<string>());
            Assert.AreEqual(expected, p.CourseCoordinator);
        }

        [TestMethod()]
        public void PaperConstructorListTest()
        {
            List<string> expected = new List<string>();
            Paper p = new Paper("Application Software Development", "158.212", "Teo Susnjak", new List<string>());
            CollectionAssert.AreEqual(expected, p.ListOfStudents);
        }
        // End of Paper Tests ----------------------------------------------------------------------

        // Student Form Tests ----------------------------------------------------------------------

        [TestMethod()]
        public void CheckDOBIncorrectTest()
        {
            StudentForm sForm = new StudentForm();
            string DOB = "25051991";
            bool actual = sForm.CheckDOB(DOB);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckDOBCorrectTest()
        {
            StudentForm sForm = new StudentForm();
            string DOB = "25/05/1991";
            bool actual = sForm.CheckDOB(DOB);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckStudentIDIncorrectTest()
        {
            StudentForm sForm = new StudentForm();
            string studentID = "";
            bool actual = sForm.CheckStudentID(studentID);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckStudentIDLengthTest()
        {
            StudentForm sForm = new StudentForm();
            string studentID = "0909";
            bool actual = sForm.CheckStudentID(studentID);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckStudentIDCorrectTest()
        {
            StudentForm sForm = new StudentForm();
            string studentID = "09098321";
            bool actual = sForm.CheckStudentID(studentID);
            Assert.IsFalse(actual);
        }
        // End of Student form tests --------------------------------------------------------------------
    }
}