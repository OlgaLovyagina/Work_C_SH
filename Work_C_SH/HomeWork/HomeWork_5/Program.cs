// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36.Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19[-4, -6, 89, 6]-> 0

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = -2,71, difference = 80,95



#region Task25 
/// <summary>
///на вход два натуральных числа (A и B) и возводит число A в степень B.
/// </summary>

void Task25() // исправила
{
    Console.WriteLine("Введите 1-е число: ");
    Console.Write("А =  ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    Console.Write("B = ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = num * result;
    }
    Console.WriteLine("Число А в степени В = " + result);
}
#endregion


#region Task34 
/// <summary>
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/// </summary>
/// 
void Task34()
{

    int size = 10;
    int[] numbers = new int[size];
    Console.WriteLine("Размер массива: " + size);

    FillArrey(numbers); //  вызов метода на заполнения массива

    PrintArrey(numbers); //  вызов метода на вывод массива



    void FillArrey(int[] num) //  метод на заполнения массива
    {
        Random random = new Random();
        for (int i = 0; i < num.Length; i++) // цикл на заполнения массива
        {
            num[i] = random.Next(100, 1000);
        }

    }

    void PrintArrey(int[] num) //  метод на вывод массива
    {
        
        for (int i = 0; i < num.Length; i++)// цикл на вывод массива   
        {
            Console.Write(num[i] + "\t"); //вывод элементов массива в строку через табуляцию
        }
        Console.WriteLine();

    }
    int NumberDigits(int current) // считает количество цифр в числе
    {
        int i = 0;

        while (current > 0)
        {
            current /= 10;
            i++;
        }
        return i;
    }
}

#endregion

Task34();
//Task25();
//Task27_1();
//Task29();

