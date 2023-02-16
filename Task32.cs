using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                
            Напишите программу, которая будет складывать, вычитать, умножать или делить два числа. 
            Числа и знак операции вводятся пользователем. После выполнения вычисления программа не 
            должна завершаться, а должна запрашивать новые данные для вычислений. Завершение 
            программы должно выполняться при вводе символа '0' в качестве знака операции. Если 
            пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об 
            ошибке и снова запрашивать знак операции. Также сообщать пользователю о невозможности 
            деления на ноль, если он ввел 0 в качестве делителя.*/

            double num1, num2;
            string actions;
            start://Возврат
            Console.WriteLine("Для  завершения работы введите - '0' ");
            Console.Write("Введите действие '+' '-' '*' '/'  ");
            actions = (Console.ReadLine());
            //Проверка на недопустимые символы
            if (actions != "+" & actions != "-" & actions != "*" & actions != "/" & actions != "0")
            {
                Console.WriteLine($"Вы выбрали неверное действие!");
                goto start;
            }            
            if (actions != "0") 
            {
                while (true)
                {
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (actions == "+")
                    {
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        goto start;
                    }
                    else if (actions == "-")
                    {
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        goto start;
                    }
                    else if (actions == "*")
                    {
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        goto start;
                    }
                    else if (actions == "/")
                    {
                        if (num2 != 0) // исключение деления на ноль 
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine($"Деление на 0 невозможно!");
                            goto start;
                        }
                    }
                }       
            }
            else
            {
                Console.WriteLine($"Вы выбрали 0 приложение будет закрыто!");                
            }
            Console.ReadKey();
        }
    }
}
