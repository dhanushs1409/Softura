using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cons
    {
        int x;
        public Cons()
        {
            Console.WriteLine("Constructor invoked...");
            x = 25;
        }
        public Cons(int x)
        {
            this.x= x;
            Console.WriteLine("Parameterised constructor invoked...");
        }
        public void Show()
        {
            Console.WriteLine("First constructor program");
        }
        public static void Main()
        {
            Cons obj = new Cons();
            obj.Show();
            Console.WriteLine(obj.x);
            Console.WriteLine("Enter a value : ");
            int consx = Convert.ToInt32(Console.ReadLine());
            Cons obj2 = new Cons(consx);
            Console.WriteLine(obj2.x);
        }

    }
}
