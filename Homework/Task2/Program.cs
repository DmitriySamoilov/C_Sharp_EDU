//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое число: ");
double max = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите второе число: ");
double number = Convert.ToDouble(Console.ReadLine());
if (number>max) max=number;
System.Console.Write("Введите третье число: ");
number = Convert.ToDouble(Console.ReadLine());
if (number>max) max=number;
System.Console.WriteLine($"max= {max}");
