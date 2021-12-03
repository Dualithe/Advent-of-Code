using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AoC3
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> text = System.IO.File.ReadLines(@"C:\Users\Dualithe\source\repos\Advent-of-Code\AoC3\AoC3\input.txt").ToList();
            List<int> sums = new List<int>(new int[text[0].Length]);
            List<char> binary = new List<char>(text[0].Length);
            List<char> nonbinary = new List<char>(text[0].Length);
            foreach (string o in text)
            {
                for (int c = 0; c < o.Length; c++)
                {
                    if (o[c] == '1')
                    {
                        sums[c] += 1;
                    }
                }
            }
            foreach (int i in sums)
            {
                Console.WriteLine(i);
                if (i * 2 < text.Count)
                {
                    binary.Add('0');
                    nonbinary.Add('1');
                }
                else if (i * 2 > text.Count)
                {
                    binary.Add('1');
                    nonbinary.Add('0');
                }
            }
            string notdec = string.Join("", binary);
            string epsilon = string.Join("", nonbinary);

            Console.WriteLine(Convert.ToInt32(notdec, 2).ToString());
            Console.WriteLine(Convert.ToInt32(epsilon, 2).ToString());
            Console.WriteLine(Int32.Parse(Convert.ToInt32(notdec, 2).ToString())* Int32.Parse(Convert.ToInt32(epsilon, 2).ToString()));
        }
    }
}
