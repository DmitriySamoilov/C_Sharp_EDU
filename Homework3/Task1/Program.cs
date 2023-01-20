// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.Clear();
System.Console.Write("Введите число/фразу (Пример: А роза упала на лапу Азора): ");
string? input = Console.ReadLine();
if (input == null) return;
input = input.ToLower();

input = BlankSpaceDel(input);                //Удалили пробелы

int len = input.Length;                        //Опредилили количество символов
char[] array = new char[len];                  //Объявили массив нужной длинны

FillArray(input, array);                      //Заполнили массив символами. В массив добавил для тренировки работы с циклом foreach. Задачу можно решить без использования массива.

System.Console.WriteLine(CheckPalindr(array));   //Проверка и вывод результата



string BlankSpaceDel(string str)           // Удаляет пробелы
{
    string strRezult = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (!(str[i] == ' ')) { strRezult = strRezult + str[i]; }
    }

    return strRezult;
}

void FillArray(string str, char[] array)    //Вставляет посимвольно в массив.
{
    int i = 0;
    foreach (char item in str)
    {
        array[i] = item;
        i++;
    }
}

string CheckPalindr(char[] array)          //Проверяет массивы на палиндром            
{
    int len = array.Length;
    int i = 0;
    while (i < (len / 2))
    {
        if (array[i] == array[len - i - 1]) { i++; }
        else return "Не палиндром";
    }
    return "Палиндром";
}

