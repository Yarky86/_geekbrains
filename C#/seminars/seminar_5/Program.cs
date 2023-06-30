//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int[] CreatePriciseArray(int sizeArray)
{
    int[] arrPre = new int[sizeArray];
    for (int n = 0; n < sizeArray; n++)
    {
        Console.Write($"Input the number # {n} of the array -> ");
        arrPre[n] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
    return arrPre;
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

void ChangeElementsArray(int[] oldArray)
{
    for (int m = 0; m < oldArray.Length; m++)
    {
        oldArray[m] = oldArray[m] * (-1);
    }
    PrintArray(oldArray);
}

bool FindSpecialNumber(int[] arrayToFind, int numberToFind)
{
    for (int o = 0; o < arrayToFind.Length; o++)
    {
        if (arrayToFind[o] == numberToFind) return true;
    }
    return false;
}

int SearchSegment(int[] arrayToSearch, int minFind, int maxFind)
{
    int count = 0;
    for (int p = 0; p < arrayToSearch.Length; p++)
    {
        if (arrayToSearch[p] >= minFind && arrayToSearch[p] <= maxFind)
        {
           count++;
        }
    }
    return count;
}



Console.Write("Enter the size of your array -> ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min Value of number in the array -> ");
int minValueArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max Value of number in the array -> ");
int maxValueArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min Searching Value of number in the array -> ");
int minFindValueArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max Searching Value of number in the array -> ");
int maxFindValueArray = Convert.ToInt32(Console.ReadLine());


// PrintArray(CreateRandomArray(arraySize, minValueArray, maxValueArray));

// int SummaryPos(int[] arrayPos)
// {
//     int sumPos = 0;
//     for (int i = 0; i < arrayPos.Length; i++)
//     {
//         if (arrayPos[i] > 0) sumPos = sumPos + arrayPos[i];
//     }
//     return sumPos;
// }

// int SummaryNeg(int[] arrayNeg)
// {
//     int sumNeg = 0;
//     for (int k = 0; k < arrayNeg.Length; k++)
//     {
//         if (arrayNeg[k] < 0) sumNeg = sumNeg + arrayNeg[k];
//     }
//     return sumNeg;
// }

// void FillArray(int[] arrayToFill)
// {
//     for (int j = 0; j < arrayToFill.Length; j++)
//     {
//         arrayToFill[j] = new Random().Next(-9, 10);
//     }
// }

// void PrintArray(int[] arrayToPrint)
// {
//     for (int l = 0; l < arrayToPrint.Length; l++)
//     {
//         Console.Write($"{arrayToPrint[l]} ");
//     }
//     Console.WriteLine();
// }

// int[] bigArray = new int[12];
// FillArray(bigArray);
// PrintArray(bigArray);
// Console.WriteLine($"The summary of the all positive numbers in the array -> {SummaryPos(bigArray)}");
// Console.WriteLine($"The summary of the all negative numbers in the array -> {SummaryNeg(bigArray)}");


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]



// int[] newArray = CreateRandomArray(arraySize, minValueArray, maxValueArray);

// PrintArray(newArray);
// ChangeElementsArray(newArray);


// int[] SpecialArray = CreatePriciseArray(arraySize);
// PrintArray(SpecialArray);

// Console.Write("Enter the searching number in the your array -> ");
// int findNumber = Convert.ToInt32(Console.ReadLine());

// if (FindSpecialNumber(SpecialArray, findNumber)) Console.WriteLine($"Congrats, the number {findNumber} belongs to the array!");
// else Console.WriteLine($"Sorry, there isn't the number {findNumber} in the array!");


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

int[] bigBigArray = CreateRandomArray(arraySize, minValueArray, maxValueArray);
PrintArray(bigBigArray);
Console.WriteLine($"There are {SearchSegment(bigBigArray, minFindValueArray, maxFindValueArray)} elements belong to the segment from {minFindValueArray} to {maxFindValueArray}");