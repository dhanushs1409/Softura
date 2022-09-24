using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   class NegativeAgeException : Exception
    {
        public NegativeAgeException(string message): base(message)
        {
            
        }
    }

    internal class InvalidAge
    {   public static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new NegativeAgeException("Age cannot be negative!");
            }
            else if (age > 18)
            {
                Console.WriteLine("Eligible for the job");
            }
        }
        public static void Main()
        {   try
            {
                ValidateAge(-12);
            }
            catch(NegativeAgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
