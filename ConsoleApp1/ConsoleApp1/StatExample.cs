using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StatExample
    {
        static int count = 0;
        int x = 1;
        public static void Counter()
        {
            Console.WriteLine(count++);
        }
        public void add(ref int num1, ref int num2)
        {
            Console.WriteLine(num1+ num2);
        }
        public void Calc(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public void Kounter()
        {
            Console.WriteLine(x++);
        }
        public static void Main()
        {   
            StatExample stat = new StatExample();
            StatExample stat1 = new StatExample();
            StatExample stat2 = new StatExample();
            stat.Calc(2, 4);
            Console.WriteLine("Enter two numbers : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            stat.add(ref x1, ref x2);
            Counter();
            Counter();
            Counter();
            Counter();
            Counter();
            stat.Kounter();
            stat1.Kounter();
            stat2.Kounter();
        }
    }
}
