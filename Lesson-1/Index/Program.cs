/*
 Андрей Усов
 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
 по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
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
            Console.WriteLine("Индекс массы тела: {0:F2}", IndexMT(Weight, Height));
            Console.ReadLine();
        }
    }
}
