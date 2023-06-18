// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPallindrome(int f)
{
    int firstD = f / 10000;
    int secondD = f / 1000 % 10;
    int fourD = f % 100 / 10;
    int fiveD = f % 10;
    if (firstD == fiveD && secondD == fourD)
    {
        Console.WriteLine($"The number {f} is palindrome");
    }
    else Console.WriteLine($"The number {f} is NOT palindrome");

}

Console.Clear();
Console.Write("Enter any 5-digit whole number -> ");
int five = Convert.ToInt32(Console.ReadLine());
CheckPallindrome(five);



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Hypotenuze(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Round((Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2))), 2);
}


Console.Write("Enter a coordinate xA -> ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate yA -> ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate zA -> ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate xB -> ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate yB -> ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate zB -> ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Well done! Now, you have two points with coordinates: the point A({xa}, {ya}, {za}), and the point B({xb}, {yb}, {zb})");

Console.WriteLine("The distance between points A & B -> " + Hypotenuze(xa, xb, ya, yb, za, zb));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ToCube(int numbber)
{
    int count = 1;
    Console.WriteLine($"Here are cubes for numbers from 1 to {numbber}:");
    if (count < numbber)
    {
        while (count <= numbber)
        {
            Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
            count++;
        }
    }
    else
        while (count >= numbber)
        {
            Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
            count--;
        }
}


Console.Write("Enter any whole number (N) to get cubes for all numbers in a range (1, |N|) -> ");
int scnumber = Convert.ToInt32(Console.ReadLine());
ToCube(scnumber);



