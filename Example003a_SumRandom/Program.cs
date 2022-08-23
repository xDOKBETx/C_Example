// Получение суммы двух чисел сгенерированных рандомно.

int numberA = new Random().Next(1, 100);  // 1,2,3,4,...99
Console.Write(numberA + " ");
int numberB = new Random().Next(1, 100);
Console.Write(numberB + " ");
/*int result = numberA + numberB;  result -- промежуточная переменная
Console.WriteLine(result); */
Console.WriteLine(numberA + numberB);