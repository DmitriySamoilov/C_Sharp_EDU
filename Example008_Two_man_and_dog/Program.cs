Console.Clear();

double distance = 10000;
int firstManSpeed = 1;
int secondManSpeed = 2;
int dogSpeed = 5;
bool direct = true; //направление движения собаки. true - от первого ко второму. false- от второго к первому

System.Console.WriteLine($"Расстояние между друзьями: {distance} метров");
System.Console.WriteLine($"Скорость первого друга: {firstManSpeed}");
System.Console.WriteLine($"Скорость второго друга: {secondManSpeed}");
System.Console.WriteLine($"Скорость собаки: {dogSpeed}");
System.Console.WriteLine("Движение навстречу");

double time = 0;
int count = 0;//Сколько раз пробежала собака
while (distance > 10)
{
    if (direct)
    {
        time = distance / (secondManSpeed + dogSpeed);
        direct = false;                                 //смена направления движения собаки
    }
    else
    {
        time = distance / (firstManSpeed + dogSpeed);
        direct = true;                                  //смена направления движения собаки
    }
    System.Console.WriteLine($"Время бега собаки: {Math.Round(time)} секунды");
    distance = distance - (firstManSpeed + secondManSpeed) * time;
    System.Console.WriteLine($"Остаток расстояния между друзьями: {Math.Round(distance)} метров");
    count++;
    System.Console.WriteLine($"Собака пробежала: {count} раз");
}
System.Console.WriteLine("Конец.");