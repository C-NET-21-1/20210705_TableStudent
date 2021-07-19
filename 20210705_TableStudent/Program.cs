using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210705_TableStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Group groupOne = new Group(1234);
            Group groupTwo = new Group(1234);

            Student studentOne = new Student(111,"kirill", "shevchenko", 5555, new DateTime(1997,01,03));
            Student studentTwo = new Student(222, "Sasha", "shevchenko", 1111, new DateTime(2000, 01, 03));
            Student studentThree = new Student(333, "Vova", "shevchenko", 1111, new DateTime(2000, 01, 03));

            studentOne.AddMark(5);
            studentOne.AddMark(4);
            studentOne.AddMark(3);

            groupOne.AddStudent(studentOne);
            groupOne.AddStudent(studentTwo);
            groupOne.AddStudent(studentThree);


            Group groupThree = Group.NewLevelGroup(groupOne);

            groupOne.DeleteStudent(1);

            studentOne.AddMark(2);
            UI.ShowGroup(groupOne);


            Console.ReadKey();
        }
    }
}
