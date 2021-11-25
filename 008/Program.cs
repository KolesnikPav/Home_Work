// Показать числа от -N до N

Console.Write("Введите значение 'N': ");
int a = int.Parse(Console.ReadLine());
int count = 1;
Console.WriteLine(0);
while(count <= a)
{
    Console.WriteLine(count - 2 * count);
    Console.WriteLine(count);
    count++;
}
