using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_5
{
    /// <summary>
    /// Задайте массив. Напишите программу, которая 
    /// определяет, присутствует ли заданное число в массиве. 
    /// 4; массив[6, 7, 19, 345, 3] -> нет 
    /// 3; массив[6, 7, 19, 345, 3] -> да
    /// </summary>
    internal class Task33
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число, наличие которого нужно искать в массиве");
            int check = Convert.ToInt32(Console.ReadLine());
            int size = 10;
            int[] numbers = new int[size];
            FillArrey(numbers, -9, 9);
            CheckArrey(numbers,check);
           
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
                Console.Write(numbers[i] + "  "); //показывает заполненный массив
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
        /// <summary>
        /// поиск числа в массиве
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="check"></param>
        static void CheckArrey(int[] numbers, int check)
        {
            bool flag = false;
            int i = 0;
            while (flag && i< numbers.Length)
            {
                if ( check == numbers[i])
                {
                    flag = true;
                }
                i++;
            }
            if(flag)
                Console.WriteLine($" Число {check} находится в массиве");
            else
                Console.WriteLine($" Числа {check} нет в массиве");
        }
    }
}
