using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    public class Parent
    {
        public void Health()
        {
            Console.WriteLine("Good Health");
        }
    }
    class Child:Parent
    {
        public void Wealth()
        {
            Console.WriteLine("Great Wealth");
        }
    }
    internal class ParentChild
    {
        public static void Main()
        {
            Child cobj = new Child();
            cobj.Health();
            cobj.Wealth();
        }
    }
}
