using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                   
            Напишите программу,  в которой запросите пользователя ввести два числа A и B (A<B), если (A>B 
            выведите соответствующее предупреждение) и выведите суму всех чисел расположенных между 
            данными числами на экран. Дано два числа A и B (A<B) выведите все нечетные значения, 
            расположенные между данными числами. */

            Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            int d = 0;
            if (a > b)
            {
                Console.WriteLine("Число А больше B");
                while (a > b)
                {
                    b++;
                    d += b;
                }
                Console.WriteLine($"Общая сумма промежуточных чисел {d}");
            }
            else if (a < b)
            {
                //Вывод чисел от мельшего к большему 
                Console.WriteLine("Число B больше A");
                Console.WriteLine($"Промежуточные нечётные числа");
                while (a < b)
                {
                    a++;
                    if (!(a % 2 == 0)) // (b % 2 != 0) как вариант
                    {
                        Console.Write($"{a},");
                    }
                }
                ////Вывод чисел от большего к меньшему 
                //Console.WriteLine("Число B больше A");
                //Console.WriteLine($"Промежуточные нечётные числа");
                //while (a < b)
                //{
                //    b--;
                //    if (!(b % 2 == 0)) // (b % 2 != 0) как вариант
                //    {
                //        Console.Write($"{b},");
                //    }
                //}
            }
            Console.ReadKey();
        }
    }
}
