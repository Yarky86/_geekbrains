void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);

int IndexOf(int[] collection, int find)
{
    int countCollection = collection.Length;
    int indexCollection = 0;
    int findPosition = -1;
    while (indexCollection < countCollection)
    {
        if (collection[indexCollection] == find)
        {
            findPosition = indexCollection;
            break;
        }
        indexCollection++;
    }
    return (findPosition);
}

void FindElementPosition()
{
    Console.WriteLine();
    Console.Write("Enter a value of an element, wich position you would like to get -> ");
    int findValue = Convert.ToInt32(Console.ReadLine());
    int pos = IndexOf(array, findValue);
    if (pos == -1)
    {
        Console.Write($"There is NOT the value {findValue} in the array");
    }
    else 
    {
        Console.Write($"The position yof the value {findValue} -> {pos}");
    }
} 

FindElementPosition();