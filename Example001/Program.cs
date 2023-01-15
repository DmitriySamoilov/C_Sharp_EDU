Console.Clear();
Console.WriteLine("Hello, Huge World!");

int a=getIntTryParse(false);
System.Console.WriteLine(a);

int getIntTryParse(bool check){
check=false;
int number=0;
while (check==false){
    System.Console.Write("Введите первое число: ");
    check = int.TryParse(Console.ReadLine(), out number);
    
}
return number;
}