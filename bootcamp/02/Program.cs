// 1. Constant algorythms (sum of numbers from 1 to n) - O(1)

Console.Clear();
Console.WriteLine("Input your number ->");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Result is: {(1 + n) / 2.0 * n}");


// 2. Line algorythms - 0(n)

int result = 0;
for (int i = 1; i <= n; i++)
{
    result += i;
}
Console.WriteLine($"2nd result is: {result}");

/*  3. Square algorythms (Bubble sorting, choice sorting, paste sorting ) - O(n^2)
[4, 21, -3, 56, 78, 5]
4 < 21
21 > -3 !!! -2 <-> 21
[4, -3, 21, 56, 78, 5]
21 < 56
56 < 78
78 > 5 !!! 5 <-> 78
[4, -3, 21, 56, 5, 78]
4 > -3 !!! -3 <-> 4
[-3, 4, 21, 56, 5, 78]
4 < 21
21 < 56
56 > 5 !!! 5 <-> 56
[-3, 4, 21, 5, 56, 78]
56 < 78
-3 < 4
4 < 21
21 > 5 !!! 5 <-> 21
[-3, 4, 5, 21, 56, 78]
21 < 56
56 < 78
-3 < 4
4 < 5
5 < 21
21 < 56
56 < 78




4. Logariphmic algorythms (Binary search) - O(log2(n))
Guess a number from 1 to 100
68
from 1 to 100
>50? y -> from 51 to 100
>75? n -> from 50 to 75
>62? y -> from 63 to 75
>69? n -> from 63 to 69
>66? y -> from 67 to 69
>67? y -> from 68 to 69
>68? n -> 68
O(log2(n)) -> log2(100) = 7

5. Line-logariphmic algorytms (Fast sorting) - O(n * log2(n))
[4, 21, -3, 56, 78, 5]
base element -> 4
[21, 56, 78, 5]
[-3] + [4] + [21, 56, 78, 5]
base element -> 21
[5] + [21] + [56, 78]
[-3] + [4] + [5] + [21] + [56, 78]
base element -> 56
[] + [56] + [78]
[-3] + [4] + [5] + [21] + [56] + [78]

6. Cubic algorytms (filling three-dimensions array) - O(n^3)

*/