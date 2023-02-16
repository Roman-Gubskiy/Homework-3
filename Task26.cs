using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу,  которая будет рассчитывать сумму вклада  в банк. Процентную ставку, 
            сумму и срок на которой положили вклад, должен вводить пользователь с клавиатуры. */

            double depositAmount, interestRate, period, contribution;
            Console.Write("Введите сумму вклада: ");
            depositAmount = double.Parse(Console.ReadLine());
            Console.Write("Введите процентную ставку (% в год): ");
            interestRate = double.Parse(Console.ReadLine());
            Console.Write("Введите срок (лет): ");
            period = double.Parse(Console.ReadLine());
            double counter = 0;
            for (int i = 1; i <= period; i++)
            {
                contribution = (depositAmount * interestRate / 100);
                depositAmount += contribution;
                counter += contribution;
            }
            Console.WriteLine($"Сумма процентных выплат: {Math.Round(counter, 2)}");
            Console.WriteLine($"Общая сумма выплат: {Math.Round(depositAmount,2)}");
            Console.ReadKey();
        }
    }
}
