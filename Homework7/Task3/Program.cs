// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputIntNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
    int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber;
}

void FillIntArray2Drandom(int[,] array, Random rnd, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }

    }
}

void PrintIntArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintColumnsAverageArray2D(int[,] array)
{
    double columnSum;
    for (int i = 0; i < array.GetLength(0); i++)
    {   columnSum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            columnSum=columnSum+array[j, i];
        }
        System.Console.Write($"{columnSum/array.GetLength(0) :f2};\t");
    }
}

int m = InputIntNumber("number of rows:");
int n = InputIntNumber("number of columns:");
int[,] intArray2D = new int[m, n];
Random rnd = new Random();
FillIntArray2Drandom(intArray2D,rnd,1,9);
PrintIntArray2D(intArray2D);
PrintColumnsAverageArray2D(intArray2D);