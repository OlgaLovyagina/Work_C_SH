using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    /// <summary>
    /// . Напишите программу, которая найдёт точку
    /// пересечения двух прямых, заданных уравнениями y = k1*x + b1, y = k2* x + b2; 
    /// значения b1, k1, b2 и k2 задаются пользователем.

    /// </summary>
    internal class Task43
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.Write(" введите коэффициент уравнения к1 = ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" введите коэффициент уравнения в1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" введите коэффициент уравнения к2 = ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" введите коэффициент уравнения в2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
           
            double x = Math.Round((b2 - b1) / (k1 - k2),2);
            double y = Math.Round((k1*x+b1),2);
            Console.WriteLine($"Точка пересечения прямых имеет координаты А ({x},   {y})");
        }
    }
}
