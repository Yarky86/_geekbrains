/*
sorting via choice

2 7 0 3 -5 12 8
-5 7 0 3 2 12 8
-5 0 7 3 2 12 8
-5 0 2 3 7 12 8
-5 0 2 3 7 12 8
-5 0 2 3 7 12 8
-5 0 2 3 7 8 12
*/

void InputData(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

int[] ChoiceSorting(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j;

            }
        }
        int temp = array[min];
        array[min] = array[i];
        array[i] = temp;
    }
    return array;
}

Console.Clear();
Console.Write("Input quantity of elements of the array -> ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputData(array);
Console.WriteLine($"The given array -> [{string.Join(", ", array)}]");
Console.WriteLine($"The sorted array -> [{string.Join(", ", ChoiceSorting(array))}]");