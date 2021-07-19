using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210705_TableStudent
{
    class BL
    { 
        public static int GetAge(DateTime birthday)
        {
            int age;
            DateTime currentData = DateTime.Now;

            age = currentData.Year - birthday.Year;

            if (currentData.Month - birthday.Month < 0)
            {
                age--;
            }
            if (currentData.Month - birthday.Month == 0 && currentData.Day - birthday.Day < 0)
            {
                age--;
            }

            return age;
        }

        public static string GetShortName(Student student)
        {
            StringBuilder shortName = new StringBuilder(student.Surname);
            char firstLetter = student.Name[0];

            shortName.AppendFormat(" ");
            shortName.AppendFormat(firstLetter.ToString());
            shortName.AppendFormat(".");

            string str = shortName.ToString();

            return str;
        }
    }
}
