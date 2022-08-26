// Вид метода 1 void, который ничего не принимает и ничего не возвращает.

void Method1()
{
    Console.WriteLine("Aleksey");
}
// Method1(); // Вызов метода
/*-------------------------------------------------------------------------------------*/

// Вид метода 2 , который принимает какие-то аргументы, но ничего не возвращает.

void Method2(string msg) // В скобках аргумент
{
    Console.WriteLine(msg);
}
// Method2("Text message");
/*-------------------------------------------------------------------------------------*/

void Method21(string msg, int count) // Бывают именованные аргументы
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // Увеличение счётчика на 1 называется инкрементом
    }
}
// Method21("Text message", 7); // 7 -- количество вывода аргумента msg
// Можно и так:
// Method21(msg: "Text message", count: 7); 
/* Можно поменять местами аргументы в скобках. 
Например: (count: 7, msg: "Text")
--------------------------------------------------------------------------------------*/

// Вид метода 3, который что-то возвращает, но ничего не принимает.

int Method3()
{
    return DateTime.Now.Month; // Возвращает дату месяца
}
int month = Method3(); // Переменная, которой присваивается метод
// Console.WriteLine(month);
/*-----------------------------------------------------------------------------------*/

// Вид метода 4, который что-то принимает и возвращает.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // result изначально будет пустой строкой String.Empty
//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result; // Возврат переменной(результата)
// }
/*--------------------------------------------------------------------------------------------*/

string Method4(int count, string text)
{

    string result = String.Empty; // result изначально будет пустой строкой String.Empty
    for (int i = 0; i < count; i++) /* for -- оператор цикла(итераций)
    int i -- инициализация переменной для счётчика.
    i < count -- условие выполнения цикла.
    i++ -- увеличение счётчика +1.*/

    {
        result = result + text;
    }
    return result; // Возврат переменной(результата)
}

string res = Method4(10, "Методы"); // Создание переменной для вызова метода
// Console.WriteLine(res);
/*---------------------------------------------------------------------------------------------*/

// Таблица умножения при помощи цикла for.

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}"); // Интерполяция строк
//     }
//     Console.WriteLine();
// }
/*----------------------------------------------------------------------------------------------*/


// Работа с текстом
// Дан текст. В тексте все пробелы нужно заменить черточками,
// маленькие буквы "к" заменить на большие "К",
// а большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь. улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345  -- индексы(символы) строки
// s[4] == t

string Replace(string text, char oldValue, char newValue)
// char -- символьный тип данных
{
    string result = String.Empty;
    int lenght = text.Length; // Переменная которой присваивается количество символов строки
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // Если символ совпал, то в результат ложим новый символ
        else result = result + $"{text[i]}"; // Иначе возвращаем символ
    }
    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);

/*----------------------------------------------------------------------------------------*/

// Сортировка массива от минимального к максимальному

int[] arr = { 5, 3, 8, 4, 2, 9, 1, 6, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)  // (array.Length - 1) -- Чтобы пройти по всем элементам массива
    {
        int minPosition = i;  // Переменная с которой предстоит работать 
        for (int j = i + 1; j < array.Length; j++)  // (i + 1) -- Чтобы начинать работу со следующей позицией после уже отсортированного элемента
        {
            if (array[j] < array[minPosition]) minPosition = j;  // Поиск минимального элемента массива
            // Чтобы отсортировать от большего к меньшему, нужно поменять знак "<" на ">"
        }
        int temporary = array[i]; // Временная переменная для работы с позицией элемента, которую нашли
        array[i] = array[minPosition]; // Обмен переменных в массиве местами
        array[minPosition] = temporary; // Присваивание рабочей переменной значение временной
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
