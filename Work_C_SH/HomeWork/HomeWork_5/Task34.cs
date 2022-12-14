using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    /// <summary>
    /// Задайте массив заполненный случайными положительными трёхзначными числами.
    /// Напишите программу, которая покажет количество чётных чисел в массиве.
    /// </summary>
    internal class Task34
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int size = 10;
            int[] numbers = new int[size];
            Console.WriteLine("Размер массива: " + size);

            FillArrey(numbers);
            PrintArrey(numbers);

            int counter = 0;
            for (int i = 0; i < size; i++)
            {              
                if (numbers[i] % 2 == 0) counter++;               
            }
            Console.WriteLine("Четных элементов : " + counter);


            /// <summary>
            /// метод на заполнения массива
            /// </summary>
            /// <param name="num"></param>
            static void FillArrey(int[] num)
            {
                Random random = new Random();
                for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
                {
                    num[i] = random.Next(100, 1000);
                }

            }
            /// <summary>
            /// метод на вывод массива
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
}

