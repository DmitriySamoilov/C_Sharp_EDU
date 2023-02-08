// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

System.Console.Write("Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns:");
int n = Convert.ToInt32(Console.ReadLine());

int count = m*n;
int[,] sArray = new int[m, n];

SpiralFillArray(sArray);
PrintArray2D(sArray);

void SpiralFillArray(int[,] array, int a = 0)
{   
    int m=array.GetLength(0);
    int n = array.GetLength(1);
    
    if (a >= m || a >= n) return;

    for (int i = 0 + a; i < n - a; i++)
    {
        if (array[0 + a, i] > 0) return;
        array[0 + a, i] = count;
        count--;
    }
    for (int j = 1 + a; j < m - a; j++)
    {
        if (array[j, n - 1 - a] > 0) return;
        array[j, n - 1 - a] = count;
        count--;
    }
    for (int k = n - 2 - a; k >= 0 + a; k--)
    {
        if (array[m - 1 - a, k] > 0) return;
        array[m - 1 - a, k] = count;
        count--;
    }
    for (int l = m - 2 - a; l > 0 + a; l--)
    {
        if (array[l, 0 + a] > 0) return;
        array[l, 0 + a] = count;
        count--;
    }

    SpiralFillArray(array, a + 1);
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(String.Format("{0,5}", array[i, j]));
        }
        System.Console.WriteLine();
    }
}