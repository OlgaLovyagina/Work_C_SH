namespace seminar_9
{
    ///<summary>
    ///Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
    /// </summary>
    internal class Task67
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumNum(num));
        }

        static int SumNum(int num, int sum = 0)
        {
            if (num == 0)
            {
                return sum;
            }

            sum = sum + num % 10;
            num = num / 10;
            return SumNum(num, sum);

        }
    }
}

