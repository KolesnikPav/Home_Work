// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите чему равен 'X': ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите чему равен 'Y': ");
int y = int.Parse(Console.ReadLine());

int q = x;
int w = - x;
int a = y;
int s = -y;

if(q == 0 ||  a == 0)
{
    Console.WriteLine("0 нельзя :P");
}
else if(q >= w && a >= s)
{
    Console.WriteLine("I четверть!");
}
else if(q >= w && a <= s)
{
    Console.WriteLine("II четверть!");
}
else if(q <= w && a <= s)
{
    Console.WriteLine("III четверть!");
}
else if(q <= w && a >= s)
{
    Console.WriteLine("IV четверть!");
}
