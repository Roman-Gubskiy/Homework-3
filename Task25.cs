using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, в которой даны натуральные числа от 20 до 50. Вывести на консоль те из 
            них, которые делятся на 3, но не делятся на 5.*/

            Console.WriteLine("Цикл for");
            byte rangeStart1 = 20, rangeFinish1 = 50;
            for (int i = rangeStart1; i <= rangeFinish1; i++)


            {
                if ((rangeStart1 % 3 == 0) && (rangeStart1 % 5 != 0))
                {
                    byte divisibleNumbers1 = rangeStart1;
                    Console.WriteLine(divisibleNumbers1);
                }
                rangeStart1++;
            }
            Console.WriteLine("Цикл while");
            byte rangeStart2 = 20, rangeFinish2 = 50;
            while (rangeStart2 <= rangeFinish2)
            {
                if ((rangeStart2 % 3 == 0) && (rangeStart2 % 5 != 0))
                {
                    int divisibleNumbers2 = rangeStart2;
                    Console.WriteLine(divisibleNumbers2);
                }
                rangeStart2++;
            }
            Console.ReadKey();
        }
    }
}
