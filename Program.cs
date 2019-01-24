using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

             //Declare and use a bool, int, double, char, string, and decimal type. 
             string name;   
             int age;
             
            Console.WriteLine("********Welcome to Enterprice car rentals*********");
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            while (age > 25)
            {
              Console.WriteLine($"Hello Mr.{name} please select the type of cars you want to rent: \n 1.Hatchback \n 2.Sedan \n 3.SUV\n 4.Crossover \n 5.Coupe ");
                 switch (Console.ReadLine())
                 {
                    case "1" :  Console.WriteLine("Rent for Hatchback is $10/Day\n If you are okay please hit enter: ");
                                Console.ReadKey();
                                 Console.WriteLine("enter part");
                                 break;

                     default: break;
                 }        
              return;
            }
            Console.WriteLine($"Sorry {name},we Dont rent cars for age under 25\nThankyou for contacting Enterprice");


            
            }
        }
    }

