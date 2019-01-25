using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

             //Declare and use a bool, int, double, char, string, and decimal type. 
            string name;   
            int age,rating;
            bool underage = false;
            char select;
            double hours;
            double rate;
            decimal cost;
             
            Console.WriteLine("********Welcome to Enterprice car rentals*********");
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            underage = Underage(age);
            if(underage)
            {   
                while (true)
                {
                    Console.WriteLine($"Hello Mr.{name} please select the type of cars you want to rent: \n1.Hatchback \n2.Sedan \n3.SUV\n4.Crossover \n5.Coupe ");
                    select = Convert.ToChar(Console.ReadLine());
                    if(select== '1' || select== '2' || select== '3' || select== '4' || select== '5') {
                        switch (select) {
                            case '1' :  Console.WriteLine("Rent for Hatchback is $2/Hr\nIf you are okay please  enter number of hours you need: ");
                                    rate = 2;
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 
                                cost = (decimal)TotalCost(hours,rate);
                                 Console.WriteLine($"the cost of Hatchback for {hours} hours is ${cost}");
                                  

                                 break;

                            case '2' :  Console.WriteLine("Rent for Sedan is $4/Hr\nIf you are okay please  enter number of hours you need: ");
                                    rate = 4;
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 
                                 cost = (decimal)TotalCost(hours,rate);
                                 Console.WriteLine($"the cost of Sedan for {hours} hours is ${cost}");
                                 break;

                            case '3' :  Console.WriteLine("Rent for SUV is $8/Hr\nIf you are okay please  enter number of hours you need: ");
                                    rate = 8;
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 
                                 cost = (decimal)TotalCost(hours,rate);
                                 Console.WriteLine($"the cost of SUV for {hours} hours is ${cost}");
                                 break;             
                    
                            case '4' :  Console.WriteLine("Rent for Crossover is $8/Hr\nIf you are okay please  enter number of hours you need: ");
                                    rate = 8;
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 
                                 cost = (decimal)TotalCost(hours,rate);
                                 Console.WriteLine($"the cost of Crossover for {hours} hours is ${cost}");
                                 break;
                            case '5' :  Console.WriteLine("Rent for Coupe is $15/Hr\nIf you are okay please  enter number of hours you need: ");
                                    rate = 8;
                                 hours =Convert.ToDouble(Console.ReadLine());
                                 
                                 cost = (decimal)TotalCost(hours,rate);
                                 Console.WriteLine($"the cost of Coupe for {hours} hours is ${cost}");
                                 break;
                            default: Console.WriteLine("Please select the cars specified in the list: ");
                                break;
                        } 
               
                        Console.WriteLine("Thank you for choosing Enterprice please rate us on 1-10 scale");
                        rating = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Thank you for rating us {rating} Have a great trip!!!!");
                        break;
                    
                    } else {
                        continue;
                    }
                    
                } 
            } else {
                Console.WriteLine($"Sorry {name},we Dont rent cars for age under 25\nThankyou for contacting Enterprice");
            } 
        }
        static double TotalCost(double hours , double rate) {
        return hours*rate;   
        }
        static bool Underage(int age) {
            return age > 25;
        }

    }
            
}
