using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая поможет первокласнику Пети, у которого  m рублей .Мороженое 
            стоит k рублей. Петя решил наесться досыта мороженого, для этого он покупал по одному 
            мороженому и съедал его до тех пор, пока ему хватало денег. Как Пете узнать, сколько денег 
            останется у него в конце концов? учтите, что петя делить еще не умеет, а умеет только вычитать и 
            складывать. сколько мороженых он может съесть?.*/


            //Вариант решения без вопроса
            uint k = 50, quantity = 0;
            Console.WriteLine("Морожиное стоит 50 грн. ");
            Console.Write("Введи сколько денег у тебя есть?: ");
            uint m = uint.Parse(Console.ReadLine());
            while (k <= m && k > 0)
            {
                m -= k;
                quantity++;
            }
            Console.WriteLine($"твоя задача: {m} грн.");
            Console.WriteLine($"Количество купленного мороженого: {quantity} шт.");
            Console.ReadKey();

            //Вариант решения с вопросом и отменой

            uint m1, k1 = 50, counter1 = 0, counter2 = 1;
            string y;
            Console.WriteLine("Морожиное стоит 50 грн. ");
            Console.Write("Введи сколько денег у тебя есть?: ");
            m1 = uint.Parse(Console.ReadLine());            
            while (k1 <= m1 && k1 > 0)
            {
                Console.Write($"Берешь {counter2++} морожиное? введи да, если наелся нажми Enter: ");
                if ("да" == (y = (Console.ReadLine())))

                {
                    m1 -= k1;
                    counter1++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"твоя задача: {m1} грн.");
            Console.WriteLine($"Количество купленного мороженого: {counter1} шт.");
            Console.ReadKey();
        }
    }
}
