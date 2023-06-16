Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA % 7;
int numberC = numberA % 23;
if(numberB == 0 && numberC == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
