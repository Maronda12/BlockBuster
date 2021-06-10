using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    public class VHS : Movie //To inherit from a class, use the : symbol.
    {

        //Property
        public int CurrentTime { get; set; } = 0;

        // this Constructor is called from base class (parent class)
        //if parent has parameters in constructor ,
        //The child must call base in its own constructor to pass values up to the parent
        //Outside of constructor, base functions much like this keyword
        //but instead of point to itself, it point ot immediated parent
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes) : base(Title, RunTime, Category, Scenes)
        {
            
        }
        //Methods
        //Method called Rewind() that returns nothing
        public void Rewind()
        {
            CurrentTime = 0;
        }

        //Method called Play(), plays the scene at the current time then increments (++) CurrentTime

        
            public override void Play()
        {
            for (int i = CurrentTime; CurrentTime < Scenes.Count; i++)
            {
                if (i == Scenes.Count)
                {
                    break;
                }
                Console.WriteLine(Scenes[i]);
                Console.WriteLine("Next Scene? (yes/no)");
                string input2 = Console.ReadLine().ToLower();
                if (input2 == "yes" && i != Scenes.Count)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye");
                }
            }

        }   
    }
}
