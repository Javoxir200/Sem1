Console.WriteLine("Введите x первой точка");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точка");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точка");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точка");
int y2 = Convert.ToInt32(Console.ReadLine());

double skobX = Math.Pow(x - x2, 2);
double skobY = Math.Pow(y - y2, 2);
double result = Math.Sqrt(skobX + skobY);

Console.WriteLine(result);
