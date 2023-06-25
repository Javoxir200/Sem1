// Задача 24: Напишите программу, которая принимает на вход
//  число (А) и выдаёт сумму чисел от 1 до А.

int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
    
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum +=i;
    }

    return sum;

}

int number = ReadInt();
int summa = SumFrom1ToA(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {summa}");