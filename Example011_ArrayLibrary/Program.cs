// Поиск позиции(индекса) элемента массива при помощи метода

void FillArray(int[] collection)
/*
void -- метод, который ничего не возвращает. Если будет оператор return, то метод void исключается.
FillArray -- произвольное название метода(должно иметь логическую связь с поставленной задачей).
int[] collection -- аргумент метода
*/
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) /* IndexOf -- метод, который возвратит позицию(индекс)
int[] collection -- массив.
int find -- элемент массива.*/
{
    int count = collection.Length; // Количество элементов массива
    int index = 0; // Счётчик.
    int position = -1; /* Переменная для позиции(индекса) элемента в массиве. 
    В оригинале начиная от 0.
    Но, если искомого числа в массиве не окажется, то в данном варианте, программа вернёт значение -1 */
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // Остановка выполнения цикла после нахождения первого соответсвия искомому числу
        }
        index++;
    }
    return position; // Возврат позиции элемента массива.
}

int[] array = new int[10]; // new int[10] -- новый массив состящий из 10 элементов.

FillArray(array); // Вызов метода FillArray, который заполнил массив случайными числами.
PrintArray(array); // Вызов метода PrintArray, который распечатал массив.
Console.WriteLine();

int pos = IndexOf(array, 4); /* Переменная pos в которую складываем результат работы метода IndexOf
array -- аргумент метода. В текущей задаче равен массиву.
4 -- искомое число*/
Console.WriteLine(pos);
