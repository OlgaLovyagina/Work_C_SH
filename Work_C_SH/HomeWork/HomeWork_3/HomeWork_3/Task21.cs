using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    /// <summary>
    /// Напишите программу, которая принимает на вход координаты двух точек и
    ///находит расстояние между ними в 3D пространстве.
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
            Console.Write("Z: ");
            int az = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите координаты точки B: ");

            Console.Write("X: ");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int by = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z: ");
            int bz = Convert.ToInt32(Console.ReadLine());


            double length = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay)
                + (bz - az) * (bz - az));
            length = Math.Round(length, 2);
            Console.WriteLine($"Расстояние между точками {length}");
        }
    }
}
