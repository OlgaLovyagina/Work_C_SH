namespace HomeWork_6
{
    /// <summary>
    /// Пользователь вводит с клавиатуры M чисел.
    ///Посчитайте, сколько чисел больше 0 ввёл пользователь.

    /// </summary>
    internal class Task41
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine($" введите 10 элементов массива");
            int[] numbers = new int[10];

            FillArreyKl(numbers);
            FindArrey(numbers);
        }

        /// <summary>
        /// метод на заполнения массива с клавиатуры
        /// </summary>
        /// <param name="num"></param>
        static void FillArreyKl(int[] num)
        {
            for (int i = 0; i < num.Length; i++) 
            {
                Console.WriteLine($" введите {i + 1} элемент массива");
                num[i] = Convert.ToInt32(Console.ReadLine());      
            }
        }

        /// <summary>
        /// ищет количество нужных чисел в массиве
        /// </summary>
        /// <param name="numbers"></param>
        static void FindArrey(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >0)
                {
                    count++;
                }
            }
            Console.WriteLine($"количество элементов массива, значение которых больше 0 = " + count);
        }
    }
}
