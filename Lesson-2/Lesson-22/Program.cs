/*
Андрей Усов 
2. Написать метод подсчета количества цифр числа.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            int Len=0;
            Console.WriteLine("Введите число.");
            a = Console.ReadLine();
            foreach(char x in a)
            {
                Len++;
            }
            Console.WriteLine($"В введенном числе {Len} цифр");
            Console.ReadLine();
        }
    }
}
