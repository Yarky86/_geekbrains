// Урок 8. Двумерные массивы. Продолжение

// METHODS

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

int[,] ArrangeMaxToMin(int[,] getArrayToArrange) // Arrange from max to min all elements in each row in the array
{
    int temporary;
    int[,] NewArrangedArray = getArrayToArrange;
    for (int iii = 0; iii < NewArrangedArray.GetLength(0); iii++)
    {
        int maxIndexColumn = 0;
        for (int kkk = 1; kkk < NewArrangedArray.GetLength(1); kkk++)
        {
            for (int jjj = kkk; jjj < NewArrangedArray.GetLength(1); jjj++)
            {
                if (NewArrangedArray[iii, jjj] > NewArrangedArray[iii, maxIndexColumn])
                {
                    temporary = NewArrangedArray[iii, maxIndexColumn];
                    NewArrangedArray[iii, maxIndexColumn] = NewArrangedArray[iii, jjj];
                    NewArrangedArray[iii, jjj] = temporary;
                }
            }
            maxIndexColumn = kkk;
        }
    }
    return NewArrangedArray;
}

int MinSumRow(int[,] getMinSumArray) // Get a number of a row with the least summary of all elements in the row
{
    int minSum;
    int minSumIndex;
    int[] minSumArray = new int[getMinSumArray.GetLength(0)];
    for (int lll = 0; lll < getMinSumArray.GetLength(0); lll++)
    {
        for (int mmm = 0; mmm < getMinSumArray.GetLength(1); mmm++)
        {
            minSumArray[lll] = minSumArray[lll] + getMinSumArray[lll, mmm];
        }
    }
    minSum = minSumArray[0];
    minSumIndex = 0;
    for (int nnn = 1; nnn < minSumArray.Length; nnn++)
    {
        if (minSumArray[nnn] < minSum)
        {
            minSum = minSumArray[nnn];
            minSumIndex = nnn;
        }
    }
    return minSumIndex;
}

int[,] MultiplyMatrix(int[,] mtrx1, int[,] mtrx2) // get multiply of two matrix
{
    int[,] mtrxResult = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    if (mtrx1.GetLength(1) == mtrx2.GetLength(0))
    {
        for (int ooo = 0; ooo < mtrx1.GetLength(0); ooo++)
        {
            for (int ppp = 0; ppp < mtrx2.GetLength(1); ppp++)
            {
                for (int qqq = 0; qqq < mtrx1.GetLength(1); qqq++)
                {
                    mtrxResult[ooo, ppp] = mtrxResult[ooo, ppp] + mtrx1[ooo, qqq] * mtrx2[qqq, ppp];
                }
            }
        }
    }
    else Console.WriteLine("Sorry, we couldn't multiply matrix because the count of columns of the first matrix is not equal to count of rows of the second one");
    return mtrxResult;
}

int[,,] ThreeArray(int xIndex, int yIndex, int zIndex) // create three-dimensions array with unrepeated numbers
{
    int[,,] ThreeDimensionsArray = new int[xIndex, yIndex, zIndex];
    bool check;
    for (int iiii = 0; iiii < ThreeDimensionsArray.GetLength(0); iiii++)
    {
        for (int jjjj = 0; jjjj < ThreeDimensionsArray.GetLength(1); jjjj++)
        {
            for (int kkkk = 0; kkkk < ThreeDimensionsArray.GetLength(2); kkkk++)
            {
                check = false;
                while (check == false)
                {
                    ThreeDimensionsArray[iiii, jjjj, kkkk] = new Random().Next(10, 100);
                    // Console.WriteLine($"ThreeDimensionsArray[{iiii}, {jjjj}, {kkkk}] -> {ThreeDimensionsArray[iiii, jjjj, kkkk]}"); // debug
                    if (ThreeDimensionsArray.GetLength(0) * ThreeDimensionsArray.GetLength(1) * ThreeDimensionsArray.GetLength(2) <= 89)
                    {
                        check = CheckRepeatedElements(ThreeDimensionsArray, ThreeDimensionsArray[iiii, jjjj, kkkk], iiii, jjjj, kkkk);
                    }
                    else 
                    {
                        Console.WriteLine("Sorry, we couldn't check your array, because of count of the possible values in the array are greater than count of the possible unique two-digits numbers. There will be repeated numbers in the array, anyway, though.");
                        check = true;
                    }
                }
            }
        }
    }
    return ThreeDimensionsArray;
}

bool CheckRepeatedElements(int[,,] GetThreeDimArray, int ArrayElement, int index1, int index2, int index3) // check the array element wether it is repaeted in the array
{

    for (int i1 = 0; i1 < GetThreeDimArray.GetLength(0); i1++)
    {
        for (int j1 = 0; j1 < GetThreeDimArray.GetLength(1); j1++)
        {
            for (int k1 = 0; k1 < GetThreeDimArray.GetLength(2); k1++)
            {
                if (GetThreeDimArray[i1, j1, k1] == ArrayElement && (i1 != index1 || j1 != index2 || k1 != index3))
                {
                    // Console.WriteLine($"GetThreeDimArray[{i1}, {j1}, {k1}] -> {GetThreeDimArray[i1, j1, k1]}"); // debug
                    // Console.WriteLine($"ArrayElement -> {ArrayElement}"); // debug
                    return false;
                }

            }
        }
    }
    return true;
}

void PrintThirdArray(int[,,] getArrayThreeDim, string PrintNewMessage) // print three-dmensions arrray in rows with index
{
    Console.WriteLine(PrintNewMessage);
    for (int i2 = 0; i2 < getArrayThreeDim.GetLength(0); i2++)
    {
        for (int j2 = 0; j2 < getArrayThreeDim.GetLength(1); j2++)
        {
            for (int k2 = 0; k2 < getArrayThreeDim.GetLength(2); k2++)
            {
                Console.Write($"{getArrayThreeDim[i2, j2, k2]}({i2}, {j2}, {k2}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,] SpiralFillArray(int rowSize, int columnSize) // get an array with spiral filled
{
    int[,] SpiralArray = new int[rowSize, columnSize];
    int count = 1;
    int rowStart = 0;
    int columnStart = 0;
    int rowFinish = 0;
    int columnFinish = 0;
    int i = 0;
    int j = 0;
    while (count <= rowSize * columnSize)
    {
        SpiralArray[i, j] = count;
        if (i == rowStart && j < columnSize - columnFinish - 1) j++;
        else if (j == columnSize - columnFinish - 1 && i < rowSize - rowFinish - 1) i++;
        else if (i == rowSize - rowFinish - 1 && j > columnStart) j--;
        else i--;
        // Console.WriteLine($"i -> {i}"); //debug
        // Console.WriteLine($"j -> {j}"); //debug
        count++;

        if (i == rowStart + 1 && j == columnStart)
        {
            rowStart++;
            columnStart++;
            rowFinish++;
            columnFinish++;
        }

    }
    return SpiralArray;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// to task 54
Console.WriteLine("TASK 54. Get MAIN array, and arrange rows' elements from max to min");
Console.WriteLine();

int mInt = GetArraySize("Input a number of rows -> ");
int nInt = GetArraySize("Input a number of columns -> ");
int minInt = GetLimitValue("Input a min value of the elements -> ");
int maxInt = GetLimitValue("Input a max value of the elements -> ");
Console.WriteLine();
int[,] mainArrayInt = GetRandomIntArray(mInt, nInt, minInt, maxInt);
PrintIntArray(mainArrayInt, "This is your MAIN array: ");

int[,] arrangedArray = ArrangeMaxToMin(mainArrayInt);
Console.WriteLine();
PrintIntArray(arrangedArray, "Here is your arranged array");

Console.WriteLine();
Console.WriteLine();


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// to task 56 (using MAIN array from task 54)

Console.WriteLine("TASK 56 (using MAIN array from task 54)");
Console.WriteLine();
PrintIntArray(mainArrayInt, "This is your MAIN array: ");
Console.WriteLine($"The least summary of elements is in the row with index {MinSumRow(mainArrayInt)}");

Console.WriteLine();
Console.WriteLine();



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// * число столбцов матрицы А должно быть равно числу строк матрицы В

// to task 58 (using MAIN array as MATRIX A and same limits variables for both MATRIX A & B)


Console.WriteLine("TASK 58 (using MAIN array as MATRIX A and same limits variables for both MATRIX A & B)");
Console.WriteLine();

int mInt1 = GetArraySize("Input a number of rows for MATRIX B -> ");
int nInt1 = GetArraySize("Input a number of columns for MATRIX B -> ");
int[,] matrix1 = GetRandomIntArray(mInt, nInt, minInt, maxInt);
int[,] matrix2 = GetRandomIntArray(mInt1, nInt1, minInt, maxInt);
Console.WriteLine();
PrintIntArray(matrix1, "This is MATRIX A: ");
Console.WriteLine();
PrintIntArray(matrix2, "This is MATRIX B: ");
int[,] multipliedMatrix = MultiplyMatrix(matrix1, matrix2);
Console.WriteLine();
PrintIntArray(multipliedMatrix, "This is MULTIPLIED Matrix: ");

Console.WriteLine();
Console.WriteLine();



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// to task 60

Console.WriteLine("TASK 60. Get A three-dimensions array with unrepeated two-digits numbers and print it with index");
Console.WriteLine();

int xSize = GetArraySize("Input the first size of the array -> ");
int ySize = GetArraySize("Input the second size of the array -> ");
int zSize = GetArraySize("Input the third size of the array -> ");

int[,,] ThreeSizedArray = ThreeArray(xSize, ySize, zSize);
PrintThirdArray(ThreeSizedArray, "Here is your three-dimensions array:");

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// to task 62

Console.WriteLine("TASK 62. Get spiral-filled array with size 4x4");
Console.WriteLine();

int rowSpiral = GetArraySize("Input a number of rows -> ");
int columnSpiral = GetArraySize("Input a number of columns -> ");
int[,] newSpiralArray = SpiralFillArray(rowSpiral, columnSpiral);
PrintIntArray(newSpiralArray, "Here is your spiral-filled array");

