using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> hashSet = new HashSet<string>();

            string[] myString = {"hello" , "world", "ola", "world", "mundo"};

            IEnumerable<string>[] collections = {list, stack, queue, hashSet };
        
            foreach(string s in myString)
            {
                list.Add(s);
                stack.Push(s);
                queue.Enqueue(s);
                hashSet.Add(s);
            }

            foreach (IEnumerable<string> collection in collections)
            {
                Console.WriteLine(collection.GetType().Name);
                foreach(string s in collection)
                {
                    Console.WriteLine($"\n{s}");
                }
            }

        }
    }
}
