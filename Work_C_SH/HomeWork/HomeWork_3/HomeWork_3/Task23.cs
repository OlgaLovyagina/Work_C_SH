using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    // <summary>
    /// Напишите программу, которая принимает на
    ///вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
    /// </summary>
    internal class Task23
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            Result(num, i);
        }
        /// <summary>
        /// находит кубы чисел от 1 до N
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        static void Result(int num, int i)
        {

            if (num > i)
            {
                while (i <= num)
                {
                    Console.WriteLine($"Число  {i}  |  Куб числа = {Math.Pow((i), 3)}");
                    i++;
                }
            }
            else
            {
                while (i >= num)
                {
                    Console.WriteLine($"Число  {num}  |  Куб числа = {Math.Pow((num), 3)}");
                    num++;
                }
            }
        }
    }
}
