using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application. 
            По представленной блок-схеме составьте программу вычисления функции у 
            при заданном с клавиатуры значение х.*/

            Console.Write("Введите число 'x': ");
            int x = int.Parse(Console.ReadLine());
            if (x <= -20)
            {
                int y = (x * x * x) * 3;
                Console.WriteLine($"Число 'y' = {y}");
            }
            else if (x > -20 && x <= 30)
            {
                if (x > -20 && x <= 30)
                {
                    Console.WriteLine($" y = {Math.Abs(x)}");
                }
            }
            else
            {
                Console.WriteLine($"Число 'y' = {30}");
            }
            Console.ReadKey();
        }
    }
}
