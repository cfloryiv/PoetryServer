using PS.BR;
using System;
using System.IO;

namespace PS.Cos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var poems = new Poems
            {
                Path = @"C:\Users\cflor\OneDrive\Poems"
            };
            poems.ImportText();
            var poemsList = poems.GetList();
            foreach(var poem in poemsList)
            {
                Console.WriteLine(poem.Path);
            }
        }
    }
}
