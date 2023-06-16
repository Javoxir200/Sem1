Console.WriteLine("Введите первое числа");
string? numA = Console.ReadLine();
int stringnumA = Convert.ToInt32(numA);

Console.WriteLine("Введите второе числа");
string? numB = Console.ReadLine();
int stringnumB = Convert.ToInt32(numB);

if (stringnumA * stringnumA == stringnumB || stringnumB * stringnumB == stringnumA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}