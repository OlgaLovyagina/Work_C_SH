using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_3
{
    /// <summary>
    /// Напишите программу, которая принимает на вход
    ///координаты точки(X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
    ///номер четверти плоскости, в которой находится эта точка
    /// </summary>
    internal class Task17
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Random random = new Random();
            int x = random.Next(-10, 10);
            int y = random.Next(-10, 10);
            Console.WriteLine($"A({x},{y})");
            CoordCheck(x, y);
        }

        /// <summary>
        /// проверяет, в какой четверти лежит точка
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void CoordCheck(int x, int y) 
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка лежит в 1-ой четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка лежит во 2-ой четверти ");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в 3-ей четверти ");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в 4-ой четверти ");
            }
            else
                Console.WriteLine("Точка лежит на одной из осей ");
        }

    }
}
