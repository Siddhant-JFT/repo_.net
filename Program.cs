using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num2 + num1;
            int mul = num2 * num1;
            int div = num1 / num2;
            int sub = num1 - num2;

            Console.WriteLine($"{num1} added to {num2} is "+ sum);
            Console.WriteLine($"{num2} subtracted from {num1} is " + sub);
            Console.WriteLine($"{num1} multiplied by {num2} is " + mul);
            Console.WriteLine($"{num1} divided by {num2} is " + div);
        }
    }
}
