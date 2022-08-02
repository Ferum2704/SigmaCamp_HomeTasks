using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaCamp_HomeTask15
{
    internal class Applicant
    {
        private string _surname;
        private int _entryYear;
        private int _schoolNumber;
        public  int SchoolNumber {
            get { return _schoolNumber; }
            set
            {
                if(value <= 0) throw new ArgumentOutOfRangeException();
                _schoolNumber = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentNullException();
                _surname = value;
            }
        }
        public int EntryYear
        {
            get { return _entryYear; }
            set
            {
                if(value <= 0) throw new ArgumentOutOfRangeException();
                _entryYear = value;
            }
        }
        public Applicant(string name = default, int schoolNum = default, int entryYear = default)
        {
            Surname = name;
            SchoolNumber = schoolNum;
            EntryYear = entryYear;
        }
    }
}
