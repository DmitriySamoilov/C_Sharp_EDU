int[,] array =new int[4,3];


Random random= new Random();

FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array[i,j]=random.Next(99,1000);
    }
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < 4; i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < 3; j++)
    {
       System.Console.Write($" {array[i,j]} ");
    }
}
}

