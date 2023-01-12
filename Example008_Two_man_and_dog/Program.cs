Console.Clear();

double distance= 10000;
int firstManSpeed= 1;
int secondManSpeed=2;
int dogSpeed= 5;
bool direct = true;
System.Console.WriteLine($"Расстояние между друзьми: {distance}");
System.Console.WriteLine($"Скорость первого друга: {firstManSpeed}");
System.Console.WriteLine($"Скорость второго друга: {secondManSpeed}");
System.Console.WriteLine($"Скорость собаки: {dogSpeed}");
System.Console.WriteLine("Движение навстречу");
double time=0;
int count=0;//Сколько раз пробежала собака
while (distance>10) {
    if (direct) 
    {   time=distance/(secondManSpeed+dogSpeed);
        System.Console.WriteLine($"Time: {time}");
        direct=false;
    } 
    else {
        time = distance/(firstManSpeed+dogSpeed);
        System.Console.WriteLine($"Time: {time}");
        direct=true;
        }
distance=distance-(firstManSpeed+secondManSpeed)*time;
System.Console.WriteLine($"Distance: {distance}");
count++;
System.Console.WriteLine($"Собака пробежала: {count} раз");
}