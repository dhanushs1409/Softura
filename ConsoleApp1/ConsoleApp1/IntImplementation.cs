using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    class Human:Animal,LivingBeings
    {
        public void ehabit()
        {
            Console.WriteLine("Eats cooked food");
        }
        public void habitat()
        {
            Console.WriteLine("Constructs building and resides");
        }
    }
    class Carnivores : Animal
    {
        public void ehabit()
        {
            Console.WriteLine("Eats animal");
        }
    }
    internal class IntImplementation
    {
        public static void Main()
        {
            Human human = new Human();
            human.ehabit();
            human.habitat();
            Carnivores carnivores = new Carnivores();
            carnivores.ehabit();
        }
    }
}
