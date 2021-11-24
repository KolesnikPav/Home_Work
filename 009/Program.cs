// Показать четные числа от 1 до N

Console.Write("Введите значение 'N': ");
int a = int.Parse(Console.ReadLine());

int count = 0;

while(count <= (a - 2))
{
    count = count + 2;
    Console.WriteLine(count);
}
