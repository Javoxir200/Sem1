int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);

int firstDigit = number / 100;
int lastDigit = number % 10;

int result = firstDigit * 10 + lastDigit; 

Console.WriteLine(result);

