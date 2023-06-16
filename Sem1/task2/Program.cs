Console.WriteLine("Введите первое числа");
string? numA = Console.ReadLine();
int stringnumA = Convert.ToInt32(numA);

Console.WriteLine("Введите второе числа");
string? numB = Console.ReadLine();
int stringnumB = Convert.ToInt32(numB);

int max, min;

max=stringnumA;

if (stringnumB>stringnumA)
{
    max=stringnumB;
    min=stringnumA;
}
else
{
    max =stringnumA;
    min =stringnumB;
}

Console.Write("Мах: ");
Console.WriteLine(max);
Console.Write("Мин: ");
Console.WriteLine(min);
