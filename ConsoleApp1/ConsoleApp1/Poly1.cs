using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Poly1
    {
        int n1, n2;
        public void add()
        {
            n1 = 12;
            n2 = 13;
            Console.WriteLine(n1+ n2);
        }
        public void add(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            Console.WriteLine(n1+ n2);
        }
        public static void Main()
        {
            Poly1 poly1 = new Poly1();
            poly1.add();
            poly1.add(67, 40);

        }
    }
}
