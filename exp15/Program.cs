// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.//

using System;

namespace exp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число: ");
            int day=Convert.ToInt32(Console.ReadLine());
            if (day<=0 || day>7)
            {
                Console.WriteLine("Неправильное число");
            }    

            else
            {
                if (day>0 && day<6)
                {
                    Console.WriteLine("Рабочий день");
                }

                else
                {
                    Console.WriteLine("Выходной день");

                }
            }

        }
    }
}
