// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// 


System.Console.Write("Размер массива --> ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
Random rnd = new Random();

FillRandomArray(array, len);
PrintArray(array, len);
System.Console.WriteLine($"В массиве {CountEvenNumbers(array, len)} чётных числа(ел).");


void FillRandomArray(int[] array, int length)
{

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int CountEvenNumbers(int[] array, int length)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}
