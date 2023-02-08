// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();

int[,] array = new int[rnd.Next(4, 20), rnd.Next(4, 20)];

System.Console.WriteLine($"Matrix {array.GetLength(0)} x {array.GetLength(1)}");

int rowSum = 0, rowSumMin = int.MaxValue, rowIndexMin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(100);
        Console.Write(String.Format("{0,5}", array[i, j]) + "  ");
        rowSum += array[i, j];
    }
    Console.Write(String.Format("{0,10}", $"{rowSum} ({i})\n"));
    
    if (rowSum < rowSumMin) { rowSumMin = rowSum; rowIndexMin = i; }
    rowSum = 0;
}

System.Console.WriteLine($"Наименьшая сумма элементов: {rowIndexMin} строка");