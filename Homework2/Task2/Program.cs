// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

int InputIntNumber(string numberName)
{

    Console.Write($"Input {numberName} integer number: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input {numberName} integer number: ");

    }

    return number;
}

int number = InputIntNumber("");//Получено целое число
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