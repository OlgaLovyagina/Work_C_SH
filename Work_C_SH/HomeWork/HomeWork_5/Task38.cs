namespace HomeWork_5
{
    /// <summary>
    /// Задайте массив вещественных чисел. Найдите 
    /// разницу между максимальным и минимальным элементов массива.
    /// </summary>
    internal class Task38
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            double[] numbers = new double[15];
            Console.WriteLine("Размер массива: " + numbers.Length);

            FillArrey(numbers);
            PrintArrey(numbers);
            SortingArrey(numbers);
            PrintArrey(numbers);
            double difference = numbers.Length - 1 - numbers[0];
            Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);
        }

        /// <summary>
        /// сортирует элементы массива по возрастанию
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="size"></param>
        static void SortingArrey(double[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        double temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                    }

                }

            }
        }

        /// <summary>
        /// метод на заполнения массива
        /// </summary>
        /// <param name="num"></param>
        static void FillArrey(double[] num)
        {
            Random random = new Random();
            for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
            {
                double value = random.NextDouble() * 20 - 10;
                num[i] = Math.Round(value, 2);
            }

        }

        /// <summary>
        /// метод на вывод массива
        /// </summary>
        /// <param name="num"></param>
        static void PrintArrey(double[] num)
        {

            for (int i = 0; i < num.Length; i++)// цикл на вывод массива   
            {
                Console.Write(num[i] + "\t"); //вывод элементов массива в строку через табуляцию
            }
            Console.WriteLine();

        }


    }
}


