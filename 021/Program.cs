// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine());

if(x <= 0 ||  x >= 5)
{
    Console.WriteLine("Такой четверти не существует!");
}
else if(x == 1)
{
    Console.WriteLine("[0 : +X]");
    Console.WriteLine("[0 : +Y]");
}
else if(x == 2)
{
    Console.WriteLine("[0 : +X]");
    Console.WriteLine("[-Y : 0]");
}
else if(x == 3)
{
    Console.WriteLine("[-X : 0]");
    Console.WriteLine("[-Y : 0]");
}
else if(x == 4)
{
    Console.WriteLine("[-X : 0]");
    Console.WriteLine("[0 : +Y]");
}
