using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    ///<summary>
    /// Задайте двумерный массив. Напишите программу, которая
    /// упорядочит по убыванию элементы каждой строки двумерного массива.
    /// </summary>
    internal class Task54
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Random random = new Random();
            int rows = random.Next(6, 11);
            int columns = random.Next(4, 8);
            Console.WriteLine($"Массив размера {rows}x{columns}");
            double[,] numbers = new double[rows, columns];

            FillArrey(numbers);
            PrintArrey(numbers);

           
            BubbleSorting(numbers, rows, columns);
            Console.WriteLine();
            PrintArrey(numbers);
        }

        /// <summary>
        /// Заполнение двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        static void FillArrey(double[,] numbers)
        {

            Random random = new Random();
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.NextDouble() * 20 - 10;

                }
            }
        }

        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintArrey(double[,] numbers)
        {

            int rows = numbers.GetLength(0); // GetLength получить длинну(размерность строк)
            int columns = numbers.GetLength(1); // GetLength получить длинну(размерность столбцов)


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Math.Round(numbers[i, j], 1) + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Сортировка пузырьком строк двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        static void BubbleSorting(double[,] numbers, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int border = columns - j - 1;
                    for (int k = 0; k < border; k++)
                    {
                        if (numbers[i, k] < numbers[i, k + 1])
                        {
                            (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
                        }
                    }
                }
            }
        }
    }

}
