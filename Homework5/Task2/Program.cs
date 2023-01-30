// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.Write("Размер массива --> ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
Random rnd = new Random();

FillRandomArray(array, len);
PrintArray(array, len);
System.Console.WriteLine($"Sum odd index= {SumOddIndex(array, len)}");


void FillRandomArray(int[] array, int length)
{

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-99, 100);
    }
}

void PrintArray(int[] array, int length)
{
    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1) System.Console.Write($"{array[i]},");
        else System.Console.WriteLine($"{array[i]}]");
    }
}

int SumOddIndex(int[] array, int length)
{
    int sum = 0;
    for (int i = 1; i < length; i +=2)
    {
        sum=sum+array[i];
    }
    return sum;
}
