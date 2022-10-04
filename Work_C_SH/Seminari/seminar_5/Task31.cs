using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_5
{
    /// <summary>
    /// Задайте массив из 12 элементов, заполненный случайными числами из
    /// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
    /// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
    /// положительных чисел равна 29, сумма отрицательных равна -20
    /// </summary>
    internal class Task31
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 12;
            int[] numbers = new int[size];    // int[] numbers это переменная,new int[size] это сам массив
            FillArrey(numbers, -9, 9); //  вызов метода на заполнения массива, (numbers) таким образом мы сюда передаем массив
            PrintArrey(numbers); //  вызов метода на вывод массива
            Console.WriteLine(GetSummPositive(numbers));
            Console.WriteLine(GetSummNegative(numbers));
        }
        /// <summary>
        /// находит сумму положительных элементов массива
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int GetSummPositive(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    sum += numbers[i];
            }
            return sum;
        }
        /// <summary>
        /// находит сумму отрицательных элементов массива
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int GetSummNegative(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    sum += numbers[i];
            }
            return sum;
        }

        /// <summary>
        ///  метод на заполнения массива
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        static void FillArrey(int[] numbers, int minValue = 0, int maxValue = 100)

        //int minValue = 0, int maxValue = 100 это значения по умолчанию

        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) // цикл на заполнения массива
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// метод на вывод массива
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintArrey(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)// цикл на вывод массива   
            {
                Console.Write(numbers[i] + "  "); //вывод элементов массива в строку через табуляцию
            }
            Console.WriteLine();
        }

    }
}

