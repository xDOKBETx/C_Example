﻿// Поиск позиции нужного элемента массива.

int[] array = { 11, 56, 565, 68, 96, 32, 64, 68 };

int n = array.Length;  // n -- число элементов массива. array.Lenght -- длина массива.

int find = 68;  // find -- искомое число. В моём случае это 68.

int index = 0;

while(index< n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        // В этом примере оператор break остановит выполнение цикла после первого найденного элемента удовлетворяющего условию if.
        break; /* Оператор break завершает выполнение ближайшего внешнего break (то есть цикла for, foreach, while или do) или for.
        Оператор break передает управление оператору, который расположен после завершенного оператора (если таковой есть) */
    }
    index++;
}
