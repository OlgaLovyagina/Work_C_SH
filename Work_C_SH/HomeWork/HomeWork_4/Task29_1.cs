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
    internal class Task29_1
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 8;
            int[] numbers = new int[size];
            Console.WriteLine("Размер массива: " + size);

            FillArrey(numbers);
            PrintArrey(numbers);
            SortingArrey(numbers, size);
            PrintArrey(numbers);
                   
        }
        /// <summary>
        /// сортирует элементы массива по возрастанию
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="size"></param>
        static void SortingArrey(int[] numbers, int size)
        {
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                    }

                }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        static void FillArrey(int[] num)
        {
            Random random = new Random();
            for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
            {
                num[i] = random.Next(0,100);       
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        static void PrintArrey(int[] num)
        {
            for (int i = 0; i < num.Length; i++)// цикл на вывод массива   
            {
                Console.Write(num[i] + "\t"); //вывод элементов массива в строку через табуляцию
            }
            Console.WriteLine();

        }
    }
}



















