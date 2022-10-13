using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_7
{
    /// <summary>
    /// Задайте двумерный массив. Найдите элементы, у
    /// которых оба индекса чётные, и замените эти элементы на их квадраты.
    /// </summary>
    internal class Task49
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Random random = new Random();
            int rows = random.Next(4, 8);
            int columns = random.Next(4, 8);
            Console.WriteLine($"Массив размера {rows}x{columns}");
            int[,] numbers = new int[rows, columns];
            FillArrey(numbers);
            PrintArrey(numbers);
            // по сути это третий метод, который и решает задачу
            for (int i = 0; i < rows; i += 2)
            {
                for (int j = 0; j < columns; j += 2)
                {
                    numbers[i, j] = numbers[i, j] * numbers[i, j];
                }
            }
            Console.WriteLine();
            PrintArrey(numbers);
        }
        /// <summary>
        /// Заполнение двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        static void FillArrey(int[,] numbers)
        {

            Random random = new Random();
            int rows = numbers.GetLength(0);     // GetLength получить длинну(размерность строк)
            int columns = numbers.GetLength(1);  // GetLength получить длинну(размерность столбцов)


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) // здесь заполняется строка, т.е. i = 0 и идет перебор по j,
                                                  // индексы получаются 0.1  0.2  0.3 и тд, потом когда j=columns,
                                                  // выходим из этого цикла, входим во внешний цикл и i увеличивается
                                                  // на 1 и мы опять заходим во внутренний цикл и j обнуляется.
                {
                    numbers[i, j] = random.Next(-10, 11);
                }
            }
        }

        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintArrey(int[,] numbers)
        {

            int rows = numbers.GetLength(0); // GetLength получить длинну(размерность строк)
            int columns = numbers.GetLength(1); // GetLength получить длинну(размерность столбцов)


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
