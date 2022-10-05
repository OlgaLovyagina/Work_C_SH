using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_3
{
    /// <summary>
    ///  Напишите программу, которая по заданному номеру четверти, 
    /// показывает диапазон возможных координат точек в этой четверти (x и y).
    /// </summary>
    internal class Task18
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите номер четверти");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckNam(number);
        }

        /// <summary>
        /// показывает координаты  заданной четверти
        /// </summary>
        /// <param name="number"></param>
        static void CheckNam(int number)
        {
            /*
            switch (number)
            {
                case 1:
                    Console.WriteLine("x > 0, y > 0");
                    break;
                case 2:
                    Console.WriteLine("x < 0, y > 0");
                    break;
            }
            */

            if (number == 1)
            {
                Console.WriteLine("x > 0, y > 0");
            }
            if (number == 2)
            {
                Console.WriteLine("x < 0, y > 0");
            }
            if (number == 3)
            {
                Console.WriteLine("x < 0, y < 0");
            }
            if (number == 4)
            {
                Console.WriteLine("x > 0, y < 0");
            }
            else
            {
                Console.WriteLine("Вы ввели не номер четверти");
            }
        }
    }
}

