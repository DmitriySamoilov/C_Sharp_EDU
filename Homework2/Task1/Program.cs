// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ThreeDigitalNumber()  //Метод генерации трехзначного числа
{
    int number;         //Возвращаемое число
    bool trPBool;       //Результат TryParse
    string? request;    //Первичный текстовый запрос
    while (true)
    {
        System.Console.Write("Введите трехзначное число ");
        request = Console.ReadLine();                   //Запрос числа
        trPBool = int.TryParse(request, out number);    //Конверсия string в int. true - удачно, false - нет, number - результат конверсии
        if (trPBool && number > 99 && number < 1000) break; //Выход из цикла для положительных чисел
        if (trPBool && number > -1000 && number < -99) break;  //Выход из цикла для отрицательных чисел
        System.Console.WriteLine("Ошибка");
    }
    return number;
}



int number = ThreeDigitalNumber();
number = number / 10; //Число преобразовано в двухзначное
number = Math.Abs(number % 10); //Найдено вторая цифра исходного числа, по модулю - убираем знак отрицательных чисел
System.Console.WriteLine($"Вторая цифра {number}");