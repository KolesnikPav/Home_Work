// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("Некратно");
}

else if (a % b == 0)
{
    Console.WriteLine(a + " кратно " + b);
}
else
{
    Console.WriteLine("Остаток: " + a % b);
}
