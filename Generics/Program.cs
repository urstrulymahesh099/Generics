using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Char max = FindMax.FindInMax('a', 'b', 'c');
            Console.WriteLine($"(The Maximum Charecter is  : {max})");
        }
    }
}