int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);

int lastDigit = number / 100;
int firstDigit = number %10;

Console.Write(lastDigit);
Console.Write(firstDigit);