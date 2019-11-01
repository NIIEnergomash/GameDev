/*
Усов Андрей
3. С клавиатуры вводятся числа, пока не будет введен 0. 
Подсчитать сумму всех нечетных положительных чисел.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a;
            Int32 Sum = 0;
            do
            {
                Console.WriteLine("Введите число:");
                a=Convert.ToInt32(Console.ReadLine());
                Sum += a;
            }
            while(a!=0);
            Console.WriteLine($"Сумма чисел = {Sum}");
            Console.ReadLine();
        }
    }
}
