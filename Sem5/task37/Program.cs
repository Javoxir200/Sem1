/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] numbers1 = { 1, 2, 6, 5, 7, 9};
int[] numbers2 = new int[(numbers1.Length + 1) / 2];

for (int i = 0; i < numbers2.Length; i++)
{
    numbers2[i] = numbers1[i] * numbers1[numbers1.Length - 1 - i];
}
if (numbers1.Length % 2 !=0)
{
    numbers2[numbers2.Length - 1] = numbers1[numbers1.Length / 2];
}

Console.WriteLine($"[{string.Join(", ", numbers2)} ]");