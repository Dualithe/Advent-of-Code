using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace AoC1
{
    class Program
    {

        public static List<string> text = System.IO.File.ReadLines(@"C:\Users\Dualithe\source\repos\Advent-of-Code\AoC1\AoC1\input.txt").ToList();
        public static List<int> input = new List<int>();

        static void Main(string[] args)
        {

            int n = 0;
            foreach (string line in text)
            {
                input.Add(int.Parse(line));
            }
            for (int i = 3; i < input.Count; i++)
            {
                int a = input[i];
                int b = input[i - 1];
                int c = input[i - 2];
                int d = input[i - 3];
                int bcd = b + c + d;
                int abc = a + b + c;
                if (bcd < abc)
                {
                    n++;
                }

            }
            Console.WriteLine(n);
        }

    }
}
