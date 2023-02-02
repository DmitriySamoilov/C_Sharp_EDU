// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Применил более общий вид формулы для прямых на плоскости ax+by=c. Позволяет дополнительно учитывать прямые параллельные оси Y (Плачь, Камянецкий!!!)
//Для исходного примера из условий задачи данные будут соответствовать: a1=-5, b1=1, c1=2 и a2=-9, b2=1, c2=4 -> (-0,5; -0,5)
//Для прямых параллельных оси X: a=0, b=1 или любое число  кроме 0(?), c=любое число.
//Для прямых параллельных оси Y: a=1 или любое число кроме 0(?), b=0, c=любое число.

void FindIntersectionPointCoordinates(double a1, double a2, double b1, double b2, double c1, double c2, out double xCrossPoint, out double yCrossPoint) 
{
    xCrossPoint = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
    yCrossPoint = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);
}

double InputDoubleNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
    double doubleNumber = Convert.ToDouble(Console.ReadLine());
    return doubleNumber;
}
System.Console.WriteLine("Use a straight line type ax+by=c!");
double a1 = InputDoubleNumber("a1");
double b1 = InputDoubleNumber("b1");
double c1 = InputDoubleNumber("c1");
if (a1==0 && b1==0) { System.Console.WriteLine($"The straight line type {a1}x + {b1}y={c1} does not exist."); return;}
double a2 = InputDoubleNumber("a2");
double b2 = InputDoubleNumber("b2");
double c2 = InputDoubleNumber("c2");
if (a2==0 && b2==0) { System.Console.WriteLine($"The straight line type {a2}x + {b2}y={c2} does not exist."); return;}

System.Console.WriteLine($"The first  straight line: {a1}x + {b1}y={c1};");
System.Console.WriteLine($"The second straight line: {a2}x + {b2}y={c2};");

if ((a1 * b2 - a2 * b1) == 0)
{
    System.Console.WriteLine("The Parallel lines. The intersection point does not exist.");
    return;
}
double xIntersectionPointCoordinate = 0;
double yIntersectionPointCoordinate = 0;
FindIntersectionPointCoordinates(a1: a1, a2: a2, b1: b1, b2: b2, c1: c1, c2: c2, out xIntersectionPointCoordinate, out yIntersectionPointCoordinate);

System.Console.WriteLine($"Coordinates of the intersection point ({xIntersectionPointCoordinate:f2};{yIntersectionPointCoordinate:f2})");
