// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine(array[3]);

/* 
[4, 5, 3, 1, 2]
O(n) = 5 (for sum of all elements in the array)

[1, 2, 3, 4, 5] -> O(n * log n) = 10
(5 + 1) / 2 * 5 -> O(n) = 1
n < n * log n + 1
*/

// O(n^2)
int m = int.Parse(Console.ReadLine()!);
for (int i = 1; i < m; i++)
{
    for (int j = 1; j < m; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
    Console.WriteLine();
}
