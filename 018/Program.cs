// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a == b * b)
{
    Console.WriteLine(a + " является квадратом " + b);
}
if(b == a * a)
{
    Console.WriteLine(b + " является квадратом " + a);
}
