using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Methods
    {
        public void addTwoNos()
        {
            int num1, num2;
            num1 = 234;
            num2 = 987;
            Console.WriteLine(num1+num2);
        }
        public void Show()
        {
            Console.WriteLine("Learning Methods");
        }
        public static void Main()
        {
            Methods obj = new Methods();
            obj.addTwoNos();
            obj.addTwoNos();
            obj.Show();

        }

    }
}
