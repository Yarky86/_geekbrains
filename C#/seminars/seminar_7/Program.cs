//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int GetArraySize(string message_size)
{
    Console.Write(message_size);
    string value = Console.ReadLine();
    int size = Convert.ToInt32(value);
    return size;
}

int GetLimitValue(string messageValue)
{
    Console.Write(messageValue);
    string limitValue = Console.ReadLine();
    int limit = Convert.ToInt32(limitValue);
    return limit;
}

int[,] GetRandomArray(int sizeRow, int sizeColumn, int minValue, int maxValue)
{
    int[,] newArray = new int[sizeRow, sizeColumn];
    for (int j = 0; j < newArray.GetLength(0); j++)
    {
        for (int k = 0; k < newArray.GetLength(1); k++)
        {
            newArray[j, k] = new Random().Next(minValue, maxValue);
        }
    }
    return newArray;
}

void PrintArray(int[,] getArray, string printMessage)
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

// к задаче 4
int GetSumMainDiagonal(int[,] someArray)
{
    int sum = 0;
    for (int m = 0; m < someArray.GetLength(0); m++)
    {
        for (int n = m; n < someArray.GetLength(1); n++)
        {
            sum = sum + someArray[m, n];
            break;
        }
    }
    return sum;
}

// к задаче 3
int[,] squareEvenBothIndexArray(int[,] oldArray)
{
    int[,] newArray = oldArray;
    for (int o = 0; o < newArray.GetLength(0); o++)
    {
        for (int p = 0; p < newArray.GetLength(1); p++)
        {
            if (o % 2 == 0 && p % 2 == 0)
            {
                newArray[o, p] = newArray[o, p] * newArray[o, p];
            }
        }
    }
    return newArray;
}

// к задаче 2
int[,] GetIndexArray(int sizeRow, int sizeColumn)
{
    int[,] newIndexArray = new int[sizeRow, sizeColumn];
    for (int q = 0; q < newIndexArray.GetLength(0); q++)
    {
        for (int r = 0; r < newIndexArray.GetLength(1); r++)
        {
            newIndexArray[q, r] = q + r;
        }
    }
    return newIndexArray;
}


int m = GetArraySize("Input a number of rows -> ");
int n = GetArraySize("Input a number of columns -> ");
// int min = GetLimitValue("Input a min value of the elements -> ");
// int max = GetLimitValue("Input a max value of the elements -> ");
// int[,] mainArray = GetRandomArray(m, n, min, max);
// PrintArray(mainArray, "This is your array: ");


// //Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int sumMainDiagonal = GetSumMainDiagonal(mainArray);
// Console.Write($"The summary of the elements belong to main diagonal -> {sumMainDiagonal}");


// //Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// //Например, изначально массив выглядел вот так:

// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
// //Новый массив будет выглядеть вот так:

// //1 4 7 2
// //5 **81 ** 2 **9**
// //8 4 2 4

// int[,] squareEvenIndex = squareEvenBothIndexArray(mainArray);
// PrintArray(squareEvenIndex, "This is your new array:");


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

int[,] mainIndexArray = GetIndexArray(m,n);
PrintArray(mainIndexArray, "This is your array: ");