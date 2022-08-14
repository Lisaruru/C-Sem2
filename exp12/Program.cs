//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.//
using System;

namespace exp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            long usernumber;
            long.TryParse(Console.ReadLine(), out usernumber);
            if (usernumber <100)
            {
                Console.WriteLine("Третьей цифры нет");
            }
             else
             {
                while (usernumber>=1000)
                {
                    usernumber=usernumber/10;
                 
                }
                
                Console.WriteLine(usernumber%10);
                

               }

        }
   }
}