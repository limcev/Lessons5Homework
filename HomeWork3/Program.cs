// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесвто столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Arry = Marry(m, n, 0, 10);

PrintMatrix(Arry);
double[,] Marry(int a, int b, int left, int right)
{
    double[,] matrix = new double[a, b];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(left, right);

        }
    }
    return matrix;
}

void PrintMatrix(double[,] Hematrix)
{
    for (int i = 0; i < Hematrix.GetLength(0); i++)
    {
        for (int j = 0; j < Hematrix.GetLength(1); j++)
        {
            Console.Write(Hematrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: ");
SummMatrix(Arry);
void SummMatrix(double[,] Hematrix)
{

    for (int i = 0; i < Hematrix.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < Hematrix.GetLength(0); j++)
        {
            summ = summ + Hematrix[j, i];

        }
        
        Console.Write($"{summ / Hematrix.GetLength(0)} ");
    }
}