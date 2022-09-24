using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PropClass
    {
        public string StuID { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public static void Main()
        {
            PropClass pclass = new PropClass();
            pclass.StuID = "S101";
            pclass.Name = "Rohit";
            pclass.age = 22;

            Console.WriteLine("ID : {0}\tName : {1}\tAge : {2}",pclass.StuID,pclass.Name,pclass.age );

        }
    }
}
