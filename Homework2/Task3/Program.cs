// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int InputIntNumber(string numberName)
{

Console.Write($"Input integer number {numberName}: ");
int number;

while (!int.TryParse(Console.ReadLine(), out number))
{

    Console.WriteLine("You inputed something wrong! Try again.");
    Console.Write($"Input integer number {numberName}: ");

}

return number;
}

int weekDayNumber =InputIntNumber("1-7");                                        //Запрос числа
if(0<weekDayNumber&&weekDayNumber<6) System.Console.WriteLine("Нет");
else if (5<weekDayNumber&&weekDayNumber<8)  System.Console.WriteLine("Да");
else System.Console.WriteLine("Число должно быть 1-7!");