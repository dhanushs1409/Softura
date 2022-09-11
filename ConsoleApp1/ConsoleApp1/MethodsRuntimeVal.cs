using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodsRuntimeVal
    {
        int num1, num2;
        public void Sum(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
            Console.WriteLine("Value of num1 is {0}", num1);
            Console.WriteLine("Value of num2 is {0}", num2);
            Console.WriteLine(num1 + num2);

        }
        public static void Main()
        {
            MethodsRuntimeVal obj = new MethodsRuntimeVal();
            obj.Sum(2, 4);
            obj.Sum(3, 5);
            Console.WriteLine("Enter two numbers : ");
            int val1=Convert.ToInt32(Console.ReadLine());
            int val2=Convert.ToInt32(Console.ReadLine());
            obj.Sum(val1, val2);
            MethodsRuntimeVal obj1 = new MethodsRuntimeVal();
            MethodsRuntimeVal obj2 = new MethodsRuntimeVal();
            obj1.Sum(98, 99);
            obj2.Sum(202, 404);
        }
    }
}
