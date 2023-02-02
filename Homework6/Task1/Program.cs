// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int [] StringToIntArray(string sourceString) // Исходный string расскладываем на int массив по набору разделителей
{
    char[] separators = new char []{' ',',',';','/','.'};
    string[] arrayString=sourceString.Split(separators,StringSplitOptions.RemoveEmptyEntries);
    int[] arrayInt= Array.ConvertAll(arrayString,int.Parse);
    return  arrayInt;
}
void PrintArray(int [] array)   //Печатаем массив для проверки
{
foreach (int item in array)
{
    System.Console.Write($"{item} ");
}
}

System.Console.Write("Input integer numbers: ");
string ? inputedString=Console.ReadLine();
if (inputedString==null) {System.Console.WriteLine("Something is going wrong!"); return;}

int [] array= StringToIntArray( inputedString);

PrintArray(array);

int count=0;
foreach (int item in array)
{
    if (item>0) count++;
}

System.Console.WriteLine($"\n {count} more than 0 numbers");





