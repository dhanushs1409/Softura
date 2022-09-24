using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DivByZero
    {
        public static void Main()
        {
            int x, y, z;
            x = 45;
            y = 0;
            z = 0;
            try
            {
                z = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(z);
            }
        }
    }
}
