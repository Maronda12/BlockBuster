using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    public class DVD : Movie //To inherit from a class, use the : symbol.
    {
        //Constructor
        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes)
            : base(Title, RunTime, Category, Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
        }

        //Method
        //Called Play(), no parameters, is void. Ask what scene to watch, print all available scenes, allows user to select a scence from list and print out

        //To make current member override the implementation. add override keyword
        public override void Play()
        { 
             Console.WriteLine("Scene Menu");
             Console.WriteLine("===================");


            PrintScenes(Scenes) ;
            Console.WriteLine("Please select a scene from the list? 1-4");
            

            string input = Console.ReadLine();
                int userChoice = int.Parse(input) - 1;

                //Checks index
                if (userChoice > Scenes.Count || userChoice < 0)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    Console.WriteLine(Scenes[userChoice]);
                    Console.WriteLine("Would you like to watch another scene?");
                    string answer = Console.ReadLine().Trim().ToLower();
                    if (answer == "yes" || answer == "y")
                    {
                        Play();
                    }
                
                else
                {
                Console.WriteLine("Goodbye");
                }
        }
            
            
        }
    }

