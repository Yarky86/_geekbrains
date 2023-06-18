// // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// // void CheckZero (int num)
// // {
// //     if (num == 0)
// //     {
// //         Console.Write("Sorry, you have input Zero, please enter other number -> ");
// //         num = Convert.ToInt32(Console.ReadLine());
// //     }
// // }
// int CheckQuadrant (int numberX, int numberY)
// {
//     int quad = 1;
//     if (numberX < 0)
//     {
//         quad = 2;
//         if (numberY < 0)
//         {
//             quad = 3;
//         }
//     }
//     else if (numberY < 0)
//     {
//         quad = 4;
//     }
//     return (quad);
// }
// Console.Clear();
// Console.Write("Enter X (X ≠ 0)-> ");
// int X = Convert.ToInt32(Console.ReadLine());
// // CheckZero(X);
// Console.Write("Enter Y (Y ≠ 0) -> ");
// int Y = Convert.ToInt32(Console.ReadLine());
// // CheckZero(Y);

// Console.WriteLine($"Your number is placed in the {CheckQuadrant(X, Y)} quadrant");


// //Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// //A (3,6); B (2,1) -> 5,09
// //A (7,-5); B (1,-1) -> 7,21

// double Hypotenuze(double x1, double x2, double y1, double y2)
// {
//     return Math.Round((Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))), 2);
// }

// Console.Clear();
// Console.Write("Enter a coordinate xA -> ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter a coordinate yA -> ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter a coordinate xB -> ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter a coordinate yB -> ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Well done! Now, you have two points with coordinates: the point A({xa}, {ya}), and the point B({xb}, {yb})");

// Console.WriteLine("The distance between points A & B -> " + Hypotenuze(xa, xb, ya, yb));


// // Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string ShowRangeQuadrant(int Q)
// {
//     if (Q==1) return ("range X: 0 < X < +∞, range Y: 0 < Y < +∞");
//     else if (Q==2) return ("range X: -∞ < X < 0, range Y: 0 < Y < +∞");
//     else if (Q==3) return ("range X: -∞ < X < 0, range Y: -∞ < Y < 0");
//     else if (Q==4) return ("range X: 0 < X < +∞, range Y: -∞ < Y < 0");
//     else return ("couldn't find the range for X & Y");
// }
// Console.Clear();
// Console.Write("Enter a number of a quadrant -> ");
// int quadr = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The allowable range for numbers belonging to the quadrant {quadr} -> {ShowRangeQuadrant(quadr)}");


// //Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void ToSquare(int numbber)
// {
//     int count = 1;
//     Console.WriteLine($"Here are squares for numbeers from 1 to |{numbber}|:");
//     while (count <= Math.Abs(numbber))
//     {
//         Console.WriteLine($"{count} -> {Math.Pow(count, 2)}");
//         count++;
//     }
// }

// Console.Clear();
// Console.Write("Enter any whole number (N) to get squares for all numbers in a range (1, |N|) -> ");
// int sqnumber = Convert.ToInt32(Console.ReadLine());
// ToSquare(sqnumber);
