/* Собрать строку с числами от меньшего к большему от a до b, a <= b
*/

string NumbersFor(int a, int b) // Строковая функция
{
    string result = String.Empty;  // Пустая строка
    for (int i = a; i <= b; i++) // Для счётчика i присваиваем значение a; пока i меньше-равно b; увеличиваем значение счётчика на +1
    {
        result += $"{i} "; // Записываем в result значения счётчика + прибавляем к нему result(result = result + $"{i}")
    }
    return result; // Возвращаем result
}

string NumbersRec(int a, int b) // Строковая функция
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); // Если a меньше-равно b, 
    // возвращаем значение a + вызываем функцию в которой увеличиваем значение первого аргумента a на 1 
    else return String.Empty; // Иначе возвращаем пустую строку
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
