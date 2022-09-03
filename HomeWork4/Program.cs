// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76





double[] arry = {3, 7, 22, 2, 78};
int i = 0;
double max = 0;
double min = arry[0];
double ter = 0;
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
