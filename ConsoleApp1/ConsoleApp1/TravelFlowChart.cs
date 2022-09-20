using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task1
    internal class TravelFlowChart
    {
        public static void Main()
        {
            String choice;
            Console.WriteLine("\nDo you have travel history?");
            choice = Console.ReadLine();
            if (choice == "yes")
            {
                Console.WriteLine("Do you have temperature?");
                choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("Do you have coughing or sneezing?");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("Take a swab test.");
                    }
                    else if (choice == "no")
                        Console.WriteLine("Quarantine and take fever medicine.");
                }
                else if (choice == "no")
                    Console.WriteLine("Home quarantine for 28 days.");
            }
            else if (choice == "no")
                Console.WriteLine("You are safe, no high risk of COVID 19.");
         
         
        }
    }
}
