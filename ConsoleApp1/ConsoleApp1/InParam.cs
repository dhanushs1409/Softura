using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InParam
    {
        public void Func(in int num, out int res)
        {
            res=num;
            Console.WriteLine(res);
        }
        public static void Main()
        {
            InParam inParam = new InParam();
            int x = 0;
            Console.WriteLine("Enter a number : ");
            inParam.Func(Convert.ToInt32(Console.ReadLine()), out x);
            Console.WriteLine(x);
        }
    }
}
