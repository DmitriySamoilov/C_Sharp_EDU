//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*System.Console.Write("Введите первое число: ");
double max = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите второе число: ");
double number = Convert.ToDouble(Console.ReadLine());
if (number>max) max=number;
System.Console.Write("Введите третье число: ");
number = Convert.ToDouble(Console.ReadLine());
if (number>max) max=number;
System.Console.WriteLine($"max= {max}");*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double max = CheckMax(double.MinValue);  //Первое число. double.MinValue- "нулевой" локальный максимум. Если поставить 0, не будет работать на отрицательных числах
max = CheckMax(max);                      //Второе число
max = CheckMax(max);                      //Третье число
System.Console.WriteLine($"max= {max}");


double CheckMax(double localMax)        //Метод запрашивает число, сравнивает с локальным максимумом и возвращает большее
{
    System.Console.Write("Введите число: ");
    double number = Convert.ToDouble(Console.ReadLine());
    if (localMax > number) return localMax;
    else return number;
}