int[] array = { 13, 22, 53, 47, 95, 66, 22, 86, 90 };

int n = array.Length;
// Console.WriteLine(n);

Console.Write("Enter a value of the searching element -> ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Write($"The index of the searching number {find} is {index}");
        break;
    }
    else if (index == n - 1)
    {
        Console.Write($"There isn't a serachinig number {find} in the array");
    }
    index++;
}