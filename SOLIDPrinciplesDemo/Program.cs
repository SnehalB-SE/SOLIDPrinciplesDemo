using System;

namespace SOLIDPrinciplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LSP_Fruit fruit = new Apple();
            Console.WriteLine(fruit.GetColor());

            fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
