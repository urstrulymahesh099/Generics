using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float max = FindMax.FindInMax(8.3f, 4.5f, 3.5f);
            Console.WriteLine($"The maximum Number is :{max}");
        }
    }
}