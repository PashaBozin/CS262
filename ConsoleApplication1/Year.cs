using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Year
    {
        public static bool IsLeap(int year)
        {
            bool bool1 = false;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                bool1 = true;
            }
            return bool1;
        }
    }

