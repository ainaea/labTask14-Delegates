using System;

namespace MulticastDelegateApp
{  
    public delegate void MultiDel(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            MultiDel addAndMultiply = Add;
            addAndMultiply += Multiply;
            // Console.WriteLine("Enter an integer number: ");
            // return Convert.ToInt32(Console.ReadLine());
            addAndMultiply(numReceptor(),numReceptor());
        }

        static void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        static int numReceptor()
        {
            Console.WriteLine("Enter an integer number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
