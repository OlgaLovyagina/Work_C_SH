namespace HomeWork_9
{
    /// <summary>
    /// Задайте значения M и N. Напишите рекурсивный метод, который
    /// найдёт сумму натуральных элементов в промежутке от M до N.
    /// </summary>
    internal class Task66
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число M: ");
            int numberM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Сумма = {GetSpecialNumbers(numberN, numberM)} ");
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="number"></param>
        /// <param name="counter"></param>
        static int GetSpecialNumbers(int numberN, int numberM, int summ = 0, int counter = 0)
        {

            int currentValue = numberN + counter;

            if (currentValue > numberM) return summ;


            summ += currentValue;

            counter++;

            return GetSpecialNumbers(numberN, numberM, summ, counter);
        }
    }
}
