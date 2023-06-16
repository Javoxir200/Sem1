Console.WriteLine("Введите первое числа");
string? numA = Console.ReadLine();
int stringnumA = Convert.ToInt32(numA);

int result = (stringnumA / 10) % 10;

Console.WriteLine(result);