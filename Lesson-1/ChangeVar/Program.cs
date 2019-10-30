/*
Андрей Усов 
Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
	б) *без использования третьей переменной.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите переменную №1: ");
            Int32 Var1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите переменную №2: ");
            Int32 Var2 = Convert.ToInt32(Console.ReadLine());
            // а) с использованием третьей переменной;
            Int32 Temp = Var1;
            Var1 = Var2;
            Var2 = Temp;
            Console.WriteLine($"Переменная №1: {Var1}, Переменная №2: {Var2}");
            Console.ReadLine();
            //б) *без использования третьей переменной.
            Var1 = Var1 ^ Var2;
            Var2 = Var2 ^ Var1;
            Var1 = Var1 ^ Var2;
            Console.WriteLine($"Переменная №1: {Var1}, Переменная №2: {Var2}");
            Console.ReadLine();

        }
    }
}
