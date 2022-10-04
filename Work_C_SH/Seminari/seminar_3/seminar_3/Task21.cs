using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_3
{
    /// <summary>
    /// Напишите программу, которая принимает на вход координаты двух точек и
    /// находит расстояние между ними в 2D пространстве.
    /// </summary>
    internal class Task21
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите координаты точки А: ");

            Console.Write("X: ");
            int ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B: ");
            Console.Write("X: ");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int by = Convert.ToInt32(Console.ReadLine());

            int k = bx - ax;
            int m = by - ay;

            double length = Math.Sqrt(k * k + m * m);
            length = Math.Round(length, 2);
            Console.WriteLine($"Длинна {length}");
        }
      
    }
}
