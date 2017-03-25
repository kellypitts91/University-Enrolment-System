using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158212_Assignment_5
{
    public class Student
    {
        private string _name;
        private string _address;
        private string _birthDate;
        private string _id;
        private List<string> _listOfPapers = new List<string>();

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

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }

        public List<string> Papers
        {
            get
            {
                return _listOfPapers; 
            }
            set
            {
                _listOfPapers = value;
            }
        }

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public Student(string name, string address, string birthDate, string ID, List<string> papers)
        {
            _name = name;
            _address = address;
            _birthDate = birthDate;
            _id = ID;
            _listOfPapers = papers;
        }
    }
}
