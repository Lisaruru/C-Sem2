// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

namespace exp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number= new Random().Next(100,1000);
            int number1=number%100/10;
            Console.WriteLine(number);
            Console.Write(number1);
        }
    }
}
