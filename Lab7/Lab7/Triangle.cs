using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Triangle
    {
        public double A
        {
            get { return a; }
            set 
            {
                if (value < 0) Console.WriteLine("Unexpected value!");
                else a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < 0) Console.WriteLine("Unexpected value!");
                else b = value;
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (value < 0) Console.WriteLine("Unexpected value!");
                else c = value;
            }
        }

        public Triangle() { a = 0; b = 0; c = 0; }

        public Triangle(double v1, double v2, double v3) { a = v1; b = v2; c = v3; }

        public double GetPerimetr()
        {
            return a + b + c;
        }

        public double GetSquare()
        {
            double p = GetPerimetr() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static Triangle operator ++ (Triangle tr)
        {
            tr.A++;
            tr.B++;
            tr.C++;
            return tr;
        }

        public static Triangle operator --(Triangle tr)
        {
            if (tr.a == 0 || tr.b == 0 || tr.c == 0) Console.WriteLine("Can't do it, sides of triangle have incorrect values for operation!");
            else
            {
                tr.A--;
                tr.B--;
                tr.C--;
            }
            return tr;
        }

        public static Triangle operator -(Triangle tr, int n)
        {
            if (tr.a - n < 0 || tr.b - n < 0 || tr.c - n < 0) Console.WriteLine("Can't do it, sides of triangle have incorrect values for operation!");
            else
            {
                tr.A -= n;
                tr.B -= n;
                tr.C -= n;
            }
            return tr;
        }

        public static Triangle operator *(Triangle tr, double n)
        {
            tr.A *= n;
            tr.B *= n;
            tr.C *= n;
            return tr;
        }

        public static Triangle operator /(Triangle tr, double n)
        {

            tr.A /= n;
            tr.B /= n;
            tr.C /= n;
            return tr;
        }

        public static bool operator == (Triangle tr1, Triangle tr2)
        {
            return tr1.GetSquare() == tr2.GetSquare();
        }

        public static bool operator !=(Triangle tr1, Triangle tr2)
        {
            return tr1.GetSquare() != tr2.GetSquare();
        }

        public static bool operator < (Triangle tr1, Triangle tr2)
        {
            return tr1.GetSquare() < tr2.GetSquare();
        }

        public static bool operator > (Triangle tr1, Triangle tr2)
        {
            return tr1.GetSquare() > tr2.GetSquare();
        }

        public static bool operator false (Triangle tr)
        {
            return !(tr.a == tr.b && tr.a == tr.c);
        }

        public static bool operator true(Triangle tr)
        {
            return (tr.a != tr.b || tr.a != tr.c || tr.b != tr.c);
        }

        public static implicit operator Triangle(double side)
        {
            return new Triangle(side, side, side);
        }

        public static explicit operator double(Triangle tr)
        {
            return tr.a;
        }

        public override string ToString()
        {
            return a + " " + b + " " + c;
        }

        private double a;
        private double b;
        private double c;
    }
}
