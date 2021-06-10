using System;
using System.Collections.Generic;
using System.Text;


namespace BlockBusterLab
{
    class BlockBuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //You may only initialize values, but you may call any methods outside of another method
        //Movies.Add(new VHS("Die Hard", Genre.Action, 120, dieHardScenes));

        //Directly in a class, you may only declare and initalize properties and declare methods/constructors

        public BlockBuster()
        {
            //Think of this constructor as stocking our shelves in block buster with Movies
            List<string> MeanGirlsScenes = new List<string>() { "I'm not a regular mom", "Get in Loser", "Oh my god, Danny Devito", "You go Glenn Coco" };

            Movie a = new VHS("Mean Girls", 120,Genre.Comedy, MeanGirlsScenes);


            List<string> FightClubScenes = new List<string>() { "Space Monkey!", "The first rule", "This is your life", "I want you to hit me" };
            Movie b = new DVD("Fight Club", 150, Genre.Action, FightClubScenes);

            List<string> AmericanPsychoScenes = new List<string>() { "I'm in touch with humanity", "I have to return some videotapes", "Dont touch the watch", "Sabrina dont just stare"};
            Movie c = new DVD("American Psycho", 150, Genre.Horror,  AmericanPsychoScenes);

            List<string> WolfOfWallStreetScenes = new List<string>() { "Sell me this pen", "Then two more every 5 minutes", "I choose rich", "Hows being sober" };
            Movie d = new DVD("Wolf of Wall Street", 180, Genre.Drama, WolfOfWallStreetScenes);

            List<string> FastandFuriousScenes = new List<string>() {"I said a 10 second car", " Heads up bro", "Try fat burger", "Hey man he was in my face"};
            Movie e = new VHS("The Fast & Furious", 106, Genre.Action, FastandFuriousScenes);

            List<string> JumanjiScenes = new List<string>() { "In the jungle you must wait", "What ever it is you face it", "WHAT YEAR IS IT", "Run, its an stampede" };
            Movie f = new VHS("Jumanji", 140, Genre.Action, JumanjiScenes);

            Movies.Add(a);
            Movies.Add(b);
            Movies.Add(c);
            Movies.Add(d);
            Movies.Add(e);
        }

        //2 Reasons why we can use the movie class
        //1) Movie is public 
        //2) Movie is in the same namespace as this class
        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            return m;
        }

        public void PrintMovies()
        {
            foreach (Movie m in Movies)
            {
                Console.WriteLine($"{Movies.IndexOf(m) + 1}. {m.Title}");
            }
            Console.WriteLine();
        }

        public Movie CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Please enter the number of the title you would like to watch from the list: ");
            int index = int.Parse(Console.ReadLine());


            //uses the getmovie method to pick  movie
            Movie m = GetMovie(index - 1);
            //print selected movies info
            m.PrintInfo(m, index - 1);
            return m;
        }
    }

}