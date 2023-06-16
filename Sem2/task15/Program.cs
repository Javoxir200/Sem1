Console.WriteLine("Напишите день недели узнайте сегодня выходной или нет?");
string? numA = Console.ReadLine();
int stringnumA = Convert.ToInt32(numA);

if (stringnumA == 6 || stringnumA == 7)
{
    Console.WriteLine("Поздравляю сегодня выходной");
}
else
{
    Console.WriteLine("Очень жал иди на работу(");
}