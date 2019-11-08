/*
   Усов Андрей
 * Дан  целочисленный  массив  из 20 элементов.  
 * Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
 * Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество 
 * пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой 
 * подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов:
 * 6; 2; 9; –3; 6 ответ — 2. 

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson41
{
    class Program
    {
        /// <summary>
        /// Функция проверки на делимость одного из двух чисел на число 3
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static bool CheckDerive(int A,int B)
        {
            if(A%3==0 ^ B%3==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Функция перебора массива на предмет выявления пар значений, в которых только одно число делится на 3
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FindDerive(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                if(CheckDerive(arr[i],arr[i+1]))
                {
                    sum++;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];

            Random RX = new Random();

            // тестовый набор данных
           // int[] test = { 6, 2, 9, 3, 6 };


            // заполняем матрицу случайными числами
            for(int i=0;i<array.Length;i++)
            {
                array[i] = RX.Next(-10000, 10000);
            }

            // вывод не экран значений матрицы array
            foreach(int v in array)
            {
                Console.Write("{0} ", v);

            }

            // расчет пар значений, в которых только один элемент делится на 3
            Console.WriteLine("Количество пар: {0}",FindDerive(array));
           // Console.WriteLine("Количество пар: {0}", FindDerive(test));

            Console.ReadLine();

        }
    }
}
