
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



Console.Write("Введите количесвто столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Matrix = OurMatrix(m, n);
PrintMatrix(Matrix);
Console.WriteLine();
double[,] OurMatrix(int st, int ts)
{
    double[,] matrix = new double[st, ts];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(1,( 10)))/2.0;
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
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