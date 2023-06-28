/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int[] GetRandomArray()
{
    int[] array = new int[6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-99, 100);
    }
    return array;
}
int summa = 0;
int i = 1;
int[] myArray = GetRandomArray();
Console.WriteLine($"{string.Join(", ", myArray)} ");

while (i < myArray.Length)
{
    summa = summa + myArray[i];
    i = i + 2;
}

Console.WriteLine(summa);