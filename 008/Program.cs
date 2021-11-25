// Показать числа от -N до N

Console.Write("Введите значение 'N': ");
int a = int.Parse(Console.ReadLine());
int count = - a;

while(count <= a)
{
    Console.WriteLine(count);
    count++;
}
