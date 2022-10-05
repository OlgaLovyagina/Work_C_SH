using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    /// <summary>
    /// Задайте одномерный массив, заполненный
    /// случайными числами. Найдите сумму элементов с
    /// нечётными индексами.
    /// </summary>
    internal class Task36
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {

            int size = 10;
            int[] numbers = new int[size];
            Console.WriteLine("Размер массива: " + size);

            FillArrey(numbers);
            PrintArrey(numbers);

            int sum = 0;
            for (int i = 1; i < size; i+=2)
            {
             sum = sum + numbers[i];                
            }
            Console.WriteLine("Сумма элементов с нечетными индексами :" + sum);


            /// <summary>
            /// метод на заполнения массива
            /// </summary>
            /// <param name="num"></param>
            static void FillArrey(int[] num)
            {
                Random random = new Random();
                for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
                {
                    num[i] = random.Next(100, 1000);
                }

            }
            /// <summary>
            /// метод на вывод массива
            /// </summary>
            /// <param name="num"></param>
            static void PrintArrey(int[] num)
            {

                for (int i = 0; i < num.Length; i++)// цикл на вывод массива   
                {
                    Console.Write(num[i] + "\t"); //вывод элементов массива в строку через табуляцию
                }
                Console.WriteLine();

            }


        }
    }
}

