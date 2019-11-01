/*
 Усов Андрей
 5. а) Написать программу, которая запрашивает массу и рост человека, 
 вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме; 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24
{
    class Program
    {
        static Double IndexMT(Int32 m, Double h)
        {
            return m / (h * h);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите вес в кг.: ");
            Int32 Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            Double Height = Convert.ToDouble(Console.ReadLine());
            Double Index = IndexMT(Weight, Height);
            Double Edge = 24.5;
            if(Index>Edge)
            {
                Console.WriteLine("Надо бы похудеть");

            }
            else
            {
                if(Index<Edge)
                {
                    Console.WriteLine("Необходимо набрать вес");

                }
                else
                {
                    Console.WriteLine("Всё в норме");

                }
            }
            Console.ReadLine();
        }
    }
}
