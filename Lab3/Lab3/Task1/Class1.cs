using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ThreeDigitNumber
    {
        public static int ChangeDigits(int num)
        {
            bool is_negative = (num < 0);
            num = Math.Abs(num);
            num = (num % 10) * 100 + ((num % 100) / 10) * 10 + num / 100;
            if (is_negative) num *= (-1);

            return num;
        }
    }
}
