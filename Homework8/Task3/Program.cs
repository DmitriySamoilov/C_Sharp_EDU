// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Random rnd = new Random();
int m = rnd.Next(2, 10), n = rnd.Next(2, 10),m1=rnd.Next(2, 10);
int[,] array1 = new int[m, n];
int[,] array2 = new int[n, m1];

FillRnd2DarrayAndPrintIt(array1, rnd, 0, 10);
FillRnd2DarrayAndPrintIt(array2, rnd, 0, 10);
int[,]? MultRes = Arrays2DMultiplicationFunc(array1, array2);

void FillRnd2DarrayAndPrintIt(int[,] array, Random rnd, int min, int max)
{
    System.Console.WriteLine($"Matrix {array.GetLength(0)} x {array.GetLength(1)}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
            Console.Write(String.Format("{0,5}", array[i, j]) + "  ");
        }
        System.Console.WriteLine();
    }
}

int [,] ? Arrays2DMultiplicationFunc(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) { System.Console.WriteLine("Ошибка. Матрицы не совпадают по размеру!"); return null; }
    int m = array1.GetLength(0);
    int n = array2.GetLength(1);
    int m1=array1.GetLength(1);
    int[,] result = new int[m, n];

    System.Console.WriteLine($"Result matrix {m} x {n}");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
                for (int l = 0; l < m1; l++)
                {

                    result[i, j] += (array1[i, l] * array2[l, j]);
                }
                Console.Write(String.Format("{0,5}", result[i, j]) + "  ");
            
        }
        System.Console.WriteLine();
    }
    return result;
}
