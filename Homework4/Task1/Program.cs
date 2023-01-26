// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double InputDoubleNumber(string numberName)         //Запрос числа типа double
{

    Console.Write($"Input {numberName} : ");
    double number;

    while (!double.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input {numberName} : ");

    }

    return number;
}

double MyMathPow(double number, double range)       //Функция возведения в степень
{
    double result = 1;    //число в степени 0 равно 1
    double iRange = Math.Abs(range);
    for (int i = 0; i < iRange; i++)
    {
        result = result * number;
    }

    return result;
}
double MyMathRootExtracting(double number, double range) //Функция извлечения корня любой степени (методом подбора)
{
    double iRange = Math.Abs(range);
    bool k = false;                                     //Флажок отрицательных чисел (number)
    if (number < 0) { k = true; number = number * -1; }   //Убираем знак

    double point1 = 0;              //Задаем начальный интервал возможных значений result между point1 и point2
    double point2 = number;
    double result = number / iRange; // Первое приблежение/гипотеза result
    double deviation = 1;
    while ((Math.Abs(deviation)) > 0.000001)                            // Задаем точность расчета
    {
        deviation = (MyMathPow(result, iRange) - number);                //Расчет отклонения
        if (deviation > 0) { point2 = result; }                          //Сжимаем интервал возможных значений
        if (deviation < 0) { point1 = result; }

        result = point1 + (point2 - point1) / 2;                       //Берем result в новом интервалe возможных значений



        //System.Console.WriteLine($"{result} ");  //Лог
    }

    if (k) result *= -1; //возваращаем знак отрицательным числам
    return result;
}



System.Console.Write("Возводим в степень (1), извлекаем корень (2)-->");
string? query = Console.ReadLine();
if (query == null || (!(query == "1") && !(query == "2"))) { System.Console.WriteLine("Что-то пошло не так"); return; }



bool kRange = false;                                        //флаг для отрицательных (range)
double result = 0;

if (query == "1")
{
    double number = InputDoubleNumber("что возводим в степень");
    double range = InputDoubleNumber("в какую степень");
    if (range < 0) kRange = true;

    result = MyMathPow(number, range);

    if (kRange) { result = 1 / result; }       //для отрицательных степеней (range)

    System.Console.WriteLine($"{number} в {range} степени  равно {result}");
    System.Console.WriteLine($"Проверка от Math.Pow {Math.Pow(number, range)}"); return;
}

if (query == "2")
{
    double number = InputDoubleNumber("из чего извлекаем корень");
    double range = InputDoubleNumber("корень какой степени");
    if (number < 0 && range % 2 == 0) { System.Console.WriteLine("Нет решения NaN"); return; }
    if (range < 0) kRange = true;

    result = MyMathRootExtracting(number, range);
    if (kRange) { result = 1 / result; }       //для отрицательных степеней (range)

    System.Console.WriteLine($"корень {range} степени от числа {number}  равно {result}");
    System.Console.WriteLine($"Проверка от Math.Pow {Math.Pow(number, 1 / range)}"); return;
}
