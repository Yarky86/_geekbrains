int[] QuickSort(int[] arr)
{
    if (arr.Length <= 1)
    {
        return arr;
    }
    else
    {
        int pivot = arr[0];
        int[] left = arr.Skip(1).Where(x => x < pivot).ToArray();
        int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();
        return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    }
}

int[] array = {6, 5, 3, 8, 5, 7, 9, 5, 4, 6, 3};

Console.Write("[" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.Write("[" + string.Join(", ", QuickSort(array)) + "]");

