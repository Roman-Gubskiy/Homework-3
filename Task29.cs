using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                      
            Напишите программу, в которой создайте две целочисленные переменные и задайте им 
            некоторые значения. Применяя технику вложенных циклов, нарисуйте прямоугольник из 
            звездочек. Используйте значения ранее созданных переменных для указания высоты и ширины 
            прямоугольника*/


            byte b =10, c = 40;
            Console.WriteLine("Решение циклом for");
            for (byte i = 0; i < b; i++) //высота
            {
                for (byte y = 0; y < c; y++) //ширина
                {
                    Console.Write("*");               
                }
                Console.Write("\n"); //новая строка
            }

            Console.Write("Введите высоту прямоугольника: ");
            uint height = uint.Parse(Console.ReadLine());
            Console.Write("Введите ширина прямоугольника: ");
            uint width = uint.Parse(Console.ReadLine());
            for (uint i = 0; i < height; i++) //высота
            {
                for (uint y = 0; y < width; y++) //ширина
                {
                    Console.Write("*");
                }
                Console.Write("\n"); //новая строка
            }
            Console.ReadKey();
        }
    }
}
