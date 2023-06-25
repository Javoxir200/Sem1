Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

while (number > 0)
{
    int sum = number % 10;
    result += sum;
    number = number / 10;
}
Console.WriteLine(result);





