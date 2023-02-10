// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 4, n = 8;
System.Console.WriteLine(SumRec(m, n));

int SumRec(int a, int b)
{
    if (b == a) return a;
    else return b + SumRec(a, --b);
}
