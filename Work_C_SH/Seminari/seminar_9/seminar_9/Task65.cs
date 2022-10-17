namespace seminar_9
{
    ///<summary>
    /// Задайте значения M и N. Напишите программу, которая
    /// выведет все натуральные числа в промежутке от M до N.
    /// </summary>
    internal class Task65
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
            Console.WriteLine();
            Zadacha65(numberN, numberM);
        }
        /// <summary>
        /// все натуральные числа в промежутке от M до N
        /// </summary>
        /// <param name="number"></param>
        /// <param name="counter"></param>
        static void Zadacha65(int number, int counter = 1)
        {
            counter++;
            Console.WriteLine(counter);
            if (counter >= number) 
                return;
            Zadacha65(number, counter);
        }
    }
}

