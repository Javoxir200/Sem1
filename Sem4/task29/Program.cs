Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(number);
    Console.WriteLine(array[i]);
}



