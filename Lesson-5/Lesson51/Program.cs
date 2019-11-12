/*
 * Усов Андрей
 * Создать программу, которая будет проверять корректность ввода логина.
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
 * при этом цифра не может быть первой:
а) без использования регулярных выражений;

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson51
{
    class Program
    {
        /// <summary>
        /// Функция проверки принадлежности буквы к латинскому алфавиту
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static bool IsLatinLetter(char a)
        {
            int CharValue = (int)a;
            // проверяем, попадает ли буква в латинский алфавит
            if ((CharValue>=65 & CharValue <=90)| (CharValue >= 97 & CharValue <= 120))
            {
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine($"{LoginCorrect}");

        }
        static void Main(string[] args)
        {
            bool LoginCorrect = true;
            Console.Write("Введите логин: ");
            string EnterLine = Console.ReadLine();
            // проверяем длину введенного логина
            if (EnterLine.Length <= 10 & EnterLine.Length >= 2)
            {
                // проверяем первую букву, если она - латинская буква, идем дальше
                if (IsLatinLetter(EnterLine[0]))
                {
                    for (int i = 1; i < EnterLine.Length; i++)
                    {
                        if ((!IsLatinLetter(EnterLine[i])) & !char.IsNumber(EnterLine[i]))
                        {
                            LoginCorrect = false;

                        }
                    }
                }
                else
                {
                    LoginCorrect = false;
                }
            }
            else
            {
                LoginCorrect = false;
            }
            if (LoginCorrect)
            {
                Console.WriteLine("Логин введен корректно");
            }
            else
            {
                Console.WriteLine("Логин введен не корректно");
            }
            Console.ReadLine();
        }
    }
}
