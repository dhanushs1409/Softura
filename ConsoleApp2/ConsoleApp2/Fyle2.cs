using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Fyle2
    {   public static void Main()
        {
            FileStream fs = new FileStream("D:\\Softura Sep22\\Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Learning C# with Visual Studio");
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine("What's your favourite food?");
            sw.Flush();
            sw.Close();
            Console.WriteLine("Done!");
            fs.Close();
            FileStream fs1 = new FileStream("D:\\Softura Sep22\\Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs1.Close();
        }
    }
}
