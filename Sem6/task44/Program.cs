/*Решение в группах задач:
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonachi(int number)
{
    int[]array = new int [number];
    array[0]=0;
    array[1]=1;
    for (int i = 2; i < number; i++)
    {
        array[i] =  array[i-1] + array[i-2];
    }
    return array;
}

Console.WriteLine($"[{string.Join(", ", Fibonachi(number))} ]");

