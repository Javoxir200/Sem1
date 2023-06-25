int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;

}

int func(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum *= i;
    }
    return sum;
}

int numberS = ReadInt();
int summa = func(numberS);
Console.WriteLine(summa);

