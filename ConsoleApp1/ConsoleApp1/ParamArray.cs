using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ParamArray
    {
        int tot, avg;
        public void MarkCal(int[] marks)
        {
            for(int i = 0; i < marks.Length; i++)
            {   
                tot += marks[i];
                avg = tot / marks.Length;
            }
            Console.WriteLine("The total is {0} and the average is {1}", tot, avg);
        }
        public static void Main()
        {
            int[] m = { 98, 97, 96, 95, 99 };
            ParamArray parray = new ParamArray();
            parray.MarkCal(m);
        }
    }
}
