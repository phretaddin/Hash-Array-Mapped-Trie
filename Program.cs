using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace HAMT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();

            Hamt<string, string> hamt = new Hamt<string, string>();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            StreamReader file = new StreamReader("dictionary.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                items.Add(line);
            }
            file.Close();

            long memoryBefore = GC.GetTotalMemory(true);
            Stopwatch sw = Stopwatch.StartNew();
            foreach (var s in items)
            {
                hamt.Add(s, s + "a");
            }
            sw.Stop();
            long memoryAfter = GC.GetTotalMemory(true);

            Console.WriteLine("Time in ms taken to add all nodes: {0}", sw.ElapsedMilliseconds);
            Console.WriteLine("Item Count: " + hamt.ItemCount);

            Stopwatch sw2 = Stopwatch.StartNew();
            int missCount = 0;
            foreach (string s in items)
            {
                if (!hamt.Contains(s))
                {
                    missCount++;
                }
            }
            sw2.Stop();

            Console.WriteLine("Failed finding this many items: " + missCount);
            Console.WriteLine("Time in ticks to check contains: " + sw2.ElapsedMilliseconds);
            Console.WriteLine("Total memory used: " + (memoryAfter - memoryBefore).ToString("#,##0"));

            Console.Read();
        }
    }
}
