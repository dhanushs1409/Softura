using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OutParam
    {
        public void display(int num1, int num2, out int res)
        {
            //res = 100;
            //res += res;
            res = num1 + num2;
        }
        public static void Main()
        {
            OutParam obj = new OutParam();
            int z;
            //Console.WriteLine(z);
            obj.display(420, 69, out z);
            Console.WriteLine(z);
        
        }
    }
}
