# Сумма квадратов четных чисел.

# imperative

def sum_sqr(n):
    result = 0
    for i in range (2, n+1, 2):
        result += i**2
    return result

result = sum_sqr(int(input('n = ')))
print(f'sum = {result}')

# declarative
def sum_sqr_dec(n):
    return sum(pow(n, 2))

result_dec = sum_sqr_dec(int(input('n_dec = ')))
print(f'sum_dec = {result_dec}')