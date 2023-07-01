/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите число с пробелом");
int[] number = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int count=0;
for (int i = 0; i < number.Length; i++)
{
    
    if (number[i]>0)
    {
        count++;
    }
}

Console.WriteLine($"{string.Join(", ", count)} ");

