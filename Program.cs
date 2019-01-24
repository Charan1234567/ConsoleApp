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
             bool underage = false;
             char rating;
             double hours;
             decimal cost;
             
            Console.WriteLine("********Welcome to Enterprice car rentals*********");
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if(age > 25){
                
            
            while (!underage)
            {
              Console.WriteLine($"Hello Mr.{name} please select the type of cars you want to rent: \n 1.Hatchback \n 2.Sedan \n 3.SUV\n 4.Crossover \n 5.Coupe ");
                 switch (Console.ReadLine())
                 {
                    case "1" :  Console.WriteLine("Rent for Hatchback is $2/Hr\nIf you are okay please  enter number of hours you need: ");
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 //Console.WriteLine(hours*2);
                                 cost = (decimal)(hours*2);
                                 Console.WriteLine($"the cost for {hours} is ${cost}");
                                 

                                 break;

                     default: break;
                 }        
              return;
            }
            }
            Console.WriteLine($"Sorry {name},we Dont rent cars for age under 25\nThankyou for contacting Enterprice");


            
            }
        }
    }

