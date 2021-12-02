using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AoC2
{
    class Program
    {
        public static List<string> text = System.IO.File.ReadLines(@"C:\Users\Dualithe\source\repos\AoC2\AoC2\input.txt").ToList();

        static void Main(string[] args)
        {
            string f = "forward";
            string u = "up";
            string d = "down";
            int forward = 0;
            int depth = 0;
            int aim = 0;
            for (int i = 0; i < text.Count; i++)
            {
                if (Regex.Match(text[i], f).Success)
                {
                    string[] fwd = text[i].Split(' ');
                    forward += Int32.Parse(fwd[1]);
                    depth += Int32.Parse(fwd[1])*aim;
                }
                else if (Regex.Match(text[i], u).Success)
                {
                    string[] up = text[i].Split(' ');
                    aim -= Int32.Parse(up[1]);
                }
                else if (Regex.Match(text[i], d).Success)
                {
                    string[] down = text[i].Split(' ');
                    aim += Int32.Parse(down[1]);
                }
            }
            Console.WriteLine(forward +"   "+ depth + "\n");
            Console.WriteLine(forward*depth);
        }
    }
}
