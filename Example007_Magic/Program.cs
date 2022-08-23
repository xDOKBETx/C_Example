// Рисуем в консоли. Задача с тремя точками.

Console.Clear(); // Очистка консоли.
// Console.SetCursorPosition(10, 4); // Метод устанавливающий положение курсора.
// Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;  // инициализация счётчика 

while (count < 10000)  // while -- условие продолжения(цикл) для которого обязательно нужен счётчик
{
    int what = new Random().Next(0, 3); // [0, 3) -- полуинтервал 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
        if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
        if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
