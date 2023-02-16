using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                      
            Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи, сколько 
            указал пользователь. Например, если на ввод поступило число 6, то вывод должен содержать 
            шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. (Числа Фибоначчи -  элементы числовой 
            последовательности,  в которой первые два числа равны либо 1 и 1, либо 0 и 1, а каждое 
            последующее число равно сумме двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 
            55, 89).*/

            int a = 0, b = 1;
            Console.Write("Введите любое целое положительное число: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b += temp; // сокращенная форма b = temp + b;
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
