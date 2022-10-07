using System;

namespace seminar_6
{
    /// <summary>
    /// Не используя рекурсию, выведите первые N чисел
    /// Фибоначчи.Первые два числа Фибоначчи: 0 и 1.
    /// Если N = 5-> 0 1 1 2 3
    /// Если N = 3-> 0 1 1
    /// Если N = 7-> 0 1 1 2 3 5 8
    /// </summary>
    internal class Task44
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;

            int[] numbers = new int[size];
            numbers[0] = a;
            numbers[1] = b;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 2] + numbers[i - 1];
            }
            PrintArrey(numbers);
        }
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
