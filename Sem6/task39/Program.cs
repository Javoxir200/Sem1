/*Задача 39: Напишите программу, 
которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)*/
int[] GetRandomArray(int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

void ReverseArray(int[] sourceArray)
{
    for (int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i - 1];
        sourceArray[sourceArray.Length - i - 1] = temp;
    }
}

int[] myArray = GetRandomArray(5, -9, 10);
Console.WriteLine($"[{string.Join(", ", myArray)} ]");
ReverseArray(myArray);
Console.WriteLine($"[{string.Join(", ", myArray)} ]");