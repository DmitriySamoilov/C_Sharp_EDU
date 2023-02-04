// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

//Игра Морской бой (шутка)

int[,] array = new int[10, 10];
Random rnd = new Random();
FillIntArray2Drandom(array, rnd, 10, 30);
System.Console.WriteLine("Сыграем в игру?");
bool keepLooping = true;
while (keepLooping)
{
    int rowNumber = InputIntNumber("number of row");
    int columnNumber = InputIntNumber("number of column");
    if (rowNumber >= array.GetLength(0) || columnNumber >= array.GetLength(1) || rowNumber < 0 || columnNumber < 0) //Индекс за пределами массива. Выход
    {
        System.Console.WriteLine($"Выстрел...Вы улетели в космос. Такого элемента нет.");
        keepLooping = false;
    }
    //Проверяем и выводим значение
    else if (array[rowNumber, columnNumber] % 5 == 0) System.Console.WriteLine($"Выстрел... Убит. [{rowNumber},{columnNumber}] = {array[rowNumber, columnNumber]}");
    else if (array[rowNumber, columnNumber] % 3 == 0) System.Console.WriteLine($"Выстрел... Ранен. [{rowNumber},{columnNumber}] = {array[rowNumber, columnNumber]}");
    else System.Console.WriteLine($"Выстрел... В молоко. [{rowNumber},{columnNumber}] = {array[rowNumber, columnNumber]}");
}
PrintIntArray2D(array);
