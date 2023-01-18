// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

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




int number = InputIntNumber("a three-digit");
if ((number > 99 && number < 1000) || (number < -99 && number > -1000))// Берем только трехзначные положительные или отрицательные числа
{
    number = number / 10; //Число преобразовано в двухзначное
    number = Math.Abs(number % 10); //Найдено вторая цифра исходного числа, по модулю - убираем знак отрицательных чисел
    System.Console.WriteLine($"Second digit {number}");
}
else System.Console.WriteLine("Mistake. You should enter a three-digit number!");