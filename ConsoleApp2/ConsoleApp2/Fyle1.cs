using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{   
    internal class Fyle1
    {
        public static void Main()
        {
            FileStream fs = new FileStream("D:\\Softura Sep22\\Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("Super Star\nRajnikanth");
            bw.Flush();
            fs.Close();
            FileStream fs1 = new FileStream("D:\\Softura Sep22\\Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            Console.WriteLine(br.ReadString());
            fs1.Close();

        }
    }
}
