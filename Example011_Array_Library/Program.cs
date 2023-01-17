//Console.Clear();

void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        System.Console.Write($" {array[index]} ");
        index++;
    }
}

int Indexof(int[] array, int findElement)
{
    int index = 0;
    int position = -1;
    bool keepLoop=true;
    while ((index < array.Length)&&(keepLoop))
    {
        if (array[index] == findElement)
        {
            position = index;
            keepLoop=false;              //Прерывает цикл
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
int findIndex = Indexof(array, 5);
System.Console.WriteLine();
System.Console.WriteLine(findIndex);