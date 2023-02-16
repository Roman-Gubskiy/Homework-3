using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                
            Напишите программу, которая определяет, у какой фигуры площадь больше (квадрата или круга). 
            Пользователь вводит с клавиатуры радиус круга и сторону квадрата. Для решения задачи 
            использовать тернарный оператор.*/

            double circle, square, comparison;
            Console.Write("Введите радиуc круга: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            double s = double.Parse(Console.ReadLine());
            circle = (Math.PI * (r * r));
            square = (s * s);
            comparison = circle > square ? circle : square;
            string figure = circle > square ? "круга" : "квадрата";
            Console.WriteLine($"Площадь круга = {(Math.PI * (r * r))}");
            Console.WriteLine($"Площадь квадрата = {s * s}");
            Console.WriteLine($"Бльше площадь {figure} она = {Math.Round(comparison,2)}");
            Console.ReadKey();
        }
    }
}
