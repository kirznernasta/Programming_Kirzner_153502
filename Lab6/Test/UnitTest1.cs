using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdventureFilm film = new AdventureFilm();
            film.Name = "Ready Player One";
            film.Year = 2018;
            film.Views = 10000000;
            film.Cost = 34;
            film.Rating = 7.4;
            film.Director = "Steven Allan Spielberg";
            film.Watch();
            film.Share();
            Assert.AreEqual(film.Print(), "Name of film: Ready Player One\nDirector: Steven Allan Spielberg\nYear: 2018\n" +
                "Rating: 7,4\nGanre: Adventure\n");

            Assert.AreEqual(film.GetEarning(),340000000);

            CinemaFilm film2 = new CinemaFilm();
            film2.Year = 2022;
            film2.Views = 100000;
            film2.Cost = 60;
            film2.Rating = 6.3;
            film2.Name = "The Batman";
            film2.Director = "Matthew George Reeves";
            film2.Cinema = "Mir";
            film2.Watch();
            film2.Share();
        }
    }
}