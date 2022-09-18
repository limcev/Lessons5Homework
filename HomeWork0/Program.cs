// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесвто столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = Getmatrix(m, n, 0, 10);
PrintMatrix(ourMatrix);
Gtmatrix(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix);
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


void Gtmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {


            for (int t = 0; t < matrix.GetLength(1) - 1; t++)
            {
                int temp = 0;
                if (matrix[i, t] > matrix[i, t + 1])
                {
                    temp = matrix[i, t];
                    matrix[i, t] = matrix[i, t + 1];
                    matrix[i, t + 1] = temp;
                    t++;
                }
            }
        }
    }
}