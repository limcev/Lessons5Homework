// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет



Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесвто столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  координату элемента q по строке: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  координату элемента y по столбцу: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] ourMatrix = Getmatrix(m, n, 0, 10);
PrintMatrix(ourMatrix);
Get(ourMatrix, q, y);
int[,] Getmatrix(int roumCount, int columsCount, int right, int left)
{
    int[,] matrix = new int[roumCount, columsCount];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(right, left);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Get(int[,] Maf, int q, int y)
{
    if (q >= Maf.GetLength(0) || y >= Maf.GetLength(1))
    {
        Console.Write("Такого элемента не существует");
    }
    for (int i = 0; i < Maf.GetLength(0); i++)
    {

        for (int j = 0; j < Maf.GetLength(1); j++)
        {
            if (i == q && j == y)
            {
                Console.Write($"Значение элемента на координатах:  {Maf[q, y]}");
            }
        }
    }
}





