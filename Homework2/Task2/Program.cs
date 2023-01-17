// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

int Number()  //Метод генерации целого числа
{
    int number;         //Возвращаемое число
    bool trPBool;       //Результат TryParse
    string? request;    //Первичный текстовый запрос
    while (true)
    {
        System.Console.Write("Введите целое число ");
        request = Console.ReadLine();                   //Запрос числа
        trPBool = int.TryParse(request, out number);    //Конверсия string в int. true - удачно, false - нет, number - результат конверсии
        if (trPBool) break;                            //Выход из цикла при успешной конверсии
        System.Console.WriteLine("Ошибка");
    }
    return number;
}

int number = Number();//Получено целое число
if (number > 99 || number < -99)
{
    number = number / 100; //Число уменьшено на два разряда
    number = Math.Abs(number % 10); //Найдено третья цифра исходного числа
    System.Console.WriteLine($"Третья цифра {number}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}