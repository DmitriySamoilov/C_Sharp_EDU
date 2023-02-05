// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.Write("Размер массива --> ");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = new double[len];
Random rnd = new Random();

FillArray(array, len);
PrintArray(array, len);
System.Console.WriteLine($"Max {array.Max()} Min {array.Min()} Разница max-min= {array.Max()-array.Min()}");

void FillArray(double[] array, int length)
{

    for (int i = 0; i < length; i++)
    {
        array[i] = GenRandomDouble(-100,100, rnd);
    }
}

void PrintArray(double[] array, int length)
{
    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1) System.Console.Write($" {array[i]} ; ");
        else System.Console.WriteLine($"{array[i]} ]");
    }
}

double GenRandomDouble(int a, int b, Random rnd)
{
  double rndDouble = a + rnd.NextDouble()*(b-a);
  return rndDouble;
}