using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coll3
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach(int i in list)
                Console.WriteLine(i);
            Console.WriteLine();
            list.Insert(0, 0);
            Console.WriteLine("List done.");
            LinkedList<string> ll = new LinkedList<string>();
            var first = ll.AddFirst("A");
            var last = ll.AddLast("z");
            ll.AddBefore(last, "Y");
            ll.AddAfter(first, "B");
            foreach(string str in ll)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            LinkedListNode<string> node = ll.Find("Y");
            ll.AddBefore(node, "X");
            foreach (string str in ll)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            node = ll.Find("B");
            ll.AddAfter(node, "C");
            foreach (string str in ll)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Linked List done.");

            SortedList<int, string> list2 = new SortedList<int, string>();
            list2.Add(1, "Dhanush");
            list2.Add(2, "Vikram");
            list2.Add(3, "Amar");

            Dictionary<int, string> dic = new Dictionary<int, string>();
            //SortedDictionary<int, string> dic2 = new SortedDictionary<int, string>();
            dic.Add(11, "Guindy");
            dic.Add(12, "Ekkatuthangal");
            dic.Add(13, "Central");
            dic.Add(14, "Egmore");
            foreach(object o in dic)
                Console.WriteLine("The key-value pair is : "+o);
            Console.WriteLine();
            Console.WriteLine("Does the dictionary contain Egmore? "+ dic.ContainsValue("Egmore"));

        }
    }
}
