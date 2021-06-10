using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            while (goAgain)
            {
                List<Movie> movies = new List<Movie>();
                Console.WriteLine("Welcome!\n");
                Console.WriteLine("Please select a movie from the list\n");

                //this is how we bring the the movie list over
                BlockBuster B = new BlockBuster();
                Movie s = B.CheckOut();
               

                Console.WriteLine("Do you want to watch the selected movie?(yes/no)");
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "y" || input == "yes")
                {
                    s.Play();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
                

                
            }

        }
    }
}