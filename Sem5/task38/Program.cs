/*Задача 38: Задайте массив натуральных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. (не использовать стандартные функции/методы)*/
int[] GetRandomArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 100);
    }
    return array;
}

int[] myArray = GetRandomArray();
Console.WriteLine($"{string.Join(", ", myArray)} ");
int max = myArray[0];
int min = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (max < myArray[i])
    {
        max = myArray[i];
    }
    else if(min>myArray[i])
    {
        min = myArray[i];
    }
}
int result = 0;
result=max-min;
Console.WriteLine(result);

