// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты точки 'A'");
Console.Write("X: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки 'B'");
Console.Write("X: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)));

/*
Можно еще так
Console.WriteLine(Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za)));
Но double меняем на int

Ну или так: добавляем новые переменные 
int kx = (xb - xa) * (xb - xa);
int ky = (yb - ya) * (yb - ya);
int kz = (zb - za) * (zb - za);
Console.WriteLine(Math.Sqrt(kx + ky + kz));
*/