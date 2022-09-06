/* Собрать строку с числами от большего к меньшему от a до b, a >= b
*/

string NumbersFor(int a, int b) // Строковая функция
{
    string result = String.Empty;  // Пустая строка
    for (int i = a; i >= b; i--) // Для счётчика i присваиваем значение b; пока i больше-равно a; уменьшаем значение счётчика на -1
    {
        result += $"{i} "; // Записываем в result значения счётчика + прибавляем к нему result(result = result + $"{i}")
    }
    return result; // Возвращаем result
}

string NumbersRec(int a, int b) // Строковая функция
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; // Если a меньше-равно b, 
    // возвращаем вызываем функцию в которой увеличиваем значение первого аргумента a на 1 + значение a 
    else return String.Empty; // Иначе возвращаем пустую строку
}

Console.WriteLine(NumbersFor(10, 1));
Console.WriteLine(NumbersRec(1, 10));
