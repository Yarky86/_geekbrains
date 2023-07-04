Console.Clear();

//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2



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

int GetChangeRow(string messageRow) // Get an index of row to exchange
{
    Console.Write(messageRow);
    string valueRow = Console.ReadLine();
    int indexRow = Convert.ToInt32(valueRow);
    return indexRow;
}

int[,] ExchangeRow(int[,] getArrayToChange, int getFirstIndexRow, int getSecondIndexRow) // Exchange values in two any rows in the array
{
    int[,] changedRowArray = getArrayToChange;
    int temp;
    if (getFirstIndexRow < getArrayToChange.GetLength(0) && getSecondIndexRow < getArrayToChange.GetLength(0))
    {
        for (int ii = 0; ii < changedRowArray.GetLength(1); ii++)
        {
            temp = changedRowArray[getFirstIndexRow, ii];
            changedRowArray[getFirstIndexRow, ii] = changedRowArray[getSecondIndexRow, ii];
            changedRowArray[getSecondIndexRow, ii] = temp;
        }
    }
    else
    {
        Console.WriteLine($"Sorry, at least one of your input values is greater than count of rows in the array ({getArrayToChange.GetLength(0)}), please repeat your input");
        getFirstIndexRow = GetChangeRow("Input a first value of a row to exchange -> ");
        getSecondIndexRow = GetChangeRow("Input a first value of a row to exchange -> ");
        ExchangeRow(getArrayToChange, getFirstIndexRow, getSecondIndexRow);
    }

    return changedRowArray;
}

int[,] ChangeRowColumnArray(int[,] getArrayToChangeRowColumn) // Change rows to columns in the array
{
    int[,] changedRowColumnsArray = getArrayToChangeRowColumn;
    if (getArrayToChangeRowColumn.GetLength(0) == getArrayToChangeRowColumn.GetLength(1))
    {
        int tempRowColumn;
        for (int jj = 0; jj < getArrayToChangeRowColumn.GetLength(0) - 1; jj++)
        {
            for (int kk = jj + 1; kk < getArrayToChangeRowColumn.GetLength(1); kk++)
            {
                tempRowColumn = changedRowColumnsArray[jj, kk];
                changedRowColumnsArray[jj, kk] = changedRowColumnsArray[kk, jj];
                changedRowColumnsArray[kk, jj] = tempRowColumn;
            }
        }
    }
    else Console.WriteLine("Sorry, we couldn't change values from rows to columns because of unequal count of rows and columns in the array");
    return changedRowColumnsArray;
}

int[,] NullRowColumnMin (int[,] getArrayMinElement) // Change to null all elements in the row and column with min element of the array
{
    int[,] nulledRowColumn = getArrayMinElement;
    int min = getArrayMinElement[0,0];
    int minIndexRow = 0;
    int minIndexColumn = 0;
    for (int ll = 0; ll < getArrayMinElement.GetLength(0); ll++)
    {
        for (int mm = 0; mm < getArrayMinElement.GetLength(1); mm++)
        {
            if (getArrayMinElement[ll,mm] < min)
            {
                min = getArrayMinElement[ll,mm];
                minIndexRow = ll;
                minIndexColumn = mm;
            }
        }
    }
    for (int nn = 0; nn < getArrayMinElement.GetLength(1); nn++)
    {
        nulledRowColumn[minIndexRow, nn] = 0;
    }
        for (int oo = 0; oo < getArrayMinElement.GetLength(0); oo++)
    {
        nulledRowColumn[oo, minIndexColumn] = 0;
    }
    return nulledRowColumn;
}

// Main code

// to task 1
int mInt = GetArraySize("Input a number of rows -> ");
int nInt = GetArraySize("Input a number of columns -> ");
int minInt = GetLimitValue("Input a min value of the elements -> ");
int maxInt = GetLimitValue("Input a max value of the elements -> ");
int[,] mainArrayInt = GetRandomIntArray(mInt, nInt, minInt, maxInt);
PrintIntArray(mainArrayInt, "This is your array: ");

int firstRow = GetChangeRow("Input a first value of a row to exchange -> ");
int secondRow = GetChangeRow("Input a second value of a row to exchange -> ");
int[,] newChangedRowArray = ExchangeRow(mainArrayInt, firstRow, secondRow);
PrintIntArray(newChangedRowArray, $"Here is your array with changed rows");


//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7


// to task 2
Console.WriteLine();
Console.WriteLine();

PrintIntArray(mainArrayInt, "This is your MAIN array: ");
int[,] changedArrayRowToColumn = ChangeRowColumnArray(mainArrayInt);
PrintIntArray(changedArrayRowToColumn, "Here is the array with changed rows to columns");


//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// to task 3
Console.WriteLine();
Console.WriteLine();

PrintIntArray(mainArrayInt, "This is your MAIN array: ");
int[,] nulledArray = NullRowColumnMin(mainArrayInt);
PrintIntArray(nulledArray, "Here is the array with nulled values in the row and column with the first min element");
