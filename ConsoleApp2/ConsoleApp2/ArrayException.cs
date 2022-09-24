using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArrayException
    {
        public static void Main()
        {
            int[] arr;
            arr = new int[4];
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = i;
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            for (int j = 0; j < arr.Length; j++)
                Console.WriteLine(arr[j]);
        }
    }
}
