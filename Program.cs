using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi! what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, "+ name + "! Nice to meet you!");
        }
    }
}
