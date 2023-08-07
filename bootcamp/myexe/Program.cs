/*
4.1 Напишите код для функции sum (см. выше).
4.2 Напишите рекурсивную функцию для подсчета элементов в списке.
4.3 Найдите наибольшее число в списке.
4.4 Помните бинарный поиск из главы 1? Он тоже
относится к классу алгоритмов •разделяй и властвуй•. Сможете ли вы определить базовый и рекурсивный случай для бинарного поиска?
*/


int Sum(int[] array) // 4.1 Напишите код для функции sum (см. выше).
{
    if (array.Length < 1) return 0;
    else return array[0] + Sum(array = array.Where((v, i) => i != 0).ToArray());
}

int QuantityOfIndexes(int[] array) // 4.2 Напишите рекурсивную функцию для подсчета элементов в списке.
{
    if (array.Length < 1) return 0;
    else return 1 + QuantityOfIndexes(array = array.Where((v, i) => i != 0).ToArray());
}

int Max(int[] array) // 4.3 Найдите наибольшее число в списке.
{
    int tempMax;
    int temp;
    if (array.Length == 2)
    {
        if (array[0] > array[1]) return array[0];
        else return array[1];
    }
    else 
    {
        temp = array[0];
        tempMax = Max(array = array.Where((v, i) => i != 0).ToArray());
        if (temp > tempMax) return temp;
        else return tempMax;
    }
}


Console.Clear();
int[] array1 = new int[] { -100098, -2000, 3, 4, -50, -66, 7, 8, 9, -10000 };
Console.Write("[ " + string.Join($", ", array1) + " ]");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("4.1 Напишите код для функции sum (см. выше).");
Console.Write(Sum(array1));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("4.2 Напишите рекурсивную функцию для подсчета элементов в списке.");
Console.Write(QuantityOfIndexes(array1));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("4.3 Найдите наибольшее число в списке.");
Console.Write(Max(array1));




