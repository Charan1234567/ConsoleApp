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
             double rate;
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
                                    rate = 2;
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 //Console.WriteLine(hours*2);
                                 cost = (decimal)TotalCost(hours,rate);
                                 Console.WriteLine($"the cost of Hatchback for {hours} hours is ${cost}");
                                 

                                 break;

                     default: break;
                 } 
                 Console.WriteLine("Thank you for choosing Enterprice please rate us on 1-10 scale");   
                 rating = (char)Convert.ToInt32(Console.ReadLine());   
                  Console.WriteLine($"Thank you for rating us {rating} Have a great trip!!!!");
              return;
            }
            }
            

            else{
            Console.WriteLine($"Sorry {name},we Dont rent cars for age under 25\nThankyou for contacting Enterprice");
            }

            
            }
            static double TotalCost(double hours , double rate){
                return hours*rate;
            }
        }
    }

