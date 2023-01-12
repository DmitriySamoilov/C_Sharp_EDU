Console.Clear();
int xa=40, ya=1,
    xb=1, yb=30,
    xc=80,yc=30;
System.Console.SetCursorPosition(xa,ya);
System.Console.WriteLine("+");
System.Console.SetCursorPosition(xb,yb);
System.Console.WriteLine("+");
System.Console.SetCursorPosition(xc,yc);
System.Console.WriteLine("+");

int x=xa, y=ya;

int count=0;

while (count<10000)
{   int what=new Random().Next(0,3);
    
    if (what ==0)
    {   x=(x+xa)/2;
        y=(y+ya)/2;}

    if (what ==1)
{   x=(x+xb)/2;
    y=(y+yb)/2;}

    if (what ==2)
{   x=(x+xc)/2;
    y=(y+yc)/2;}

System.Console.SetCursorPosition(x,y);
System.Console.WriteLine("+");
count ++;
}
System.Console.SetCursorPosition(80,0);