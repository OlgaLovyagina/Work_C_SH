using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_6
{
    /// <summary>
    /// Напишите программу, которая будет создавать
    /// копию заданного массива с помощью поэлементного копирования.
    /// </summary>
    internal class Task45
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 10;
            int[] numbers = new int[size];
            int[] other = new int[size];
            FillArrey(numbers);
            PrintArrey(numbers);
            

            for (int i = 0; i < numbers.Length; i++)
            {
                other[i] = numbers[i];
            }
            PrintArrey(other);
        }

        static void FillArrey(int[] numbers, int minValue = 0, int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }

        static void PrintArrey(int[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "   ");
            }
            Console.WriteLine();
        }
    }
}
