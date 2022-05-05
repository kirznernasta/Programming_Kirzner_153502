using Lab6;

Film film = new AdventureFilm();
film.Name = "Ready Player One";
film.Year = 2018;
film.Views = 10000000;
film.Cost = 34;
film.Rating = 7.4;
film.Director = "Steven Allan Spielberg";
film.Watch();
Console.WriteLine(film.GetEarning());

