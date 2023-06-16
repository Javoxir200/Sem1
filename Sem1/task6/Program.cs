Console.WriteLine("Введите число N");
string? number = Console.ReadLine();
int stringNum = Convert.ToInt32(number);

if (stringNum%2 == 0)
{
    Console.WriteLine("Да число без остатка ");
    Console.WriteLine(stringNum);
}
else 
{
    Console.WriteLine("Нет это с остатком(");
}