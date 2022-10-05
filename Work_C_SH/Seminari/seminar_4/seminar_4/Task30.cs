using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
    /// <summary>
    /// Напишите программу, которая выводит массив из 8??? элементов, заполненный нулями и  
    /// единицами в случайном порядке.
    /// </summary>
    internal class Task30
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Random random = new Random();
            int size = random.Next(4, 10);
            int[] numbers = new int[size];
            Console.WriteLine("Размер массива: " + size);

            FillArrey(numbers); //  вызов метода на заполнения массива
                                //FillArreyKl(numbers); //  вызов метода на заполнения массива с клавиатуры
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
                num[i] = random.Next(0, 2); // 0 или 1, 2 не входит       
            }
        }
        /// <summary>
        ///  метод на вывод массива
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

        //void FillArreyKl(int[] num) //  метод на заполнения массива с клавиатуры
        // {
        //         for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
        //      {
        //         Console.WriteLine($" введите {i + 1} элемент массива");
        //         num[i] = Convert.ToInt32(Console.ReadLine()); // 0 или 1, 2 не входит       
        //      }
        // }
    }
}

