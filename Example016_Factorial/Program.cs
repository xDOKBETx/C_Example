/* Факториал числа
*/

// Итеративный способ:
int FactorialFor(int n)
{
    int result = 1; // Переменная result с входящим значением 1
    for(int i = 1; i <= n; i++) result *= i; // Для переменной-счётчика i задаём первончальное значение 1;
    // Условие: пока i меньше-равно n; увеличение значения i на +1
    return result; // Возврат result
}

// Рексурсионный способ:
int FactorialRec(int n)
{
    if(n == 1 || n == 0) return 1; // Если n равно 1 или n равно 0, возвращаем 1
    else return n * FactorialRec(n - 1); // Иначе возвращаем текущее значение n умноженное на вызов рекурсивной функции с аргументом уменьшенном на -1
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
