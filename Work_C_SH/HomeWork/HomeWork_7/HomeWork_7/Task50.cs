namespace HomeWork_7
{
    /// <summary>
    /// : Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и
    ///возвращает значение этого элемента или же указание, что такого элемента нет.

    /// </summary>
    internal class Task50
    {

        int[,] numbers;

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

            Console.WriteLine("Введите первый индекс: ");
            int firstIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй индекс: ");
            int secondIndex = Convert.ToInt32(Console.ReadLine());

            int result = SearchElement(numbers, firstIndex, secondIndex, rows, columns);
            Console.WriteLine($"Искомый элемент = {result}");
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

        static int SearchElement(int[,] array, int firstIndex, int secondIndex, int columns, int rows)
        {
            if(firstIndex >= columns || firstIndex < 0 && secondIndex >= rows || secondIndex < 0)
            {               
                return 0;
            }
            return array[firstIndex, secondIndex];
        }
    }
}
