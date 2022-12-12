using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float max = FindMax.FindInMax<float>(8.3f, 4.5f, 3.5f);
            Console.WriteLine($"The maximum Number is :{max}");
            int Findmax = FindMax.FindInMax<int>(8, 4, 3);
            Console.WriteLine($"The maximum Number is :{max}");
        }
    }
}