using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AOC.Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
        }

        

        static void Part1()
        {
            var changes = File.ReadAllLines("input.txt");
            var count = 0;
            foreach (var change in changes)
            {
                var chars = change.ToCharArray();

                var pol = change[0] == '+' ? 1 : -1;
                var value = int.Parse(change.Substring(1));
                count += pol * value;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        static void Part2()
        {
            var changes = File.ReadAllLines("input.txt");
            HashSet<int> freqs = new HashSet<int>();
            var count = 0;
            while (true)
            {
                foreach (var change in changes)
                {
                    freqs.Add(count);
                    var chars = change.ToCharArray();

                    var pol = change[0] == '+' ? 1 : -1;
                    var value = int.Parse(change.Substring(1));
                    count += pol * value;

                    if (freqs.Contains(count))
                    {
                        Console.WriteLine($"Duplicate: {count}");
                        Console.ReadLine();

                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
