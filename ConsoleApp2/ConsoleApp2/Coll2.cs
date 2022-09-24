using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coll2
    {
        public static void Main()
        {
            SortedList slist = new SortedList();
            slist.Add("S1", "Dhanush");
            slist.Add("S2", "Rajni");
            slist.Add("S3", "Vijay");
            slist.Add("S4", "Kamal");
            foreach (DictionaryEntry s in slist)
            {
                Console.WriteLine("The key is {0}, and the value is {1}", s.Key, s.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Does the list contain Kamal? {0}", slist.Contains("Kamal"));
            slist.RemoveAt(2);
            slist.Remove("S4");
            slist.Add("S5", "Anirudh");
            Console.WriteLine("Does the list contain Dhanush? {0}", slist.ContainsValue("Dhanush"));
            foreach (DictionaryEntry s in slist)
            {
                Console.WriteLine("The key is {0}, and the value is {1}", s.Key, s.Value);
            }
            Queue q = new Queue();
            q.Enqueue("Ajith");
            q.Enqueue("Karthik");
            q.Enqueue("Surya");
            foreach (string s in q)
                Console.WriteLine(s);
            Stack stack = new Stack();
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Pop();
        }
    }
}
