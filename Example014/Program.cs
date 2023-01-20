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

int a=InputIntNumber("Любое");
int[] array=new int [Math.Abs(a)];
for (int i = 1; i <= Math.Abs(a); i++)
{
   System.Console.WriteLine(i*i); 
   array[i-1]=i*i;
}

for (int i = 0; i < Math.Abs(a); i++)
{
   System.Console.Write($" {array[i]} "); 
   
}

