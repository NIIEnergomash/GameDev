/*
Андрей Усов

Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            String Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            String Surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            String Age = Console.ReadLine();
            Console.Write("Введите рост: ");
            String Height = Console.ReadLine();
            Console.Write("Введите вес: ");
            String Weight = Console.ReadLine();
            // а) используя склеивание;
            Console.WriteLine("Имя: " + Name + ", Фамилия: " + Surname + ", Возраст: " + Age +
                              ", Рост: " + Height + ", Вес: " + Weight);
            Console.ReadLine();
            // б) используя форматированный вывод;
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", Name, Surname, Age, Height, Weight);
            Console.ReadLine();
            // в) используя вывод со знаком $.
            Console.WriteLine($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}, Рост: {Height}, Вес: {Weight}");
            Console.ReadLine();
        }
    }
}
