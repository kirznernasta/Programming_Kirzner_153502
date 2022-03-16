using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DateService
    {
        public static DayOfWeek GetDayOfWeek(string date)
        {
            string[] Date = date.Split(".");
            int day = Int16.Parse(Date[0]);
            int month = Int16.Parse(Date[1]);
            int year = Int16.Parse(Date[2]);

            DateOnly d = new DateOnly(year, month, day);

            return d.DayOfWeek;
        }


        public static int GetDaysSpan(int day, int month, int year)
        {
            DateTime d = new DateTime(year, month, day);

            System.TimeSpan s = d.Subtract(DateTime.Today);

            return Math.Abs(s.Days);
        }
    }
}
