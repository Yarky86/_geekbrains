// Урок 7. Двумерные массивы

// Methods

int GetArraySize(string message_size) // Get a size of the array from the user
{
    Console.Write(message_size);
    string value = Console.ReadLine();
    int size = Convert.ToInt32(value);
    return size;
}

int GetLimitValue(string messageValue) // Get min & max values (limits) of the elements in the array from the user
{
    Console.Write(messageValue);
    string limitValue = Console.ReadLine();
    int limit = Convert.ToInt32(limitValue);
    return limit;
}

double[,] GetRandomDoubleArray(int sizeRow, int sizeColumn, int minValue, int maxValue) // Create a new array with Double type variable for array's elements
{
    double[,] newArray = new double[sizeRow, sizeColumn];
    for (int j = 0; j < newArray.GetLength(0); j++)
    {
        for (int k = 0; k < newArray.GetLength(1); k++)
        {
            newArray[j, k] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
        }
    }
    return newArray;
}

void PrintDoubleArray(double[,] getArray, string printMessage) // Print the created array (Double type variables)
{
    Console.WriteLine(printMessage);
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int l = 0; l < getArray.GetLength(1); l++)
        {
            Console.Write(getArray[i, l] + " ");
        }
        Console.WriteLine();
    }
}

int GetSearchIndex(string messageIndex) // Get an element index to search value of this element
{
    Console.Write(messageIndex);
    string indexValue = Console.ReadLine();
    int index = Convert.ToInt32(indexValue);
    return index;
}

void GetElementFromIndex(double[,] someArray, int indexRow, int indexColumn) // Find and get an element from its index
{
    if (indexRow > someArray.GetLength(0) || indexColumn > someArray.GetLength(1))
    {
        Console.WriteLine($"Sorry, there isn't an element with index [{indexRow}, {indexColumn}] in the array");
    }
    else
    {
        Console.WriteLine($"An element with index [{indexRow}, {indexColumn}] -> {someArray[indexRow, indexColumn]}");
    }
}

int[,] GetRandomIntArray(int sizeRowInt, int sizeColumnInt, int minValueInt, int maxValueInt) // Create a new array with Int type variable for array's elements
{
    int[,] newArrayInt = new int[sizeRowInt, sizeColumnInt];
    for (int s = 0; s < newArrayInt.GetLength(0); s++)
    {
        for (int t = 0; t < newArrayInt.GetLength(1); t++)
        {
            newArrayInt[s, t] = new Random().Next(minValueInt, maxValueInt);
        }
    }
    return newArrayInt;
}

void PrintIntArray(int[,] getArrayInt, string printMessageInt) // Print the created array (Int type variables)
{
    Console.WriteLine(printMessageInt);
    for (int u = 0; u < getArrayInt.GetLength(0); u++)
    {
        for (int v = 0; v < getArrayInt.GetLength(1); v++)
        {
            Console.Write(getArrayInt[u, v] + " ");
        }
        Console.WriteLine();
    }
}

double[] AverageColumn(int[,] GetSomeArray) // Search an average value in every column of the array
{
    double[] averageEveryColumn = new double[GetSomeArray.GetLength(1)];

    for (int w = 0; w < GetSomeArray.GetLength(1); w++)
    {
        for (int x = 0; x < GetSomeArray.GetLength(0); x++)
        {
            averageEveryColumn[w] = averageEveryColumn[w] + GetSomeArray[x, w];
        }
        averageEveryColumn[w] = Math.Round((averageEveryColumn[w] / GetSomeArray.GetLength(0)), 2);
    }
    return averageEveryColumn;
}

void PrintLineArray(double[] getArrayline, string printMessageLine) // Print a line array 
{
    Console.WriteLine(printMessageLine);
    for (int y = 0; y < getArrayline.Length; y++)
    {
        Console.Write(getArrayline[y] + " ");
    }
}



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// To Exercise 47
int m = GetArraySize("Input a number of rows -> ");
int n = GetArraySize("Input a number of columns -> ");
int min = GetLimitValue("Input a min value of the elements -> ");
int max = GetLimitValue("Input a max value of the elements -> ");
double[,] mainArray = GetRandomDoubleArray(m, n, min, max);
PrintDoubleArray(mainArray, "This is your array: ");

Console.WriteLine();
Console.WriteLine();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// To exercise 50 (using the array from the exercise 47)
int a = GetSearchIndex("Input a row index of the searched element -> ");
int b = GetSearchIndex("Input a column index of the searched element -> ");
GetElementFromIndex(mainArray, a, b);

Console.WriteLine();
Console.WriteLine();



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// To exercise 52

int mInt = GetArraySize("Input a number of rows -> ");
int nInt = GetArraySize("Input a number of columns -> ");
int minInt = GetLimitValue("Input a min value of the elements -> ");
int maxInt = GetLimitValue("Input a max value of the elements -> ");
int[,] mainArrayInt = GetRandomIntArray(mInt, nInt, minInt, maxInt);
PrintIntArray(mainArrayInt, "This is your array: ");

PrintLineArray(AverageColumn(mainArrayInt), "Here are the average values of every column in the array:");