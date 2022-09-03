// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5





int[] Arry = Elements(123, 1, 999);
Console.WriteLine(string.Join("/ ", Arry));

int[] Elements(int size, int leftRange, int raitRange)

{
    int[] arry = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arry[i] = random.Next(leftRange, raitRange + 1);
    }
    return arry;
}


int j = 0;
int summa = 0;
while (j < Arry.Length)
{
    if ( Arry[j] >= 10 && Arry[j] <= 99)
    {
        summa = summa + 1;
    }
    if (10 < Arry[j] && Arry[j] > 99)
    {
       summa = summa + 0;
    }
    j++;
}
Console.Write("Количество двухзначных элементов массива: ");
Console.Write(summa);