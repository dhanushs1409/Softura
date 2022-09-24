using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal class Sere1
    {   
//        public void writeFile(string T)
//        {
//            FileStream fs = new FileStream("D:\\Softura Sep22\\Sere2.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
//            xmlSerializer.Serialize(fs,T);
//            
//
//            fs.Close();
//        }
        public void wryte()
        {
            FileStream fs = new FileStream("D:\\Softura Sep22\\Sere1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, "Gulab Jamun");

            fs.Close();
        }
        public void reed()
        {
            FileStream fs = new FileStream("D:\\Softura Sep22\\Sere1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            string str = (string) bf.Deserialize(fs);
            Console.WriteLine(str);
            Console.WriteLine("Done!");
            fs.Close();

        }
        public static void Main()
        {
            Sere1 sere = new Sere1();
            sere.wryte();
            sere.reed();
//            sere.writeFile("String");

        }
    }
}
