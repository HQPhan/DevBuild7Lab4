using System;
using System.Collections.Generic;

namespace Get_To_Know_Your_Classmastes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fNames = new List<string> 
            { 
                "0", "Andy", "Antonio", "Anurag", "Calyn", "Cassly", 
                "Cordero", "Cortez", "Cullin", "Erin", "Ese", 
                "Huy", "James", "Marjorie", "Madalina", "Phillip",
                "Ramone", "Richard","Rick","Tommy","Zachary"
            };

            List<string> lNames = new List<string>
            {
                "0", "Beer", "Manzari", "Reddy", "Greene", "Sullen",
                "Ebberhart", "Christian", "Flynn", "Walter", "Jackson",
                "Phan", "Mitchell", "Varasteanu", "Patton", "Condrad",
                "Lynch", "Moss","Madaleno","Waalkes","Parr"
            };

            List<string> homeTown = new List<string> 
            { 
                "0", "Berkley, MI","Beverly Hills, MI", "Rochester, MI", "Portage, MI","Detroit, MI",
                "Berkley, MI","Detroit, MI","Fowlerville, MI","Troy, MI","Detroit, MI",
                "Lansing, MI","Yap, FSM","Saint Clair Shores, MI","Detroit, MI","Canton, MI",
                "Fort Lauderdale, FL","Canton, MI","Gilber, AZ","Raleigh, NC","Wyandotte, MI"
            };

            List<string> favFoods = new List<string>
            {
                "0", "French Fries", "Focaccia Barese","tacos","mac and cheese","steak",
                "BBQ","Chicken Fettuccine Alfredo","Pad Thai","tacos","shrimp",
                "Korean BBQ","Katsu","French Fries","lasagna","fried chicken",
                "chicken soup","sushi","hamburger","curry","sushi"
            };

            Console.WriteLine("Welcome to the DevBuild 7.0 Class!");
            Console.WriteLine("This database contains the students' hometowns and favorite foods.\n");

            //Console.WriteLine("Name");
            //Console.WriteLine("====================");
            //for (int i = 1; i <= names.Count-1; i++)
            //{
            //    string flName = names[i];
            //    string hoTown = homeTown[i];
            //    string foods = favFoods[i];

            //    Console.WriteLine($"{i} {names[i]}.");
            //}

            bool goOn = true;
            string no = "Not valid.";
            while (goOn == true)
            {
                try 
                {                     
                    Console.WriteLine("\nWhich student would you like to learn more about? (1-20)");
                    int answer = int.Parse(Console.ReadLine());
                    for (int i = answer; i <= answer; i++)
                    {
                        string fName = fNames[i];
                        string lName = lNames[i];
                        string hoTown = homeTown[i];
                        string foods = favFoods[i];
                        if (i <= 0 || i > 20)
                        {
                            Console.WriteLine(no);
                        }
                                               
                        Console.WriteLine($"Student {i} is {fNames[i]} {lNames[i]}. What would you like to know about {fNames[i]}? (Enter \"hometown\" or \"favorite food\")");
                        string choice = Console.ReadLine().ToLower();

                        //Hometown or Favorite Food
                        for (int j = 0; j <= 1; j++)
                        {

                            if (choice == "hometown")
                            {
                                Console.WriteLine($"{fNames[i]}'s hometown is {homeTown[i]}.");
                                break;
                            }
                            else if (choice == "favorite food")
                            {
                                Console.WriteLine($"{fNames[i]}'s favorite food is {favFoods[1]}.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("That data does not exist. Please try again.");
                                Console.WriteLine("Enter \"hometown\" or \"favorite food\"");
                                string choice2 = Console.ReadLine().ToLower();
                                j = 0;
                                choice = choice2;
                            }
                        }
                    }   
                }
                catch
                {
                    Console.WriteLine(no);
                }
                goOn = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to learn about another student? (y/n)");
            string keepGoing = Console.ReadLine().ToLower();
            if (keepGoing == "y")
            {
                return true;
            }
            else if (keepGoing == "n")
            {
                Console.WriteLine("Thanks for stopping by. See you later!");
                return false;
            }
            else
            {
                Console.WriteLine("Not valid!");
                return Continue();
            }
            
        }

    }
}
