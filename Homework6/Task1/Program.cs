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

System.Console.Write("Input integer numbers: ");
string ? inputedString=Console.ReadLine();
if (inputedString==null) {System.Console.WriteLine("Something is going wrong!"); return;}

int [] array= StringToIntArray( inputedString);

Console.WriteLine("{"+ String.Join(",", array)+"}");//Печатаем массив для проверки

int count = array.Count(x => x > 0);
System.Console.WriteLine($"{count} numbers more than 0");

// foreach (int item in array)
// {
    // if (item>0) count++;
// }

// Console.Write("Введите элементы, используя между ними запятую: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
// int count = array.Count(x => x > 0);
// Console.WriteLine($"Количество элементов больше ноля: {count}");

