Console.Clear();

Console.WriteLine("Enter 9 numbers to find maximum:");
Console.Write("1. -> ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. -> ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3. -> ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("4. -> ");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.Write("5. -> ");
int a5 = Convert.ToInt32(Console.ReadLine());
Console.Write("6. -> ");
int a6 = Convert.ToInt32(Console.ReadLine());
Console.Write("7. -> ");
int a7 = Convert.ToInt32(Console.ReadLine());
Console.Write("8. -> ");
int a8 = Convert.ToInt32(Console.ReadLine());
Console.Write("9. -> ");
int a9 = Convert.ToInt32(Console.ReadLine());

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int max = Max
(
    Max(a1, a2, a3), 
    Max(a4, a5, a6), 
    Max(a7, a8, a9)
);

Console.WriteLine($"Max -> {max}");