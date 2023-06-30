
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] getArray)
{
    Console.Write($"Here is your array -> ");
    // int length = ;
    for (int k = 0; k < getArray.Length; k++)
    {
        Console.Write($"{getArray[k]} ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] arrayToFind) // поиск количества четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arrayToFind.Length; i++)
    {
        if (arrayToFind[i] % 2 == 0) count++;
    }
    return count;
}

int SumOddPosNumbers(int[] arrayToFind2) // поиск суммы элементов на нечетных позициях
{
    int sumOddPos = 0;
    for (int j = 1; j < arrayToFind2.Length; j += 2)
    {
        sumOddPos = sumOddPos + arrayToFind2[j];
    }
    return sumOddPos;
}

double[] CreateRandomDoubleArray(int size2, int minValue2, int maxValue2) // создание массива с вещественными числами
{
    double[] arr2 = new double[size2];
    for (int i = 0; i < size2; i++)
    {
        arr2[i] = Math.Round((new Random().Next(minValue2, maxValue2) + new Random().NextDouble()), 2);
    }
    return arr2;
}

void PrintArrayDouble(double[] getArray2) // вывод массива с вещественными числами
{
    Console.Write($"Here is your array -> ");
    for (int k = 0; k < getArray2.Length; k++)
    {
        Console.Write($"{getArray2[k]} ");
        Console.Write(" ");
    }
    Console.WriteLine();
}

double FindSumMinMax(double[] getArray3) // поиск разницы между макс и мин элементами в маввивые с вещественными числами
{
    double min = getArray3[0];
    double max = getArray3[0];
    double dif = 0;
    for (int k = 1; k < getArray3.Length; k++)
    {
        if (getArray3[k] < min) min = getArray3[k];
        if (getArray3[k] > max) max = getArray3[k];
    }
    dif = max - min;
    return dif;
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Enter the size of your array -> ");
int arraySize1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min third-digit positive Value of numbers in the array -> ");
int minValueArray1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max third-digit positive Value of numbers in the array -> ");
int maxValueArray1 = Convert.ToInt32(Console.ReadLine());

int[] newArray1 = CreateRandomArray(arraySize1, minValueArray1, maxValueArray1);
PrintArray(newArray1);
Console.WriteLine($"There are {CountEvenNumbers(newArray1)} EVEN numbers in the array");

Console.WriteLine();
Console.WriteLine();


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter the size of your array -> ");
int arraySize2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min Value of numbers in the array -> ");
int minValueArray2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max Value of numbers in the array -> ");
int maxValueArray2 = Convert.ToInt32(Console.ReadLine());

int[] newArray2 = CreateRandomArray(arraySize2, minValueArray2, maxValueArray2);
PrintArray(newArray2);
Console.WriteLine($"The summary of all odd-positioned elements of the array -> {SumOddPosNumbers(newArray2)}");


Console.WriteLine();
Console.WriteLine();


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Enter the size of your array -> ");
int arraySize3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min Value of numbers in the array -> ");
int minValueArray3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max Value of numbers in the array -> ");
int maxValueArray3 = Convert.ToInt32(Console.ReadLine());

double[] newArray3 = CreateRandomDoubleArray(arraySize3, minValueArray3, maxValueArray3);
PrintArrayDouble(newArray3);
Console.WriteLine("The difference between max and min values in the array -> " + "{0:#.##}", FindSumMinMax(newArray3));


Console.WriteLine();
Console.WriteLine();