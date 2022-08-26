﻿// Двухмерные массивы и рекурсия.

string[,] table = new string[2, 5]; // Массив из двух строк и пяти столбцов.
// String.Empty
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]
// table[1,3] = "слово";

// for (int rows = 0; rows < 2; rows++) // Цикл для строк
// {
//   for (int columns = 0; columns < 5; columns++) // Цикл для столбцов
//   {
//     Console.WriteLine($"-{table[rows, columns]}-");
//   }  
// }


void PrintArray(int[,] matr) // Метод печати массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // Можно заменить "3" на "matrix.GetLength(0)"
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Можно заменить "4" на "matrix.GetLength(1)"
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1, 10) -- это полуинтервал
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);