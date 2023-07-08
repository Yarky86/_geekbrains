Console.Clear();

// METHODS

int GetNumber(string message_size)
{
    Console.Write(message_size);
    string value = Console.ReadLine();
    int size = Convert.ToInt32(value);
    return size;
}

void Sequence(int num)
{
    if (num < 1) Console.Write(0);
    else if (num == 1) Console.Write(1);
    else
    {
        Console.Write(num + ", ");
        Sequence(num - 1);
    }
}

int Sum(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + Sum(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        return num2 + Sum(num1, num2 + 1);
    }
    else return num1;

}

int Akkerman(int mVar, int nVar)
{
    if (mVar == 0) return nVar + 1;
    else if (mVar > 0 && nVar == 0) return Akkerman(mVar - 1, 1);
    else if (mVar > 0 && nVar > 0) return Akkerman(mVar - 1, Akkerman(mVar, nVar - 1));
    else 
    {
        Console.WriteLine("Sorry, but numbers m & n must be greater or equal to 0");
        return 0;
    }
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// to task 64

Console.WriteLine("Print all natural numbers in a range [1, N]");
Console.WriteLine();
int N = GetNumber("Input value of N -> ");
Console.WriteLine($"Here is your sequence from 1 to {N}:");
Sequence(N);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// to task 66 
Console.WriteLine("Print summary of numbers in a range [M, N]");
Console.WriteLine();
int MM = GetNumber("Input value of M -> ");
int NN = GetNumber("Input value of N -> ");
Console.WriteLine($"Here is the summary of numbers in the range [{MM},{NN}] -> {Sum(MM, NN)}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Print Akkerman's function for numbers m & n");
Console.WriteLine();
int m = GetNumber("Input value of m -> ");
int n = GetNumber("Input value of n -> ");
Console.WriteLine();
int Akk = Akkerman(m ,n);
Console.WriteLine($"Here is the result of Akkerman's function for numbers m = {m} & n = {n} -> {Akk}");
