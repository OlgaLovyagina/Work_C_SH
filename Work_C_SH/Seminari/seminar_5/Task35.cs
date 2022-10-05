using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_5
{
    /// <summary>
    /// Задайте одномерный массив из 10 случайных чисел. 
    /// Найдите количество элементов массива, значения которых лежат в
    /// отрезке[10, 99]. 
    /// [5, 18, 123, 6, 2] -> 1 
    /// [1, 2, 3, 6, 2] -> 0 
    /// [10, 11, 12, 13, 14] -> 5
    /// </summary>
    internal class Task35
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 10;
            int[] numbers = new int[size];
            FillArrey(numbers, -100, 100);
            FindArrey(numbers);
        }
        static void FillArrey(int[] numbers, int minValue = -100, int maxValue = 1000)

        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) // цикл на заполнения массива
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + "  "); //показывает заполненный массив
            }
            Console.WriteLine();
        }
        /// <summary>
        /// ищет количество нужных чисел в массиве
        /// </summary>
        /// <param name="numbers"></param>
        static void FindArrey(int [] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10 && numbers[i] <= 100)
                {
                    count++;
                }
            }
            Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке[10, 99] = " +  count);
        }
    }

}
