using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int max = FindMax.FindInMax(8, 4, 3);
            Console.WriteLine($"The maximum Number is :{max}");
        }
    }
}