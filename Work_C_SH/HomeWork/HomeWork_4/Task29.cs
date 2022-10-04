using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    /// <summary>
    /// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит 
    ///отсортированный по модулю массив.
    /// </summary>
    internal class Task29
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 8;
            int[] numbers = new int[size];
            Console.WriteLine("Размер массива: " + size);

            FillArrey(numbers); //  вызов метода на заполнения массива

            PrintArrey(numbers); //  вызов метода на вывод массива
        }

        /// <summary>
        ///  метод на заполнения массива
        /// </summary>
        /// <param name="num"></param>
        static void FillArrey(int[] num)
        {
            Random random = new Random();
            for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
            {
                num[i] = random.Next(-1000, 1001);
            }

        }
        /// <summary>
        ///  метод на вывод массива
        /// </summary>
        /// <param name="num"></param>
        static void PrintArrey(int[] num)
        {
            num = num.OrderBy(x => Math.Abs(x)).ToArray(); // сортировка по модулю

            for (int i = 0; i < num.Length; i++)// цикл на вывод массива   
            {
                Console.Write(num[i] + "\t"); //вывод элементов массива в строку через табуляцию
            }
            Console.WriteLine();
        }
    } 
}
