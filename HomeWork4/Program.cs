// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76





int[] arry = {3, 7, 22, 2, 78};
int i = 0;
int max = 0;
int min = arry[0];
int ter = 0;
while (i < arry.Length)
{
    if (arry[i] >= max)
    {
        max = arry[i];
    }
    if (arry[i] < min)
    {
     min = arry[i];
    }
i++;
 ter = max - min;
}
Console.Write($"Разница между максимальным и минимальным элементов массива равна {ter} ");
