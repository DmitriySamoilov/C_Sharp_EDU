System.Console.Clear();
int a= new Random().Next(1,50);
int b= new Random().Next(1,50);
int c= new Random().Next(1,50);
int d= new Random().Next(1,50);
int e= new Random().Next(1,50);
int max=a; 
if (b> max) max=b;
if (c> max) max=c;
if (d> max) max=d;
if (e> max) max=b;
System.Console.WriteLine($"Гиря a= {a}");
System.Console.WriteLine($"Гиря b= {b}");
System.Console.WriteLine($"Гиря c= {c}");
System.Console.WriteLine($"Гиря d= {d}");
System.Console.WriteLine($"Гиря e= {e}");
System.Console.WriteLine($"Наибольший вес {max}");