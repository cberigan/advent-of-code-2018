using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();


            Part2();
           
        }

        private static void Part2()
        {
            var ids = File.ReadAllLines("input.txt");
            for (int i = 0; i < ids.Length; i++)
            {
                var id = ids[i].ToCharArray();
                for (int j = 1; j < ids.Length; j++)
                {
                    var id2 = ids[j].ToCharArray();
                    var diff = 0;
                    for (int z = 0; z < id2.Length; z++)
                    {
                        if(id[z] != id2[z])
                        {
                            diff++;
                        }
                    }

                    if (diff == 1)
                    {
                        //if here then we found it
                        Console.WriteLine($"{new string(id)}");
                        Console.WriteLine($"{new string(id2)}");
                        Console.ReadLine();
                    }
                    
                }
            }  
        }


        static void Part1()
        {
            var trips = 0;
            var dubs = 0;

            var ids = File.ReadAllLines("input.txt");
            foreach (var id in ids)
            {
                Dictionary<char, int> letterCounts = new Dictionary<char, int>();

                var chars = id.ToCharArray();
                foreach (var c in chars)
                {
                    if (letterCounts.ContainsKey(c))
                        letterCounts[c]++;
                    else
                        letterCounts.Add(c, 1);
                }



                trips += letterCounts.Values.Contains(3) ? 1 : 0;
                dubs += letterCounts.Values.Contains(2) ? 1 : 0;
            }
            Console.WriteLine($"{trips * dubs}");
            Console.ReadLine();
        }
    }
}
