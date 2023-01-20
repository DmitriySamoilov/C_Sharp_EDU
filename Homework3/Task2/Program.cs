// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double InputXYZ(string name )
{
System.Console.Write($"Введите координату {name}: ");
double x= Convert.ToDouble(Console.ReadLine());
return x;
}

double xF=InputXYZ("x первой точки");
double yF=InputXYZ("y первой точки");
double zF=InputXYZ("z первой точки");

double xS=InputXYZ("x второй точки");
double yS=InputXYZ("y второй точки");
double zS=InputXYZ("z второй точки");

double distance = Math.Round((Math.Sqrt(Math.Pow((xS-xF),2)+Math.Pow((yS-yF),2)+Math.Pow((zS-zF),2))),2);

System.Console.WriteLine(distance);