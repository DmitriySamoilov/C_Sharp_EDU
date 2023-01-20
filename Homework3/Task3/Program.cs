﻿// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
int GetCube(int input)
{
input=input*input*input;
return input;
}


int number=InputIntNumber("");
int k=1;
string result="";
if (number<0)  k=-1;                                // Для отрицательных чисел
for (int i = 1; (i*k) <= (number*k); i+=k)
{
    result = result+$"куб {i} равен {GetCube(i)}"+'\n';
}
System.Console.WriteLine(result);

OutPut(result,"Cube.txt");

void OutPut(string result, string filename)     //Вывод в файл
{
using(FileStream fstream =new FileStream(filename,FileMode.OpenOrCreate))
{
    byte [] array=System.Text.Encoding.Default.GetBytes(result);
    fstream.Write(array,0,array.Length);
}
}