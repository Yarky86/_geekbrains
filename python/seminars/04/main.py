# #  Напишите программу, которая принимает на вход
# строку, и отслеживает, сколько раз каждый символ
# уже встречался. Количество повторов добавляется к
# символам с помощью постфикса формата _n.
# Input: a a a b c a a d c d d
# Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2
# Для решения данной задачи используйте функцию
# .split()

str_1 = 'a a a b c a a d c d d'
list_str = str_1.split()
print(list_str)
set_str = set(list_str)
print(set_str)
for j in set_str:
    count = 0
    for i in range(len(list_str)):
        if (j == list_str[i]) and count > 0:
            list_str[i] += f'_{count}'
            count += 1
        elif (j == list_str[i]) and count == 0:
            count += 1
print(str_1)

print(*list_str)

# for i in set_str:
#     print(i)

# for j in set_str:
#     count = 0
#     for i in range(len(list_str)):
#         if (j in list_str) and count > 0:
#             print(list_str[i])


# Пользователь вводит текст(строка). Словом считается
# последовательность непробельных символов идущих
# подряд, слова разделены одним или большим числом
# пробелов. Определите, сколько различных слов
# содержится в этом тексте.
# Input: She sells sea shells on the sea shore The shells
# that she sells are sea shells I'm sure.So if she sells sea
# shells on the sea shore I'm sure that the shells are sea
# shore shells
# Output: 13

str = "She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure. So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells"

a = len(set(str.split()))
print(set(str.split()))
print(a)


# Ваня и Петя поспорили, кто быстрее решит
# следующую задачу: “Задана последовательность
# неотрицательных целых чисел. Требуется определить
# значение наибольшего элемента
# последовательности, которая завершается первым
# встретившимся нулем (число 0 не входит в
# последовательность)”. Однако 2 друга оказались не
# такими смышлеными. Никто из ребят не смог до
# конца сделать это задание. Они решили так: у кого
# будет меньше ошибок в коде, тот и выиграл спор. За
# помощью товарищи обратились к Вам, студентам.

my_list = []
while True:
    a = int(input())
    if a == 0:
        b = max(my_list)
        print(b)
        break
    elif a < 0:
        print("The number can't be less than zero")
        continue
    my_list.append(a)


