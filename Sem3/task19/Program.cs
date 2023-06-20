Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int numberA = numberN;
int palindrome = 0;
int result = 0;
while (Convert.ToBoolean(numberN))
{
    int sum = numberN % 10;
    palindrome = palindrome * 10 + sum;

    numberN = numberN / 10;
    result = numberA / palindrome;

}

if (result > 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



