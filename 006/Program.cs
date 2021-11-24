// Написать программу вычисления значения функции y = f(a)

Console.Write("Введите чему будет равно 'a': ");
int a = int.Parse(Console.ReadLine());

if(a >= 0)
{
    Console.WriteLine("y = " + (a - 1));
}
else
{
    Console.WriteLine("y = " + Math.Abs(a));
}
