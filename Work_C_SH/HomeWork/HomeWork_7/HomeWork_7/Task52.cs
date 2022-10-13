namespace HomeWork_7
{
    /// <summary>
    /// Задайте двумерный массив из целых чисел.
    /// Найдите среднее арифметическое элементов в каждом столбце.

    /// </summary>
    internal class Task52
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
            double arithmeticMean = 0;


            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum +=  numbers[j, i];
                }
                arithmeticMean = sum / (double)rows;

                Console.WriteLine($"Cреднее арифметическое {j + 1} столбца =  {arithmeticMean}");
            }


        }

        /// <summary>
        /// Заполнение двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        static void FillArrey(int[,] numbers)
        {

            Random random = new Random();
            int rows = numbers.GetLength(0);     
            int columns = numbers.GetLength(1);  


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) 
                                                 
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

            int rows = numbers.GetLength(0); 
            int columns = numbers.GetLength(1); 


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

