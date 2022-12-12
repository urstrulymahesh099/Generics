using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int intmax = FindMax.FindInMax<int>(8,4,6);
            Console.WriteLine($"(The Maximum Number is  : {intmax})");
            float floatmax = FindMax.FindInMax<float>(8.5f,4.33f,6.7f);
            Console.WriteLine($"(The Maximum Number is  : {floatmax})");
            Char max = FindMax.FindInMax<char>('a', 'b', 'c');
            Console.WriteLine($"(The Maximum Charecter is  : {max})");
        }
    }
}