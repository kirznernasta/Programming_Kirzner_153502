using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Film
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public double Rating { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public double Cost { get; set; }
        public int Views { get; set; }

        public Film()
        {
            Console.WriteLine("Constructor has been released!");
        }

        public double GetEarning()
        {
            return Cost * Views;
        }

        public virtual string Print()
        {
            string res = "Name of film: " + Name + "\nDirector: " + Director + "\nYear: " + Year + "\nRating: " + Rating + "\n";
            return res;
        }

        public abstract void Watch();

        public void Share()
        {
            Console.WriteLine($"You must watch film {Name} !");
        }
    }


    public sealed class AdventureFilm : Film
    {
        private const string ganre = "Adventure";
        public override void Watch()
        {
            Console.WriteLine("You are watching an adventure film!\n");
        }

        public override string Print()
        {
            return base.Print() + "Ganre: " + ganre + "\n";
        }

    }


    public class CinemaFilm : Film
    {
        private string _cinema;
        public string Cinema { get { return _cinema; } set { _cinema = value; } }

        public DateOnly Start { get; set; }

        public DateTime End { get; set; }

        public double GetEarning (DateOnly date )
        {
            double res = 0;
            if (date < Start)
            {
                Console.WriteLine("The film hasn't been released yet!");
            }
            else
            {
                res = base.GetEarning(); 
            }
            return res;
        }
        public override void Watch()
        {
            Console.WriteLine("You are watching film in the cinema!\n");
        }

        public new void Share()
        {
            Console.WriteLine($"You must watch film {Name} in cinema {Cinema}!");
        }
    }
}


