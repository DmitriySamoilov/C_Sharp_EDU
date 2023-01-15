// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
if (Convert.ToInt32(Console.ReadLine()) % 2 == 0)
{
    System.Console.WriteLine("Четное");
}
else
{
    System.Console.WriteLine("Нечетное");
}