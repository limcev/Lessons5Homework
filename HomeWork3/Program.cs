// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int[] Arry = Elements(8, 0, 10);
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


int j = 1;
int summa = 0;
while (j < Arry.Length)
{
    summa = summa + Arry[j++];

    j++;
}
Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.Write(summa);