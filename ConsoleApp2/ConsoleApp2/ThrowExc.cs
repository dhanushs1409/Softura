using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer
    {
        public string Name { get; set; }
    }
    internal class ThrowExc
    {   public static void CustomerDetails(Customer cust)
        {   if(cust==null)
            {
                throw new Exception("Customer name not given");
            }
            Console.WriteLine(cust.Name);
        }
        public static void Main()
        {
            Customer cst = null;
            Console.WriteLine((bool)(cst==null));
            cst = new Customer() { Name = "Gopi"};
            Console.WriteLine(cst.Equals(null));
            try
            {
                CustomerDetails(cst);
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }
    }
}
