// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

int number = InputIntNumber("");

int sum=0;
while(Math.Abs(number) >1)
{
    sum= sum + number%10;
    number=number/10;
}
System.Console.WriteLine($"Сумма цифр: {Math.Abs(sum)}");