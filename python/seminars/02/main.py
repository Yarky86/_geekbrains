
# # Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом.
# # Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной.
# # Выведите минимальное количество монет, которые нужно перевернуть

n = int(input("Input number of coins, n: "))
count0 = 0
count1 = 0
for i in range(n):
    coin = int(input(f"coin {i+1}: 0(face) or 1(reverse)? -> "))
    if coin == 0:
        count0 += 1
    else:
        count1 += 1
print(f'Min coins to revert: {count1}' if count0 >
      count1 else f'Min coins to revert: {count0}')


# Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница.
# Петя помогает Кате по математике. Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать.
# Для этого Петя делает две подсказки. Он называет сумму этих чисел S и их произведение P.
# Помогите Кате отгадать задуманные Петей числа.

sum = int(input('Input the summary of the numbers: '))
mult = int(input('Input the multiply of the numbers: '))
#  x + y = sum -> x = sum - y
#  x * y = mult -> (sum - y) * y = mult -> sum*y - y^2 - mult = 0 -> y^2 - sum*y + mult = 0 -> D = sum^2 - 4*mult,
# y1 = (sum + (sum ** 2 - 4 * mult)**0.5) / 2
# x1 = sum - y1
# print("Numbers solved via formula:")
# print(f'X = {int(x1)}')
# print(f'Y = {int(y1)}')

count = True
for i in range (int(1+sum/2)):
    for j in range (int(sum)):
        if (i*j == mult) and (i+j == sum) and count:
            print(f"X = {i}, Y = {j}")
            count = False



# Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.

N = int(input('Input N: '))
a = 2
for i in range (N+1):
    print(f"2^{i} = {a**i}")
