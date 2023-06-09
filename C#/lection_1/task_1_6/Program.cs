Console.WriteLine("Enter five different numbers:");
Console.WriteLine("a = 1");
int a = 1;
Console.WriteLine("b = 4");
int b = 4;
Console.WriteLine("c = 5");
int c = 5;
Console.WriteLine("d = 3");
int d = 3;
Console.WriteLine("e = 2");
int e = 2;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Max = ");
Console.WriteLine(max);