/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.*/

int[] GetRandomArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] myArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", myArray)} ]");

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (number == myArray[i])
    {
        count++;
        break;
    }
}

if (count == 1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
