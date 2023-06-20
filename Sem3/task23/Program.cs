Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberN; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}