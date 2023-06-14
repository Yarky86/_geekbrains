// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

void ShowSecondDigit(int findNumber)
{
    int find = (findNumber % 100) / 10;
    Console.WriteLine($"The second digit of the number {findNumber} -> {find}");
}

Console.Write("Enter a three-digit number -> ");
int number = Convert.ToInt32(Console.ReadLine());

ShowSecondDigit(number);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// // Универсальное решение через массив

// void FindThirdPosition(int findThird)
// {
//     if (Math.Abs(findThird) < 100)
//     {
//         Console.WriteLine($"There is no third digit in the number {findThird}");
//     }
//     else
//     {
//         int index = 1000;
//         int count = 3;
//         while (findThird / index != 0)
//         {
//             count++;
//             index = index * 10;
//         }
//         int[] array = new int[count];
//         int index2 = 0;
//         int splitter = 10;

//         while (index2 < count)
//         {
//             array[index2] = (findThird % splitter) / (splitter / 10);
//             index2++;
//             splitter = splitter * 10;
//         }
//         Console.WriteLine($"The third digit in the number {findThird} -> {Math.Abs(array[count - 3])}");
//     }
// }

// Console.Write("Enter any number -> ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// FindThirdPosition(number1);


// // Конкретное решение

void FindThirdPosition(int findThird)
{
    if (Math.Abs(findThird) < 100)
    {
        Console.WriteLine($"There is no third digit in the number {findThird}");
    }
    else
    {
        int index = 1000;
        int count = 3;
        while (findThird / index != 0)
        {
            count++;
            index = index * 10;
        }
        int find = (findThird % (index / 100)) / (index / 1000);

        // int[] array = new int[count];
        // int index2 = 0;
        // int splitter = 10;

        // while (index2 < count)
        // {
        //     array[index2] = (findThird % splitter) / (splitter / 10);
        //     index2++;
        //     splitter = splitter * 10;
        // }
        Console.WriteLine($"The third digit in the number {findThird} -> {Math.Abs(find)}");
    }
}

Console.Write("Enter any number -> ");
int number1 = Convert.ToInt32(Console.ReadLine());

FindThirdPosition(number1);



// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет

bool CheckWeekend (int num)
{
    if (num == 6 || num == 7) 
    {
        return true;
    }
    else
    {
        return false;
    }
}

void Check7Days(int num7)
{
    if (num7 < 1 || num7 > 7)
    {
        Console.WriteLine($"The number {num7} is not included into interval from 1 to 7");
    }
    else
    if (CheckWeekend(num7) == true)
    {
        Console.WriteLine($"The day with number {num7} is weekend");
    }
    else
    {
        Console.WriteLine($"The day with number {num7} is workday");
    }
}

Console.Write("Enter any number from 1 to 7, where the number means the day of the week -> ");
int number7 = Convert.ToInt32(Console.ReadLine());

Check7Days(number7);