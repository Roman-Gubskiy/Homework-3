using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                
            Напишите программу, запрашивает ввод угла у пользователя и определяет его тип. Использовать 
            конструкцию switch case. (=90 градусов – прямой, <90 – острый, >90 - тупой)*/

            Console.Write("Введите угол от 0° до 90°: ");
            int corner = int.Parse(Console.ReadLine());
            string angleDefinition = (corner == 90) ? "прямой" : (corner < 90) ? "острый" : (corner > 90) ? "тупой" : "ошибка";
            switch (angleDefinition)
            {
                case "прямой":
                    Console.WriteLine($"Угол {corner}° прямой");
                    break;
                case "острый":
                    Console.WriteLine($"Угол {corner}° острый");
                    break;
                case "тупой":
                    Console.WriteLine($"Угол {corner}° тупой");
                    break;
            }
            Console.ReadKey();
        }
    }
}
