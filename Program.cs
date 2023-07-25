using System;
using System.Collections.Generic;

namespace CollectionGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Hashtable ---- Dictionary

            Dictionary<string , object> dt = new Dictionary<string , object>();


            dt.Add("Eid", 101);
            dt.Add("Name", "Ankush");
            dt.Add("Email", "ankush435@gamil.com");
            dt.Add("location", "Mumbai");


            foreach (string key in dt.Keys)
            {
                Console.WriteLine(key + ":" + dt[key]);
            }



            //ArrayList  ------- List
            Console.WriteLine("............................List..........................");

            List<int> lst = new List<int>();
            lst.Add(67);
            lst.Add(27);
            lst.Add(39);
            lst.Add(40);

            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("............................SortedList..........................");

            //SortedList
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(1, "Priya");
            sl.Add(9, "Madhu");
            sl.Add(6, "Anu");
            sl.Add(4, "Shweta");

            foreach (int key in sl.Keys)
            {
                Console.WriteLine(key + ":" + sl[key]);
            }


            // Stack
            Console.WriteLine("............................Stack..........................");
            Stack<string> stk = new Stack<string>();
            stk.Push("Ankit");
            stk.Push("Rahul");
            stk.Push("Pratik");
            stk.Push("Shurabh");

            foreach (string s in stk)
            {
               Console.WriteLine(s);
           
            }

            Console.WriteLine("............................Queue..........................");
            //Queue
            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }
    }
}
