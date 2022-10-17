namespace seminar_9
{
    ///<summary>
    /// Задайте значение N. Напишите программу, которая выведет
    /// все натуральные числа в промежутке от 1 до N.
    /// </summary>
    internal class Task63
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Zadacha63(number);
        }
        /// <summary>
        /// все натуральные числа в промежутке от 1 до N.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="counter"></param>
        static void Zadacha63(int number, int counter = 0)
        {
            counter++;
            Console.WriteLine(counter);
            if (counter >= number) return;
            Zadacha63(number, counter);
        }
    }
}
