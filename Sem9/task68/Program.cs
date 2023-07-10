int numberM = InputNumbers("Введите M: ");
int numberN = InputNumbers("Введите N: ");

int functionAkkerman = Ack(numberM, numberN);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0) return Ack(numberM - 1, 1);
    else return Ack(numberM - 1, Ack(numberM, numberN - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}