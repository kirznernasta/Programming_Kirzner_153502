using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    public class Solving
    {
        public static double GetResult(double x, double a, double b)
        {
            return (a * x + b * x * Math.Cos(Math.Sqrt(x))) / (x + a * b);
        }
    }
}
