// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Random rnd = new Random();
string dataTxt = ReadFromFile("Data.txt");
string[] numbersArray = dataTxt.Split(',');
System.Console.WriteLine("Массив До случайной сортировки:");
PrintArray(numbersArray);
RndSortArray(numbersArray);
System.Console.WriteLine("Массив После случайной пересортировки:");
PrintArray(numbersArray);

string ReadFromFile(string filename)                             //Выгрузка из файла
{
    using (FileStream stream = File.OpenRead(filename))
    {
        byte[] array = new byte[stream.Length];
        stream.Read(array, 0, array.Length);
        string text = System.Text.Encoding.Default.GetString(array);
        return text;
    }
}

void RndSortArray(string[] array)
{
    int arrayLength = array.Length;
    string temp;
    int j;
    for (int i = 0; i < arrayLength; i++)
    {
        j = rnd.Next(0, arrayLength);
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

    }
}

void PrintArray(string[] array)
{
    int arrayLength = array.Length;
    System.Console.Write("[");
    for (int i = 0; i < arrayLength; i++)
    {
        if (i == arrayLength - 1) System.Console.WriteLine($"{array[i]}]");
        else System.Console.Write($"{array[i]},");
    }

}

