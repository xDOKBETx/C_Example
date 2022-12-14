/* Вычислит a в степени n
*/

// Итеративный способ
int PowerFor(int a, int n)
{
    int result = 1; // Переменной result присваиваем значение 1
    for (int i = 1; i <= n; i++) result *= a; // Для переменной-счётчика i с присвоеным значением 1;
    // Условие: Пока i меньше-равно n; увеличиваем i на +1
    return result; // Возвращаем result
}

// Рекурсионный способ
int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // Альтернативный способ написания кода
    if (n == 0) return 1; // Если n равно 0, возвращаем 1
    else return PowerRec(a, n - 1) * a; // Иначе возвращаем рекурсивную функцию где аргумент показателя степени уменьшаем на -1 и всё это умножаем на текущее основание степени.
}

// Альтернативная рекурсия
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);  // Иначе, если остаток от деления на 2 четное число,
    // возвращаем вызов функции с аргументами, где основание степени умножаем на себя, а показатель степени делим на 2
    else return PowerRecMath(a, n - 1) * a; // Иначе возвращаем рекурсивную функцию где аргумент показателя степени уменьшаем на -1 и всё это умножаем на текущее основание степени.
}
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
