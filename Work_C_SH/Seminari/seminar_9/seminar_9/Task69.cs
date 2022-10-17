namespace seminar_9
{
    ///<summary>
    /// : Напишите программу, которая на вход принимает два числа A и B, и
    /// возводит число А в целую степень B с помощью рекурсии.
    /// </summary>
    internal class Task69
    {
        // <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {

            Console.WriteLine("Введите число A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int result = 1;

            //for (int i = 0; i < numberB; i++) // решение задачи через цикл
            //{
            //     result *= numberA;
            // }
            //  Console.WriteLine($"{numberA}^{numberB} = {result}");

            Pow(numberA, numberB);

           
            static void Pow(int numberA, int numberB, int result = 1) // решение через рекурсию
            {
                if (numberB == 0)
                {
                    Console.WriteLine($" {result}");
                    return;
                }
                result *= numberA;
                numberB--;
                Pow(numberA, numberB, result);

            }
        }
    }
}
