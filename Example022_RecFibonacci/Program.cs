/* Выведем числа фибоначчи рекурсией и итеративным методом.
определим скорость работы
*/

decimal fRec = 0;//для подсчёта итераций
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
DateTime dt = DateTime.Now; //для подсчёта времени

for (int n = 10; n < 40; n++) //подсчёт чисел итеративный
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");//Tсколько итераций цикла потребовалось //ToString("### ### ###) - числа друг над другом
    fIte = 0; // обнуляем счётчик чтобы считать итерации для каждого числа
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();

dt = DateTime.Now; //для подсчёта времени
for (int n = 10; n < 40; n++) //подсчёт чисел рекурсивный
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-1}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
