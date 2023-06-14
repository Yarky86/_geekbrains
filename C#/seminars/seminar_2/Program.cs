// //Проверка кратности двух чисел
// void CheckMultiplicity(int num1, int num2)
// {
//     if (num2 % num1 == 0)
//     {
//         Console.WriteLine($"The number {num2} multyplies {num1} {num2 / num1} times");
//     }
//     else
//     {
//         Console.WriteLine($"The number {num2} doesn't multyplie {num1}, modulo is equal {num2 % num1}");
//     }
// }
// Console.Write("Enter the first number -> ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number -> ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// CheckMultiplicity(numb1, numb2);

// // Проверка кратности числа одноверменно 7 и 23
// void CheckMultiplicitySpecial(int inputNumber, int checkNumber)
// {
//     if (inputNumber % checkNumber == 0)
//     {
//         Console.WriteLine($"The number {inputNumber} multiplies {checkNumber}");
//     }

//     else
//     {
//         Console.WriteLine($"The number {inputNumber} doesn't multiplie {checkNumber}");
//     }
// }

// Console.Write("Enter the number -> ");
// int numb = Convert.ToInt32(Console.ReadLine());

// CheckMultiplicitySpecial(numb, 7);
// CheckMultiplicitySpecial(numb, 23);



// ЗАДАЧИ СЕМИНАР
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98


int ReplaceNumber(int num)
{
    int excludeThirdDigit = (num / 100) * 10;
    int excludeFirstDigit = num % 10;
    int final = excludeThirdDigit + excludeFirstDigit;
    return final;
}

int randNumb = new Random().Next(100, 1000);
Console.WriteLine($"The random three-digit number -> {randNumb}");

int a = ReplaceNumber(randNumb);
Console.WriteLine($"The new two-digit number -> {a}");



// // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void CheckSquare(int number1, int number2)
// {
//     if (number1 * number1 == number2 || number2 * number2 == number1)
//     {
//         Console.WriteLine($"Yes, one of the numbers is a square of the other");
//     }
//     else
//     {
//         Console.WriteLine($"No, neither numbers is a square of the other");
//     }
// }

// Console.Write("Enter the first number -> ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number -> ");
// int numb2 = Convert.ToInt32(Console.ReadLine());

// CheckSquare(numb1, numb2);

