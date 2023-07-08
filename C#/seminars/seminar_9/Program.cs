// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// METHODS

int GetNumber(string message_size)
{
    Console.Write(message_size);
    string value = Console.ReadLine();
    int size = Convert.ToInt32(value);
    return size;
}


int SumDigits(int Number)
{
    int Sum = Number % 10;
    if (Number / 10 > 0)
    {
        Sum = Sum + SumDigits(Number / 10);
    }
    return Sum;
}

void Sequence(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write(num1 + ", ");
        Sequence(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write(num1 + ", ");
        Sequence(num1 - 1, num2);
    }
    else Console.Write(num2);

}

int Power(int num11, int num22)
{
    if (num22 == 0) return 1;
    else if (num22 % 2 == 0)
        return Power(num11 * num11, num22 / 2);
    else if (num22 % 2 > 0)
        return Power(num11 * num11, num22 / 2) * num11;
    else return num11;
}

Console.Clear();

// //Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// //453 -> 12
// //45 -> 9

// // int N = GetNumber("Input a number -> ");
// // Console.WriteLine($"Sum of digit of the number {N} -> {SumDigits(N)}");

// //Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// //M = 1; N = 5. -> "1, 2, 3, 4, 5"
// //M = 4; N = 8. -> "4, 5, 6, 7, 8"

// int MM = GetNumber("Input a number M -> ");
// int NN = GetNumber("Input a number N -> ");
// Sequence(MM, NN);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int A = GetNumber("Input a number A -> ");
int B = GetNumber("Input a number B -> ");
Console.WriteLine(Power(A, B));