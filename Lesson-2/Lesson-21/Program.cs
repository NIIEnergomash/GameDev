/*
 Усов Андрей
 1. Написать метод, возвращающий минимальное из трех чисел.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, min;
            Console.WriteLine("Введите три целых числа.");
            Console.Write("Первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b & a < c)
            {
                min = a;
            }
            else
            {
                if (b < c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }
            Console.WriteLine("Наименьшее число {0}", min);
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();

        }
    }
}
