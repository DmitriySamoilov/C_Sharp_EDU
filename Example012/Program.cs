double newNumber()
{
    System.Console.Write("-->");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}


/*double first=newNumber();
double second=newNumber();
if (first%second==0){
    System.Console.WriteLine(first+" Кратно "+second);
}
else System.Console.WriteLine("Некратно остаток "+(first%second));*/


double num = newNumber();
if ((num % 7 == 0) && (num % 23 == 0))
{
    System.Console.WriteLine(num + " Кратно 7 и 23 ");

}
else
{
    System.Console.WriteLine(num + " Некратно");
}