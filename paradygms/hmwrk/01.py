from random import randint
from math import factorial


def li():  # Create list
    list_item = []
    p = randint(10, 20)
    i = 0
    while i <= p:
        list_item.append(randint(0, 10))
        i += 1
    print(f'Given list -> {list_item}')
    return list_item

# Обязательные задачи:

# Императивное программирование:
# Задача 1: Подсчет суммы четных чисел от 1 до N. Напишите программу, используя цикл,
# которая находит сумму всех четных чисел в диапазоне от 1 до заданного числа N.


print('Task 1')
n = int(input('Input N -> '))
item = 2
result = 0
while item <= n:
    result += item
    item += 2
print(f'Sum of the even numbers from 1 to {n} -> {result}')
print()
print()

# Задача 2: Поиск наименьшего числа в списке. Напишите программу,
# которая находит наименьшее число в заданном списке с помощью цикла.

print('Task 2')
my_list = li()  # Create new list

min = my_list[0]
i = 1
p = len(my_list)
while i < p:  # Search min
    if my_list[i] < min:
        min = my_list[i]
    i += 1
print(f'The min value in the list -> {min}')
print()
print()


# Декларативное программирование:
# Задача 3: Вычисление факториала числа. Напишите программу, которая находит факториал заданного числа N
# с использованием рекурсии или встроенных функций.

print('Task 3')
print(f'Factorial -> {factorial(int(input("Input N! -> ")))}')
print()
print()

# Задача 4: Поиск уникальных элементов в списке. Напишите программу, которая создает новый список,
# содержащий только уникальные элементы из исходного списка.

print('Task 4')
print(f'New list (only unique values) -> {list(set(li()))}')
print()
print()

# Дополнительные сложные задачи (по желанию):

# Императивное программирование:
# Задача 5: Поиск простых чисел. Напишите программу, которая находит все простые числа в заданном диапазоне от 1 до N.

print('Task 5')
m = int(input('Input N -> '))

for i in range(2, m+1):
    check = True
    for j in range(2, m):
        if i != j and i % j == 0:
            check = False
    if check:
        print(f'{i} is simple number')
print()
print()


# Задача 6: Упорядочивание списка. Напишите программу, которая сортирует список чисел в порядке возрастания
# с использованием пузырьковой сортировки или другого метода сортировки.

print('Task 6')
my_third_list = li()
length = len(my_third_list)
for i in range(length-1):
    for j in range(i+1, length):
        if my_third_list[i] > my_third_list[j]:
            my_third_list[i], my_third_list[j] = my_third_list[j], my_third_list[i]
print(f'Sorted list -> {my_third_list}')
print()
print()

# Декларативное программирование:
# Задача 7: Поиск подстроки. Напишите программу, которая находит все вхождения заданной подстроки в строке
# с использованием встроенных функций.

print('Task 7')


def find_all_occurrences(main_string, substring):
    occurrences = [(i, i + len(substring)-1) for i in range(len(main_string) -
                                                            len(substring) + 1) if main_string[i:i + len(substring)] == substring]
    return occurrences


main_string = input("Input string: ")
substring = input("Input substring: ")

occurrences = find_all_occurrences(main_string, substring)

if occurrences:
    print("There are occurences here:")
    for start, end in occurrences:
        print(f"Start char index: {start}, end char index: {end}")
else:
    print("There aren't any occurences")

print()
print()


# Задача 8: Вычисление суммы цифр числа. Напишите программу, которая вычисляет сумму всех цифр заданного числа,
# используя математические операции и деление нацело.

print('Task 8')


def sum_digits(number):
    return ((number % 10) + (sum_digits(number//10)) if number >= 10 else number)


number = int(input('Input N -> '))
print(sum_digits(number))