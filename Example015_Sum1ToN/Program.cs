/* Сумма чисел от 1 до n
*/

// Итеративный метод
int SumFor(int n)
{
    int result = 0; // Переменная с первоначальным нулевым значением
    for(int i = 1; i <= n; i++) result += i; // Для счётчика i равного 1;
    // пока выполняется условие где i <= n; увеличивываем значение счётчика на +1
    return result; // Возврат result
}

// Рекурсивный метод
int SumRec(int n)
{
    if(n == 0) return 0; // Если n равно 0, возвращаем 0
    else return n + SumRec(n - 1); // Иначе возвращаем n + рекурсивный вызов функции с n - 1
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
