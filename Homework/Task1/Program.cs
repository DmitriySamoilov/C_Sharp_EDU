//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber>secondNumber) {
    System.Console.WriteLine($"max={firstNumber} min= {secondNumber}");
}
else {
   System.Console.WriteLine($"max={secondNumber} min= {firstNumber}"); 
}