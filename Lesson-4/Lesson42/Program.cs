/*
   Усов Андрей
 Реализуйте задачу 1 в виде статического класса StaticClass;
 а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson42
{
    class StaticClassA
    {

        public StaticClassA()
        {

        }

        /// <summary>
        /// Функция проверки на делимость одного из двух чисел на число 3
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static bool CheckDerive(int A, int B)
        {
            if (A % 3 == 0 ^ B % 3 == 0)
            {
                //Console.WriteLine("Пара - {0} {1} = true", A, B);
                return true;
            }
            else
            {
                //Console.WriteLine("Пара - {0} {1} = false", A, B);
                return false;
            }
            
        }
        /// <summary>
        /// Функция перебора массива на предмет выявления пар значений, в которых только одно число делится на 3
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindDerive(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (CheckDerive(arr[i], arr[i + 1]))
                {
                    sum++;
                }
            }
            return sum;
        }
     
    }

        class Program
    {
   
        static void Main(string[] args)
        {
            //StaticClassA AClass = new StaticClassA();
            int[] array = new int[20];

            Random RX = new Random();

            // тестовый набор данных
            // int[] test = { 6, 2, 9, 3, 6 };


            // заполняем матрицу случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RX.Next(-10000, 10000);
            }

            // вывод не экран значений матрицы array
            foreach (int v in array)
            {
                Console.Write("{0} ", v);

            }

            // расчет пар значений, в которых только один элемент делится на 3
            Console.WriteLine("Количество пар: {0}", StaticClassA.FindDerive(array));
            // Console.WriteLine("Количество пар: {0}", FindDerive(test));

            Console.ReadLine();

        }
    }
}
