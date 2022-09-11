using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Explore
    {
        public static void Main()
        {
            string str = "Peacock"; 
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Replace("cock","hen"));
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            str = " Little Mount  ";
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.Contains("tt"));
            Console.WriteLine(str.Substring(1, 11));
            Console.WriteLine();
            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine(System.DateTime.Now.ToString());
            var dt = DateTime.Now;
            Console.WriteLine("Long Date: {0:D}",dt);
            Console.WriteLine("Short Date: {0:d}", dt);
            Console.WriteLine("Month: {0:M}", dt);
            Console.WriteLine("Year: {0:Y}", dt);

        }
    }
}
