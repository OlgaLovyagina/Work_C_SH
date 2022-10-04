using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    /// <summary>
    /// Задайте массив заполненный случайными положительными трёхзначными числами.
    /// Напишите программу, которая покажет количество чётных чисел в массиве.
    /// </summary>
    internal class Task34
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 10;
            int[] numbers = new int[size];
            Console.WriteLine("Размер массива: " + size);

            FillArrey(numbers); //  вызов метода на заполнения массива

            PrintArrey(numbers); //  вызов метода на вывод массива
        }

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

        /// <summary>
        /// считает количество цифр в числе
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        static int NumberDigits(int current) 
        {
                int i = 0;

                while (current > 0)
                {
                    current /= 10;
                    i++;
                }
                return i;
        }
        
    }
}

