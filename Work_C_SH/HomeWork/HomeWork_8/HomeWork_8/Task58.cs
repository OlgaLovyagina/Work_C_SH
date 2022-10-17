using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    ///<summary>
    /// Заполните спирально массив 4 на 4 числами от 1 до 16.
    /// </summary>
    internal class Task58
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число x: ");
            int numberX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y: ");
            int numberY = Convert.ToInt32(Console.ReadLine());


            var _2xArray = new int[numberX, numberY];

            //for (int i = 0; i < )
            {

            }
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
    }
}
