// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SizeArray(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Please, input the element № {i + 1} -> ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

int CheckPositiveNumbers(int[] getArray)
{
    int count = 0;
    for (int j = 0; j < getArray.Length; j++)
    {
        if (getArray[j] > 0) count++;
    }
    return count;
}

void PrintArray(int[] getArrayToPrint)
{
    Console.Write($"Here is your array -> ");
    for (int k = 0; k < getArrayToPrint.Length; k++)
    {
        Console.Write($"{getArrayToPrint[k]} ");
    }
    Console.WriteLine();
}

int[] mainArray = InputArray(SizeArray("Please, input the count of the number to check -> "));
PrintArray(mainArray);
Console.WriteLine($"The count of the positive numbers in the array -> {CheckPositiveNumbers(mainArray)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter the k1 coefficient -> ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the b1 coefficient -> ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the k2 coefficient -> ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the b2 coefficient -> ");
double b2 = Convert.ToInt32(Console.ReadLine());

double[] FindCrossPoint(double K1, double B1, double K2, double B2)
{

    double[] coord = new double[2];
    coord[0] = (B1 - B2) / (K2 - K1);
    coord[1] = K2 * coord[0] + B2;
    return coord;
}

bool CheckLines(double K1, double B1, double K2, double B2)
{
    if (K1 == K2)
    {
        if (B1 == B2)
        {
            Console.WriteLine("Lines are identhical");
            return false;
        }
        else Console.WriteLine("Lines are parallel");
        return false;
    }
    else return true;
}

if (CheckLines(k1, b1, k2, b2))
{
    double[] crosses = FindCrossPoint(k1, b1, k2, b2);
    Console.WriteLine($"The crosspoint has coordinates ({crosses[0]}; {crosses[1]})");
}

// y = 5x + 2
// y = 9x + 4

// y - y = (5x + 2) - (9x + 4)
// y = 9x + 4

// 0 = (5x - 9x) + 2 - 4
// y = 9x + 4

// 0 = -4x - 2
// y = 9x + 4

// 0 = -4x - 2
// y = 9x + 4

// 4x = -2
// y = 9x + 4

// x = -0,5
// y = 9x + 4

// x = -0,5
// y = -0,5