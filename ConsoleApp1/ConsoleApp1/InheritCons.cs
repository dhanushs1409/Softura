using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mother
    {
        string str = null;
        public Mother()
        {
            Console.WriteLine("Mother class constructor invoked...");
        }
        public Mother(string str)
        {
            this.str = str;
            Console.WriteLine("String initialised to {0}",str);
        }
    }
    class Daughter:Mother
    {
        public Daughter()
        {
            Console.WriteLine("Daughter class constructor invoked...");
        }
        public Daughter(string str):base(str)
        {
        
        }
    }
    internal class InheritCons
    {
        public static void Main()
        {
            Daughter dobj = new Daughter();
            Daughter dobj2 = new Daughter("India");
        }
    }
}
