using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158212_Assignment_5
{
    public class Paper
    {
        private string _name;
        private string _paperCode;
        private string _courseCoordinator;
        List<string> _listOfStudents = new List<string>();

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string PaperCode
        {
            get
            {
                return _paperCode;
            }
            set
            {
                _paperCode = value;
            }
        }

        public string CourseCoordinator
        {
            get
            {
                return _courseCoordinator;
            }
            set
            {
                _courseCoordinator = value;
            }
        }

        public List<string> ListOfStudents
        {
            get
            {
                return _listOfStudents;
            }
            set
            {
                _listOfStudents = value;
            }
        }

        public Paper(string name, string paperCode, string courseCoordinator, List<string> listOfStudents)
        {
            _name = name;
            _paperCode = paperCode;
            _courseCoordinator = courseCoordinator;
            _listOfStudents = listOfStudents;
        }
    }
}
