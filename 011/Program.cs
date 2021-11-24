// Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
string a = Console.ReadLine();

if(int.Parse(a) / 10 >= 10)
{
    if(int.Parse(a) / 10 <= 99)
    {
        Console.WriteLine(a[1]);
        }
}
