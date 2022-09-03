// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] Arry = Elements(5, 100, 999);
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
    if (Arry[j] % 2 == 0 )
    {
        summa = summa + 1;
    }
    
    j++;
    }
Console.Write("Количество четных чисел: ");
Console.Write(summa);
