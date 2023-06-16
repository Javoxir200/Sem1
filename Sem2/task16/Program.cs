Console.WriteLine("Введите число N");
string? numberA = Console.ReadLine();
int stringNumA = Convert.ToInt32(numberA);

Console.WriteLine("Введите число N");
string? numberB = Console.ReadLine();
int stringNumB = Convert.ToInt32(numberB);

int result = stringNumA % stringNumB;

if (result%2==0)
{
    Console.WriteLine("Да число без остатка ");
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Нет это с остатком(");
    Console.WriteLine(result);
}
