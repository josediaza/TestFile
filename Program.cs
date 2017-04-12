using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Loopy_Planets_Challenge 
{
   public class prompt      
    {
        public static void text() 
        {
            Console.WriteLine("1.Mercury " +"2.Jupiter "+"3.Neptune "+"4.Venus "+"5.Saturn "+"6.Pluto "+"7.Mars "+"8.Uranus "+ "9.Quit");
        }
        }
   public class RunProgram 
    {
        public static void run() 
        {
            int select;
            Console.WriteLine("Select a planet using 1-9");
            string user = Console.ReadLine();
            int.TryParse(user, out select); 
            switch (select)   
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
                    Console.WriteLine("Would you like to exit....y/n"); 
                    string choice = Console.ReadLine();
                    if (choice == "y" || choice == "Y") 
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
                    else 
                    {
                        Console.WriteLine("Sorry that result is not valid");
                        Console.Clear(); 
                        prompt.text();  
                        RunProgram.run(); 
                    }
                    break; 
                default: Console.WriteLine("This is out of range of the options please try again"); 
                    Console.Clear();
                    prompt.text();
                   RunProgram.run();
                    break;

            }
        }  
    }
    public class Planets 
    {
        public static void Mercury() //these are the functions for the Mercury planet 
        {
            Console.WriteLine("Enter your weight");
            string user = Console.ReadLine();
            double value; 
            double total; 
            if (double.TryParse(user, out value) && value > 0) 

            {
                total = value * 0.37;
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
                Planets.Mercury();
            }
        }
        public static void Jupiter()  
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
        
    
    class Program 
    {
       public static void Main(string[] args) 
        {
            prompt.text();
            RunProgram.run();
            Console.ReadLine();
        
        }
    }
}

}
