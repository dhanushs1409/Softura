using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coll1
    {   public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("two");
            al.Add("III");
            al.Add(new object());
            for (int i = 0; i < al.Count; i++)
                Console.WriteLine(al[i]);
            Console.WriteLine();
            ArrayList al2 = new ArrayList();
            al2.Add("Mango");
            al2.Add("Banana");
            al2.Add("Orange");
            al.AddRange(al2);
            foreach (object obj in al)
                Console.WriteLine(obj);

        }
    }
}
