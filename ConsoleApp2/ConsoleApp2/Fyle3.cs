using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Fyle3
    {
        public static void Main()
        {
            FileInfo fi = new FileInfo("D:\\Softura Sep22\\Test.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine("Done!");

            DirectoryInfo directory = new DirectoryInfo("C:\\Windows");
            Console.WriteLine(directory.Parent);
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Name);
            foreach(object o in directory.GetFiles())
                Console.WriteLine(o.ToString());
            Console.WriteLine();
            foreach(object ob in directory.GetDirectories())
                Console.WriteLine(ob.ToString());
            Console.WriteLine();
        }
    }
}
