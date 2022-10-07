using System;

namespace seminar_6
{
    /// <summary>
    /// Напишите программу, которая перевернёт
    /// одномерный массив(последний элемент будет на первом
    /// месте, а первый - на последнем и т.д.)
    ///[1 2 3 4 5] -> [5 4 3 2 1]
    /// </summary>
    internal class Task39
    {
        // <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 10;
            int[] numbers = new int[size];
            FillArrey(numbers, -10, 10);
            PrintArrey(numbers);
            ReverseArrey(numbers);
            PrintArrey(numbers);
        }

        /// <summary>
        /// делает переворот массива
        /// </summary>
        /// <param name="numbers"></param>
        static void ReverseArrey(int[] numbers)
        {
            int size = numbers.Length;
            int maxIndex = size - 1;
            for (int i = 0; i < size / 2; i++)
            {
                // int temp = numbers[i];
                // numbers[i] = numbers[maxIndex - i]; // maxIndex - i позволяет перебирать массив с конца
                // numbers[maxIndex - i] = temp;

                // можно использовать кортеж:
                (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
            }
          
        }

        /// <summary>
        /// ввод массива
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        static void FillArrey(int[] numbers, int minValue = 0, int maxValue = 9)
        {
            maxValue++;
            int size = numbers.Length;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// вывод массива
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintArrey(int[] numbers)
        {
            int size = numbers.Length;
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + "   ");
            }
            Console.WriteLine();
        }

    }
}
