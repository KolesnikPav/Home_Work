// Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
string a = Console.ReadLine();

if(int.Parse(a) / 10 <= 9 || int.Parse(a) / 10 >= 100)
{
    Console.WriteLine("Я сказал трёхзначное!!!");
}
else
{
    Console.WriteLine(a[1]);
}

