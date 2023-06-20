// //Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// //7 -> 28
// //4 -> 10
// //8 -> 36

// int Summarize(int var)
// {
//     int sum = 0;
//     for (int i = 1; i <= var; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Enter any whole number -> ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Here is a summary of all numbers in the range from 1 to {a} -> {Summarize(a)}");


// // Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

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
// }


// Console.Clear();
// Console.Write("Enter the size of your array -> ");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the min Value of number in the array -> ");
// int minValueArray = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the max Value of number in the array -> ");
// int maxValueArray = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(arraySize, minValueArray, maxValueArray));


// //Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// double CheckDigitsQuantity(int x)
// {
//     int a = -1;
//     int i = 1;
//     while (a != 0)
//     {
//         i *= 10;
//         a = x / i;
//     }
//     double quantity = Math.Log10(i);
//     return quantity;
// }

// Console.Clear();
// Console.Write("Enter any whole number -> ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The quantity of digits in the number {a} -> {CheckDigitsQuantity(a)}");



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4 -> 24
//5 -> 120


int Factorial(int y)
{
    int multi = 1;
    for (int i = 1; i <= y; i++)
    {
        multi = multi * i;
    }
    return multi;
}

Console.Clear();
Console.Write("Enter any whole number -> ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The Factorial of the number {number} -> {Factorial(number)}");
