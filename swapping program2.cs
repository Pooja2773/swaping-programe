using System;

namespace ConsoleApp2

{
    class Demo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            b = a + b;
            Console.WriteLine("after the swapping number is:{0} ", a);
            Console.WriteLine("after the swapping number is: {0}", b);
        }
    }
}
