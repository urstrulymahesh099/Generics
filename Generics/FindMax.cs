﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax
    {
        public static char  FindInMax(char num1, char num2, char num3)
        {
            if(num1.CompareTo(num2)>0&& num1.CompareTo(num3)>0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return default;
        }

    }
}
