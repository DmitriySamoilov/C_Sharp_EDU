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
int absNumber=Math.Abs(number);
while(absNumber >1)
{
    sum= sum + absNumber%10;
    absNumber=absNumber/10;
}
System.Console.WriteLine($"Сумма цифр: {Math.Abs(sum)}");