int min = InputNumbers("Введите M: ");
int max = InputNumbers("Введите N: ");
int temp = min;

if (min > max)
{
    min = max;
    max = temp;
}

PrintSumm(min, max, temp = 0);

void PrintSumm(int minNumber, int maxNumber, int summ)
{
    summ = summ + maxNumber;
    if (maxNumber <= minNumber)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(minNumber, maxNumber - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
