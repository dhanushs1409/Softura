using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Father
    {
        public void Property()
        {
            Console.WriteLine("My property at OMR");
        }
    }
    class Son:Father
    {
        protected void Flat()
        {
            Console.WriteLine("My flat at Vadapalani");
        }
       // public new void Property()
       // {
       //     Console.WriteLine("New property at Mahabalipuram");
       // }
    }
    internal class FatherSon:Son
    {
        public static void Main()
        {
            Son sobj=new Son();
            // sobj.Flat();
            sobj.Property();
            Father fobj=new Father();
            fobj.Property();
            FatherSon obj = new FatherSon();
            obj.Flat();
            Father fobj2 = new Son();
            fobj2.Property();
        }
    }
}
