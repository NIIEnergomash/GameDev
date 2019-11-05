/*
 * Усов Андрей
 * 
 * 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечетных положительных чисел. 
 * Сами числа и сумму вывести на экран, используя tryParse;
 * 
 * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
 * При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33
{
    class Program
    {

        static bool CheckCorrect(bool result)
        {
            if(!result)
            {
                Console.WriteLine("Введено некорректное число");
            }
            return result;
        }
        static void Main(string[] args)
        {

            Int32 number;
            Int32 Sum = 0;
            do
            {
                Console.WriteLine("Введите число:");
                // Попытка преобразовать введенную строку в число
                bool result = Int32.TryParse(Console.ReadLine(), out number);

               // если результат преобразования положителен и введенное число нечетное, то добавляем 
               // значение к сумме предыдущих значений

                if (CheckCorrect(result) & number%2==1)
                {
                    Sum += number;
                }
                else
                {
                   if(number!=0)
                    {
                        number = 1;
                    }
                }
             }
            while (number != 0);
            Console.WriteLine($"Сумма чисел = {Sum}");
            Console.ReadLine();
        }
    }
}
