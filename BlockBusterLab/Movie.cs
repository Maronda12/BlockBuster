using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    public abstract class Movie
    {
        
        

        //Properties
        public string Title { get; set; }

        public Genre Category { get; set; } // is of enum Genre

        public int RunTime { get; set; }

        

        //List
        public List<string> Scenes { get; set; }

        //Constructor
        public Movie(string title, int runTime, Genre category, List<string> scenes)
        {
            this.Title = title;
            this.RunTime = runTime;
            this.Category = category;
            this.Scenes = scenes;
        }

       

        //Methods
        public virtual void PrintInfo(Movie m, int index)
        {
            Console.WriteLine($" Title: {Title}");
            Console.WriteLine($" RunTime: {RunTime} Minutes");
            Console.WriteLine($"Genre: {Category}");
        }

        public static void PrintScenes(List<string> Scenes) //Print Scenes 
        {
            foreach (string s in Scenes)
            {

               //Searches specified item,returns index within the list
                Console.WriteLine($"{Scenes.IndexOf(s) + 1}. {s}");
            }
        }
        public abstract void Play();
       

    
    }
}