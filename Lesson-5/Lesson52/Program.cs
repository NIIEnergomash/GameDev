/*
    Усов Андрей

 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.

 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson52
{

    public static class Message
    {
        /// <summary>
        /// Функция фильтрации текста. Выводит строку, в которой содержатся слова с длиной, меньшей FilterLength
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="FilterLength"></param>
        /// <returns></returns>
        public static StringBuilder MessageFilter(string Text, int FilterLength)
        {
            StringBuilder RB = new StringBuilder();
            string[] Temp = Text.Split(' ');
            foreach (var Word in Temp)
            {
                if (Word.Length <= FilterLength)
                {
                    RB.Append(Word);
                    RB.Append(' ');
                    //Console.WriteLine($"{Word}");
                }
            }
            return RB;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string TextTemp;
            Console.Write("Введите строку: ");
            TextTemp= Console.ReadLine();
            Console.Write("Введите количество букв в слове, подлежащих выводу на экран: ");
            int LetterCount = Convert.ToInt32(Console.ReadLine());

            StringBuilder Result;
            //Вызов функции фильтрации
            Result = Message.MessageFilter(TextTemp, LetterCount);
            //string[] Temp = TextTemp.Split(' ');
            //for (int i = 0; i < Result.Length; i++)
            {
                Console.WriteLine($"{Result}");
            }
            Console.ReadLine();
        }
    }
}
