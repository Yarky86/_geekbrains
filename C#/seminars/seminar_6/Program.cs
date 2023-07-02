// //Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// //а первый - на последнем и т.д.)

// //[1 2 3 4 5] -> [5 4 3 2 1]
// //[6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] getArray)
// {
//     Console.Write($"Here is your array -> ");
//     // int length = ;
//     for (int k = 0; k < getArray.Length; k++)
//     {
//         Console.Write($"{getArray[k]} ");
//     }
//     Console.WriteLine();
// }

// void ReverseArray(int[] someArray)
// {
//     int temp = 0;
//     for (int j = 0; j < someArray.Length / 2; j++)
//     {
//         temp = someArray[someArray.Length - j - 1];
//         someArray[someArray.Length - j - 1] = someArray[j];
//         someArray[j] = temp;
//     }
// }

// Console.Clear();

// // Console.Write("Enter the size of your array -> ");
// // int arraySize = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Enter the min Value of number in the array -> ");
// // int minValueArray = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Enter the max Value of number in the array -> ");
// // int maxValueArray = Convert.ToInt32(Console.ReadLine());

// // int[] newArray = CreateRandomArray(arraySize, minValueArray, maxValueArray);
// // PrintArray(newArray);
// // Console.WriteLine();
// // ReverseArray(newArray);
// // PrintArray(newArray);

// int GetArraySize(int toBin)
// {
//     int newArraySize = 0;
//     if (toBin == 0 || toBin == 1) return 1;
//     else
//     {
//         while (toBin == 1)
//         {
//             toBin = toBin / 2;
//             newArraySize++;
//         }
//     }
//     return newArraySize;
// }

// int[] GetBinArray(int toBin2, int arraySize)
// {
//     int[] BinArray = new int[arraySize];
//     for (int i = 0; i < BinArray.Length; i++)
//     {
//         BinArray[i] = toBin2 % 2;
//         toBin2 = toBin2 / 2;
//     }
//     return BinArray;
// }

// Console.Write("Enter a number to convert to binary -> ");
// int toBinary = Convert.ToInt32(Console.ReadLine());

// int[] newBinArray = GetBinArray(toBinary, GetArraySize(toBinary));
// ReverseArray(newBinArray);
// PrintArray(newBinArray);

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]


// int[] FibonacchiArray(int sizeArray, int firstNumber, int secondNumber)
// {
//     int[] newArray = new int[sizeArray];
//     newArray[0] = firstNumber;
//     newArray[1] = secondNumber;
//     for (int i = 2; i < sizeArray; i++)
//     {
//         newArray[i] = newArray[i - 1] + newArray[i - 2];
//     }
//     return newArray;
// }

// void PrintArray(int[] getArray)
// {
//     Console.Write($"Here is your array -> ");
//     for (int k = 0; k < getArray.Length; k++)
//     {
//         Console.Write($"{getArray[k]} ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter the first number in the Fibonacchi segment -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number in the Fibonacchi segment -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter how many Fibonacchi numbers you would like to get -> ");
// int N = Convert.ToInt32(Console.ReadLine());

// PrintArray(FibonacchiArray(N, a, b));


//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

Console.Write("Enter the first side of the triangle -> ");
int AB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second side of the triangle -> ");
int BC = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third side of the triangle -> ");
int CA = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int ab, int bc, int ca)
{
    if (ab < bc + ca && bc < ab + ca && ca < ab + bc) return true;
    else return false;
}

Console.WriteLine($"It is {CheckTriangle(AB, BC, CA)} that the triangle with sides {AB}, {BC} and {CA} can exist");