Console.WriteLine("Введите число N");
string? numberN = Console.ReadLine();
int stringNumN = Convert.ToInt32(numberN);

for (int i = 0; i<=stringNumN; i++)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
}
