Console.WriteLine("Введите координату по оси X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
{
    Console.WriteLine("No");
}