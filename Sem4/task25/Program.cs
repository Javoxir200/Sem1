Console.WriteLine("Введите числа");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}

Console.WriteLine(result);
