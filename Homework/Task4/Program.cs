// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0)
{
    int i = 2;                          //Для положительных N
    while (i <= number)
    {
        System.Console.Write($" {i} ");
        i += 2;
    }
}
else
{
    int i = 0;                         //Для отрицательных N. Явно в задании не прописано, но на всякий случай. 0- четное число
    while (i >= number)
    {
        System.Console.Write($" {i} ");
        i -= 2;
    }
}