// Console.Clear();

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.
// — Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?

// Console.Clear();


// // string Replace(string text, char oldValue, char newValue)
// // {
// //     string result = String.Empty;
// //     int lenght = te
// //     return result;
// // }

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string s = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string newText1 = Replace(s, ' ', '|');
// string newText2 = Replace(newText1, 'с', 'С');
// string newText3 = Replace(newText2, 'к', 'К');
// Console.WriteLine(newText3);


// Упорядочить массив. 6 8 3 2 1 4 5 7, 
// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы


// void InputAndSortArrayMin()
// {
//     Console.Write("Enter the lenght of the disired array -> ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[length];

//     for (int i = 0; i < length; i++)
//     {
//         Console.Write($"Enter the element № {i} of the array -> ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     Console.Write("Your array is: ");
//     for (int j = 0; j < length; j++)
//     {
//         Console.Write($"{array[j]} ");
//     }

//     Console.WriteLine();

//     Console.Write("Your arranged array -> ");
//     for (int k = 0; k < length - 1; k++)
//     {
//         int minPositon = k;

//         for (int m = k + 1; m < length; m++)
//         {
//             if (array[m] < array[minPositon]) minPositon = m;
//         }
//         int temporary = array[k];
//         array[k] = array[minPositon];
//         array[minPositon] = temporary;
//         Console.Write($"{array[k]} ");
//     }
//     Console.Write($"{array[length-1]} ");
// }



void InputAndSortArrayMax()
{
    Console.Write("Enter the lenght of the disired array -> ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter the element № {i} of the array -> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Your array is: ");
    for (int j = 0; j < length; j++)
    {
        Console.Write($"{array[j]} ");
    }

    Console.WriteLine();

    Console.Write("Your arranged array -> ");
    for (int k = 0; k < length - 1; k++)
    {
        int maxPositon = k;

        for (int m = k + 1; m < length; m++)
        {
            if (array[m] > array[maxPositon]) maxPositon = m;
        }
        int temporary = array[k];
        array[k] = array[maxPositon];
        array[maxPositon] = temporary;
        Console.Write($"{array[k]} ");
    }
    Console.Write($"{array[length-1]} ");
}

Console.Clear();
// InputAndSortArrayMin();
InputAndSortArrayMax();


