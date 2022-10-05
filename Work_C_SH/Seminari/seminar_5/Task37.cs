using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_5
{

    /// <summary>
    /// : Найдите произведение пар чисел в одномерном массиве. 
    /// Парой считаем первый и последний элемент, второй и предпоследний 
    /// и т.д.Результат запишите в новом массиве. 
    /// [1 2 3 4 5] -> 5 8 3 
    /// [6 7 3 6] -> 36 21
    /// </summary>
    internal class Task37
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 11;
            int[] numbers = new int[size];
            FillArrey(numbers, -9, 9);

            int maxIndex = size - 1;
            for (int i = 0; i < size/2; i++)
            {
                Console.WriteLine($"{numbers[i]} * {numbers[maxIndex - i]} = {numbers[i] * numbers[maxIndex - i]}");
            }
            if(size % 2 == 1)
            {
                Console.WriteLine("средний элемент массива:  " + numbers[size/2]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// заполняет массив
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
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
    }
}
