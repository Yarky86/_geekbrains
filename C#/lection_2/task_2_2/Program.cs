Console.Clear();
int[] array = new int[9];

Console.WriteLine("Enter 9 numbers to find maximum:");
Console.Write("1. -> ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("2. -> ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("3. -> ");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("4. -> ");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.Write("5. -> ");
array[4] = Convert.ToInt32(Console.ReadLine());
Console.Write("6. -> ");
array[5] = Convert.ToInt32(Console.ReadLine());
Console.Write("7. -> ");
array[6] = Convert.ToInt32(Console.ReadLine());
Console.Write("8. -> ");
array[7] = Convert.ToInt32(Console.ReadLine());
Console.Write("9. -> ");
array[8] = Convert.ToInt32(Console.ReadLine());

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int max = Max
(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]) 
);

Console.WriteLine($"Max -> {max}");


// // My own experiment

// Console.Clear();
// Console.Write("Enter quantity of the elements -> ");
// int index = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[index];

// Console.WriteLine($"Enter {index} numbers to find maximum:");
// int count = 0;
// while (count < index)
// {
//     Console.Write($"{count + 1}. -> ");
//     array[count] = Convert.ToInt32(Console.ReadLine());
// }

// // Here is starting a mistake
// int Max(int indexMax = 5, int[] arrayMax = new int[indexMax])
// {
//     int result = arg1;
//     if (result < arg2) result = arg2;
//     if (result < arg3) result = arg3;
//     return result;
// }

// int max = Max
// (
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// Console.WriteLine($"Max -> {max}");