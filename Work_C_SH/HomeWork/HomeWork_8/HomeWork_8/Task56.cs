namespace HomeWork_8
{
    ///<summary>
    /// Задайте прямоугольный двумерный массив. Напишите
    /// программу, которая будет находить строку с наименьшей суммой элементов.
    /// </summary>
    internal class Task56
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

            double summaRowMin = SumRow(numbers, 0, columns); ;
            int indexMin = 0;
            
            for (int i = 1; i < rows; i++)
            {
               double summaRow = SumRow( numbers, i, columns);
                
                if (summaRow < summaRowMin)
                {
                    summaRowMin = summaRow;
                    indexMin = i; 
                }
               
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальная сумма элементов в строке массива {summaRowMin}");
            Console.WriteLine($"Индекс строки с минимальной суммой {indexMin}");
        }

        /// <summary>
        /// ищет сууму значений элементов строки
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="i"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        static double SumRow(double[,] numbers, int i, int columns)
        {
            double summaRow = 0;
            for (int j = 0; j < columns; j++)
            {
                summaRow += numbers[i, j];
            }
            Console.WriteLine($" Сумма {i + 1} строки = {Math.Round(summaRow, 2)}");
            return Math.Round(summaRow, 2);
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
    }
}
