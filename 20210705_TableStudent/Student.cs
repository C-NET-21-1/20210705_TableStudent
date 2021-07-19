using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210705_TableStudent
{
    class Student
    {
        private const int CAPACITY = 10;
        private const int K = 2;

        private int _idPerson;
        private string _name;
        private string _surname;
        private int _recordBook;
        private DateTime _dateOfBirth;
        private int[] _marks;

        private int _counterMark;

        public Student(int idPerson, string name, string surname, int recordBook,
                DateTime dateTime, int markCount = CAPACITY)
        {
            _idPerson = idPerson;
            _name = name;
            _surname = surname;
            _recordBook = recordBook;
            _dateOfBirth = dateTime;
            _marks = new int[markCount];
            _counterMark = 0;
        }

        public Student(Student source)
        {
            _idPerson = source._idPerson;
            _name = source._name;
            _surname = source._surname;
            _recordBook = source._recordBook;
            _dateOfBirth = source._dateOfBirth;
            _marks = (int[])source._marks.Clone(); //GetFullCopy(source._marks);
            _counterMark = source._counterMark;
        }

        //public static int[] GetFullCopy(int[] source)
        //{
        //    int[] destination = new int[source.Length];

        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        destination[i] = source[i];
        //    }

        //    return destination;
        //}
        public int IdPerson
        {
            get
            {
                return _idPerson;
            }
            set
            {
                _idPerson = value;
            }
        }
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
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public int RecordBook
        {
            get
            {
                return _recordBook;
            }
            set
            {
                _recordBook = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        public int this[int position]
        {
            get
            {
                if(!IsValidPosition(position))
                {
                    return -1;
                }

                return _marks[position];
            }
        }

        public int CounterMark
        {
            get
            {
                return _counterMark;
            }
        }

        private bool IsValidPosition(int index)
        {
            return index >= 0 && index <= _counterMark;
        }

        public void AddMark(int mark)       
        {
            if (_counterMark >= _marks.Length)
            {
                Array.Resize(ref _marks, _marks.Length * K);
            }

            _marks[_counterMark] = mark;    
            _counterMark++;
        }

        public void ClearMarks(int markCount = CAPACITY)
        {
            _marks = new int[markCount];
            _counterMark = 0;
        }

        public Student CreateFakeStudent()
        {
            Student student = new Student(0, "Kirill", "Shevchenko",
                    12345, new DateTime(1997, 04, 01));

            return student;
        }

    }
}
