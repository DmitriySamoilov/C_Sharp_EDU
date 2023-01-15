Console.Clear();
System.Console.Write("Введите Ваше имя: ");
string ? username= Console.ReadLine();

switch(username?.ToLower() ){
    
case "маша":
    System.Console.WriteLine($"Привет, дорогая Маша !");
break;
case "даша":
    System.Console.WriteLine($"Привет велиокая Даша !");
break;
case "саша":
    System.Console.WriteLine($"Привет полногрудая Саша !");
break;
case "глаша":
    System.Console.WriteLine($"Привет челом красная Глаша !");
break;
case "ольга":
    System.Console.WriteLine($"Привет величавая Ольга !");
break;

default:
    System.Console.WriteLine($"Привет незнакомая {username} !");
break;

}
