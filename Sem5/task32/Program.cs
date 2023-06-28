/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.*/
int[] GetRandomArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] GetRandomMassive(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = -massive[i];
    }
    return massive;
}

int[] myArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", myArray)} ]");

Console.WriteLine($"[{string.Join(", ", massive)} ]");

