using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, где пользователь вводит любое целое положительное число. А программа 
            суммирует все числа от 1 до введенного пользователем числа.*/

            Console.Write("Введите любое целое положительное число: ");

            int a = int.Parse(Console.ReadLine());
            uint b = 0;
            uint d = 0;

            if (0 <= a)
            {
                while (b < a)
                {
                    b++;
                    d += b;
                    //Console.WriteLine(b); поочередный вывод всех промежуточных чисел
                    //Console.WriteLine(d); поочередный вывод всех сложеных чисел
                }
                Console.WriteLine($"Общая сумма от 1 до {a} = {d}");
            }
            else
            {
                Console.Write("Неверный ввод, число отрицательное!");
            }
            Console.ReadKey();
        }
    }
}
