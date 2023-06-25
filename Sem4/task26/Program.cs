// Задача 26: Напишите программу, 
// которая принимает на вход число и выдаёт количество цифр в числе.


int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
    
}

int func(int number)
{
    int sum = 0;
    while (number > 0)
    {
        number = number / 10;
        sum++;
    }
    return sum;
}

int numberS = ReadInt();
int summa = func(numberS);
Console.WriteLine(summa);


