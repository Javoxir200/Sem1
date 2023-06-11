Console.WriteLine("Введите число: A");
string? numA = Console.ReadLine();
int stringnumA = Convert.ToInt32(numA);
//Console.WriteLine(numberInt * numberInt);

Console.WriteLine("Введите число: B");
string? numB = Console.ReadLine();
int stringnumB = Convert.ToInt32(numB);

Console.WriteLine("Введите число: C");
string? numC = Console.ReadLine();
int stringnumC = Convert.ToInt32(numC);
int max;

max = stringnumA;
if (stringnumB > stringnumA)
    max = stringnumB;
if (stringnumC > max)
    max = stringnumC;

Console.Write("Максималное число: ");
Console.WriteLine(max);



