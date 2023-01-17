// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int Number_1_7()  //Метод генерации числа 1-7
{
    int number;         //Возвращаемое число
    bool trPBool;       //Результат TryParse
    string? request;    //Первичный текстовый запрос
    while (true)
    {
        System.Console.Write("Введите число 1-7: ");
        request =Console.ReadLine();                   //Запрос числа
        trPBool=int.TryParse (request, out number);    //Конверсия string в int. true - удачно, false - нет, number - результат конверсии
        if (trPBool&&number > 0 && number < 8) break; //Выход из цикла
        System.Console.WriteLine("Ошибка");
    }
    return number;
}

int weekDayNumber = Number_1_7();                                        //Запрос числа
string[] weekDays = { "Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да" };  //Распределение выходных по неделе 

System.Console.WriteLine(weekDays[(weekDayNumber - 1)]);                //Вывод результата