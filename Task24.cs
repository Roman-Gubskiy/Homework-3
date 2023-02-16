using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.   
            Напишите программу, которая будет выводить на экран таблицу умножения на 3.*/

            byte a;
            Console.Write("Таблица умножения от 1 до 10, введиче число: ");
            a = byte.Parse(Console.ReadLine());
            // byte a = 3; Умножение на 3 хардкодом
            for (byte i = 1; i < 11; i++)
            {
                byte sum = (byte)(i * a);
                Console.WriteLine($"{i} * {a} = {sum}");
            }
            Console.ReadKey();
        }
    }
}
