using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Loopy_Planets_Challenge //the name of my program and where all the classes are into it
{
   public class prompt      //this class is going to show the text on the Console
    {
        public static void text() //it has to be static and public so other classes can use
        {
            Console.WriteLine("1.Mercury " +"2.Jupiter "+"3.Neptune "+"4.Venus "+"5.Saturn "+"6.Pluto "+"7.Mars "+"8.Uranus "+ "9.Quit");
        }
        }
   public class RunProgram //this class is going to run the program
    {
        public static void run() //void is the data type that return nothing and run is the main of the class runProgram
        {
            int select;
            Console.WriteLine("Select a planet using 1-9");
            string user = Console.ReadLine();
            int.TryParse(user, out select); //convert the string into integer for the calculation
            switch (select) //switch statement with every Planet cases depending the user number entered  
            {
                case 1:
                    Planets.Mercury();
                    break;
                case 2:
                    Planets.Jupiter();
                    break;
                case 3:
                    Planets.Neptune();
                    break;
                case 4:
                    Planets.Venus();
                    break;
                case 5:
                    Planets.Saturn();
                    break;
                case 6:
                    Planets.Pluto();
                    break;
                case 7:
                    Planets.Mars();
                    break;
                case 8:
                    Planets.Uranus();
                    break;

                case 9:
                    Console.WriteLine("Would you like to exit....y/n"); //this case is for closing the Console
                    string choice = Console.ReadLine();
                    if (choice == "y" || choice == "Y") //and this conditions give to the user the opportunity to continue playing or close the Console
                    {

                        prompt.text();
                        RunProgram.run();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("thank you GoodBye");
                        System.Threading.Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                    else //this else statement is if it is any of the before conditions it will show this write line
                    {
                        Console.WriteLine("Sorry that result is not valid");
                        Console.Clear(); //it will clear for beginning again
                        prompt.text();  //it will begin and show the planets text
                        RunProgram.run(); //it will run the program again with the switch statement
                    }
                    break; //this default statement is in case that any of the before cases in the switch statement are true 
                default: Console.WriteLine("This is out of range of the options please try again"); 
                    Console.Clear();
                    prompt.text();
                   RunProgram.run();
                    break;

            }
        }  
    }
    public class Planets //this is the planets class with all the planet objects into it
    {
        public static void Mercury() //these are the functions for the Mercury planet 
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value; //the user value
            double total; //the total calculate with the weight on earth
            if (double.TryParse(user, out value) && value > 0) //condition if making it true if the value is greater than 0

            {
                total = value * 0.37;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y") //condition after asking the user if would like to continue playing
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N") //else if condition closing the console
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else //else condition in case that any of the conditions before were true
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else //last condition making sure the user enter a right value if any of the before conditions were true
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Mercury();
            }
        }
        public static void Jupiter() //these are the functions for jupiter planet and it has the same code just different number to multiply by, all the other objects in this class has the same 
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 2.64;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Jupiter();
            }
        }
        public static void Neptune()
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 1.12;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Neptune();
            }
        }
        public static void Venus()
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 0.88;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Venus();
            }
        }
        public static void Saturn()
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 1.15;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Saturn();
            }
        }
        public static void Pluto()
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 0.04;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Pluto();
            }
        }
        public static void Mars()
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 0.38;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Mars();
            }
        }
        public static void Uranus()
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value;
            double total;
            if (double.TryParse(user, out value) && value > 0)

            {
                total = value * 1.15;
                Console.WriteLine("\n Your Weight is:" + total.ToString("0.0"));
                Console.WriteLine("Would you like to cotinue....y/n");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y")
                {

                    prompt.text();
                    RunProgram.run();
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("thank you GoodBye");
                    System.Threading.Thread.Sleep(0);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry that result is not valid");
                    Console.Clear();
                    prompt.text();
                    RunProgram.run();
                }
            }
            else
            {
                Console.WriteLine("This is not correct please try again");
                Planets.Uranus();
            }
        }
    }
        
    
    class Program //this is the main program for the Console showing everything
    {
       public static void Main(string[] args) 
        {
            prompt.text();
            RunProgram.run();
            Console.ReadLine();
        
        }
    }
}
