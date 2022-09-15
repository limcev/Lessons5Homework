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


int[,] ourMatrix = Getmatrix(m, n, 0, 5);
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
Console.WriteLine($"----------------");
Console.WriteLine($"Cреднее арифметическое элементов в каждом столбце");

SummMatrix(ourMatrix);
void SummMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ = summ + matrix[j, i];

        }
        
        Console.Write($"{summ/matrix.GetLength(0)} ");
    }

}
