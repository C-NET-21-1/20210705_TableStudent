using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210705_TableStudent
{
    class Group
    {
        private const int CAPACITY = 10;
        private const int K = 2;

        private int _numberGroup;
        private Student[] _students;
        private int _counterStudent;

        public Group(int numberGroup, int studentCount = CAPACITY)
        {
            _numberGroup = numberGroup;
            _students = new Student[studentCount];
            _counterStudent = 0;
        }

        public Group(Group source)
        {
            _numberGroup = source._numberGroup;
            _students = (Student[])source._students.Clone();
            _counterStudent = source._counterStudent;
        }

        public int NumberGroup
        {
            get 
            { 
                return _numberGroup; 
            }
            set 
            {
                _numberGroup = value; 
            }
        }

        public Student this[int position]
        {
            get 
            {
                if(!IsValidPosition(position))
                {
                    return null;
                }

                return new Student(_students[position]);
            }
            set
            {
                if (IsValidPosition(position))
                {
                    _students[position] = new Student(value);
                }
            }
        }

        public int CounterStudent
        {
            get 
            {
                return _counterStudent;
            }
        }

        private bool IsValidPosition(int index)
        {
            return index >= 0 && index <= _counterStudent;
        }

        public void AddStudent(Student student)
        {
            if(_counterStudent >= _students.Length)
            {
                Array.Resize(ref _students, _students.Length * K);
            }

            _students[_counterStudent] = new Student(student);    
            _counterStudent++;
        }

        public Student DeleteStudent(int countStudent)                     
        {
            Student student = null;

            if (IsValidPosition(countStudent))
            {
                student = new Student(_students[countStudent]);

                for (int i = countStudent; i < _counterStudent; i++)
                {
                    _students[i] = _students[i + 1];
                }
                _counterStudent--;
            }

            return student;
        }

        static public Group NewLevelGroup(Group source)                                     
        {
            Group group = new Group(source.NumberGroup + 1, source.CounterStudent);

            for (int i = 0; i < source.CounterStudent; i++)
            {
                Student student = new Student(source[i].IdPerson, source[i].Name,
                        source[i].Surname, source[i].RecordBook, source[i].DateOfBirth);
                group.AddStudent(student);
            }
   
            return group;
        }

    }
}
