using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{   
    public class patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
    }
    internal class Sere2
    {
        public static void Main()
        {
            var pat = new patient()
            {
                ID = 1234,
                Name = "Krishna",
                DoB = new DateTime(2000, 12, 28)
            };
            var serializer = new XmlSerializer(typeof(patient));
            using(var stream = new StreamWriter("sere.xml"))
            {
                serializer.Serialize(stream, pat);
            }
        }
    }
}
