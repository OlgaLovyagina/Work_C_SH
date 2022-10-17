namespace HomeWork_9
{
    /// <summary>
    /// Задайте значения M и N. Напишите рекурсивный метод, который
    /// выведет все натуральные числа кратные 3-ём в промежутке от N до M. 

    /// </summary>
    internal class Task64
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число N: ");
            int numberN = GetNumberFromConsole();
            Console.WriteLine("Введите число M: ");
            int numberM = GetNumberFromConsole();



            Console.WriteLine("Начинаем");
            GetSpecialNumbers(numberN, numberM);
        }

        public static int GetNumberFromConsole()
        {
            if(int.TryParse(Console.ReadLine(), out var result))
            {
                return result;
            }

            throw new Exception("Введены неправильные параметры");
        }

        /// <summary>
        /// все натуральные числа в промежутке от M до N
        /// </summary>
        /// <param name="number"></param>
        /// <param name="counter"></param>
        static void GetSpecialNumbers(int numberN, int numberM, int counter = 0)
        {
            if (numberM <= numberN)
                throw new Exception("N должно быть меньше или равно M!");

            var currentValue = numberN + counter;

            if (currentValue > numberM) return;

            if(currentValue % 3 == 0)
            {
                Console.WriteLine($"Число {currentValue} кратно трем.");
            }

            counter++;

            GetSpecialNumbers(numberN, numberM, counter);
        }
    }
}





