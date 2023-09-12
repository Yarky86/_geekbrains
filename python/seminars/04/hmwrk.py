print('''Task 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества.
Затем пользователь вводит сами элементы множеств.''')

a = int(input('Input a count of numbers in the First list: '))
b = int(input('Input a count of numbers in the Second list: '))

a_list = []
b_list = []
for i in range(a):
    a_list.append(int(input(f'Input a[{i}]: ')))

for i in range(b):
    b_list.append(int(input(f'Input b[{i}]: ')))

print(f'First list: {a_list}')
print(f'Second list: {b_list}')

# a_list = [10, 9, 2, 5, 7, 4, 5, 3, 6, 4, 5, 7, 5, 8, 6, 8, 2, 4, 9]
# b_list = [10, 9, 6, 8, 7, 3, 9, 5, 3, 7, 5, 8, 7, 4, 6, 3, 2, 7, 5, 8, 4, 6, 9]

c = set(a_list) & set(b_list)

# print(c)

c_list = list(c)
c_list.sort()
print(f'Here is the ascended intersection of the First and Second lists {c_list}')

print()
print()

print('''Задача 24: В фермерском хозяйстве в Карелии выращивают чернику.
Она растёт на круглой грядке, причём кусты высажены только по окружности.
Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растёт N кустов.
Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод — на i-ом кусте выросло ai ягод.
В этом фермерском хозяйстве внедрена система автоматического сбора черники.
Эта система состоит из управляющего модуля и нескольких собирающих модулей.
Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.
Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль,
находясь перед некоторым кустом заданной во входном файле грядки.''')


d = int(input('Input count of bushes: '))

d_list = []
for i in range(d):
    d_list.append(int(input(f'Input count of berries on the {i+1}-th bush: ')))


print(f'Your blueberry bed: {d_list}')

max = 0
for i in range(d):
    try_max = d_list[i] + d_list[i-2] + d_list[i-1]
    if try_max > max:
        max = try_max
        start_point = i+1
print(f'The max count of berries is: {max}')
