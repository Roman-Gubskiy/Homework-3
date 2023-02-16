using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая будет выводить  на экран числа от 1 до 5.  Написать три варианта 
            реализации (while, do...while, for).*/

            Console.WriteLine("Цикл while");
            int counter1 = 0;
            while (counter1 < 5) 
            {
                counter1++;
                Console.WriteLine(counter1);
            }

            Console.WriteLine("Цикл do...while");
            int counter2 = 0;
            do
            {
                counter2++;
                Console.WriteLine(counter2);
            } while (counter2 < 5);
            Console.WriteLine("Цикл for");            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
