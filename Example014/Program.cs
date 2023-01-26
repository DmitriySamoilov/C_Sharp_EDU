// Решение в группах задач:
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*Random rnd=new Random();

int [] array= new int [8];

for (int i = 0; i < 8; i++)
{
    array[i]=rnd.Next(0,2);
}

System.Console.Write("[");
for (int i = 0; i < 8; i++)
{
   if (i<7) System.Console.Write($"{array[i]},");
   else System.Console.Write($"{array[i]}");
}

System.Console.Write("]");*/

// Z1.11. Найти:
// а) все трехзначные числа, чьи квадраты оканчиваются тремя цифрами, которые и составляют искомые числа;
// б) все трехзначные числа, кратные семи и у которых сумма цифр также кратна семи.

int q;
for (int i = 100; i < 1000; i++)
{
    q = i * i;

    int a1 = i % 10;
    int b1 = (i / 10) % 10;
    
        int a = q % 10;
        int b = (q / 10) % 10;
        int c = (q / 100) % 10;
    if ((b1*10+a1)==(b*10+a)) System.Console.WriteLine($" {i} {q} ");

    
}


