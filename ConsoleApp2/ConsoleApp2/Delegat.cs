using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Delegat
    {
        public delegate void SimDelegate();
        public void disp()
        {
            Console.WriteLine("Method invoked by delegate");
        }
        public void displan()
        {
            Console.WriteLine("Method invoked by delegate2");
        }
        public void displace()
        {
            Console.WriteLine("Method invoked by delegate3");
        }
        public static void Main()
        {
            Delegat delegat = new Delegat();
            SimDelegate sim = new SimDelegate(delegat.displan);
            sim();
        }
    }
}
