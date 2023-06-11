// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.WriteLine("1. Comparing two numbers");
Console.Write("Enter a first number -> ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a second number -> ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine($"Max -> {b}");
}
else
{
    Console.WriteLine($"Max -> {a}");
}


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("2. Comparing three numbers");
Console.Write("Enter a first number -> ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a second number -> ");
int d = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a second number -> ");
int e = Convert.ToInt32(Console.ReadLine());

int max = c;
if (max < d) max = d;
if (max < e) max = e;
Console.WriteLine($"Max -> {max}");


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("3. Checking if a number is even");
Console.Write("Enter a number -> ");
int f = Convert.ToInt32(Console.ReadLine());

if (f % 2 == 0)
{
    Console.WriteLine($"Yes, the number {f} is the even number");
}
else
{
    Console.WriteLine($"No, the number {f} is the odd, not even number");
}


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("4. Getting a sequence of all even numbers from 1 to entered number");
Console.Write("Enter a number -> ");

int h = Convert.ToInt32(Console.ReadLine());

Console.Write($"Here is a sequence of all even numbers from 1 to {h} -> ");

int count = 2;

while (count <= h)
{
    Console.Write($"{count} ");
    count+=2;
}
