using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    abstract class Food
    {
        public abstract void Breakfast();
        public void NormalMethod()
        {
            Console.WriteLine("Normal method declared in abstract class");
        }
    }
    class Continental : Food
    {
        public override void Breakfast()
        {
            Console.WriteLine("Bread, Butter, Jam");
        }

        public void Pastries()
        {
            Console.WriteLine("We have the best pastries");
        }
    }
    class SouthIndian : Food
    {
        public override void Breakfast()
        {
            Console.WriteLine("Dosa, Vada, Idli");
        }
    }
    internal class AbsImplementation
    {
        public static void Main()
        {
            Continental conti = new Continental();
            conti.Breakfast();
            conti.NormalMethod(); //calling a normal function from abstract class
            SouthIndian south = new SouthIndian();
            south.Breakfast();
            south.NormalMethod();
        }
    }
}
