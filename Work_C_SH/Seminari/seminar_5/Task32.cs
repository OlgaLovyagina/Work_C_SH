using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_5
{
    /// <summary>
    /// Напишите программу замены элементов 
    /// массива: положительные элементы замените нa 
    /// соответствующие отрицательные, и наоборот.
    /// [-4, -8, 8, 2] -> [4, 8, -8, -2]
    /// </summary>
    internal class Task32
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 12;
            int[] numbers = new int[size]; // int[] numbers это переменная,new int[size] это сам массив
            FillArrey(numbers, -9, 9); //  вызов метода на заполнения массива, (numbers) таким образом мы сюда передаем массив
            PrintArrey(numbers); //  вызов метода на вывод массива
        }

        /// <summary>
        /// метод на заполнения массива
        /// int minValue = 0, int maxValue = 100 это значения по умолчанию
        /// </summary>
        /// <param name="numbers">dsadsa</param>
        /// <param name="minValue">dsadsa</param>
        /// <param name="maxValue">gfedabfd</param>
        static void FillArrey(int[] numbers, int minValue = 0, int maxValue = 100)

        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) // цикл на заполнения массива
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }
        /// <summary>
        ///  метод на вывод массива
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintArrey(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)// цикл на вывод массива   
            {
                numbers[i] *= -1;
                Console.Write(numbers[i] + "  "); //вывод элементов массива в строку через табуляцию
            }
            Console.WriteLine();
        }

        /*
        public static void RecursionMethod(int i)
        {


            RecursionMethod(i); [0 1 3 4]  65000

        }
        */
    }
}

