using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210705_TableStudent
{
    class UI
    {
        public static void ShowGroup(Group group)
        {
            for (int i = 0; i < group.CounterStudent; i++)
            {
                Console.WriteLine(group[i].Name);
                Console.WriteLine(group[i].Surname);
                Console.WriteLine(group[i].RecordBook);
                Console.WriteLine(group[i].DateOfBirth.ToShortDateString());

                for (int j = 0; j < group[i].CounterMark; j++)
                {
                    Console.Write("{0}  ", group[i][j]);
                }
                
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
