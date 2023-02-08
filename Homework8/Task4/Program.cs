// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random rnd = new Random();
int k = 1, l = 1, m = 1;
while (50 > (k * l * m) || (k * l * m) > 90)                //Проверка 50> маленький, 90+ - не хватит неповторяющихся двузначных чисел.
{
    k = rnd.Next(1, 8); l = rnd.Next(1, 8); m = rnd.Next(1, 8);
}

int[,,] array3D = new int[k, l, m];
System.Console.WriteLine($"Cube {k}*{l}*{m}");

int nextNumber=0;

for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        for (int g = 0; g < m; g++)
        {
            while (CheckRepeat(nextNumber, array3D))
            {
                nextNumber = rnd.Next(10, 100);
                
            }
            array3D[i, j, g]=nextNumber;

            System.Console.Write($"({i},{j},{g}) {array3D[i, j, g]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

bool CheckRepeat(int number, int[,,] array)
{
    foreach (int item in array)
    {
        if (item == number) return true;
    }
    return false;
}