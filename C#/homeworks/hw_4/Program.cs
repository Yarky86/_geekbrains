// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ToPower(int aa, int bb)
{
    int pow = 1;
    for (int i = 1; i <= bb; i++)
    {
        pow = pow * aa;
    }
    return pow;
}

Console.Clear();
Console.Write("Enter any whole number A -> ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter any natural number B -> ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Here is the number {a} raised to the power of {b} -> {ToPower(a, b)}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int cc)
{
    int sum = 0;
    for (int i = 1; cc != 0; i++)
    {
        sum = (sum + Math.Abs(cc % 10));
        cc = cc / 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Enter any whole number C -> ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The summary of digits in the number {c} -> {SumDigits(c)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($"Here is your array with size {arr.Length} -> ");
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write($"{arr[k]} ");
    }
}

Console.Clear();
Console.Write("Enter the size of the future array -> ");
int isize = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min Value in the future array -> ");
int iminValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max Value in the future array -> ");
int imaxValue = Convert.ToInt32(Console.ReadLine());

PrintArray(GetRandomArray(isize, iminValue, imaxValue));