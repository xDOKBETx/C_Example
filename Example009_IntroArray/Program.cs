// Нахождение максимума из массива.


int Max(int arg1, int arg2, int arg3) // Функция Max с аргументами arg1, arg2, arg3
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;  // Оператор return завершает выполнение метода, в котором он присутствует, и возвращает управление и результат функции (при его наличии) вызывавшему метод
}   //           0   1   2   3   4   5   6   7   8   индексы элементов массива
int[] array = { 11, 27, 87, 760, 90, 74, 43, 55, 18 };
/* array[0] = 12; // Можно отдельно присвоить нулевому элементу массива другое значение. Например: 12 
Console.WriteLine(array[0]); */

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);