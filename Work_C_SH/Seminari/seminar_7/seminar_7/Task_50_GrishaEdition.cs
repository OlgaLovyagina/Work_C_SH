using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_7
{
    internal class Task_50_GrishaEdition
    {
        public int SomeVar;

        private int[,] numbers;
        private Random random;

        public void SetSomeVar(int numb)
        {
            SomeVar = numb;
        }

        public int GetSomeVar()
        {
            return SomeVar;
        }

        public void Run()
        {
            random = new Random();
            int rows = random.Next(4, 8);
            int columns = random.Next(4, 8);
            Console.WriteLine($"Массив размера {rows}x{columns}");
            numbers = new int[rows, columns];
            FillArrey();
            PrintArrey();

            Console.WriteLine("Введите первый индекс: ");
            int firstIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй индекс: ");
            int secondIndex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Искомый элемент [{firstIndex}, {secondIndex}] = {SearchElement(firstIndex, secondIndex)}");
            
            try
            {
                Console.WriteLine($"Искомый элемент [{firstIndex}, {secondIndex}] = {SearchElement(firstIndex, secondIndex)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Такого элемента не существует");
;           }
        }

        /// <summary>
        /// Заполнение двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        void FillArrey()
        {

            int rows = numbers.GetLength(0);     // GetLength получить длинну(размерность строк)
            int columns = numbers.GetLength(1);  // GetLength получить длинну(размерность столбцов)


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) // здесь заполняется строка, т.е. i = 0 и идет перебор по j,
                                                  // индексы получаются 0.1  0.2  0.3 и тд, потом когда j=columns,
                                                  // выходим из этого цикла, входим во внешний цикл и i увеличивается
                                                  // на 1 и мы опять заходим во внутренний цикл и j обнуляется.
                {
                    numbers[i, j] = random.Next(-10, 11);
                }
            }
        }


        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        /// <param name="numbers"></param>
        void PrintArrey()
        {

            int rows = numbers.GetLength(0); // GetLength получить длинну(размерность строк)
            int columns = numbers.GetLength(1); // GetLength получить длинну(размерность столбцов)


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        int SearchElement(int firstIndex, int secondIndex)
        {
            /*
            if (firstIndex >= numbers.GetLength(1) || firstIndex < 0 && secondIndex >= numbers.GetLength(0) || secondIndex < 0)
            {
                throw new Exception("dsadsafsa");
            }*/
            return numbers[firstIndex, secondIndex];
        }
    }
}
