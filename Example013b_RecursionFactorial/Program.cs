// Вычисление факториала через рекурсию.

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1; // Если n равно 1, то возвращаем 1
    else return n * Factorial(n - 1);  // Иначе возвращаем n умноженное на факториал(n - 1)
}
    for (int i = 1; i < 40; i++)
    {
        Console.WriteLine($"{i}! = {Factorial(i)}"); 
    }
