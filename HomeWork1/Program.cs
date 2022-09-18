





Console.Write("Введите количество элементов в массиве: ");
int elementCount = Convert.ToInt32(Console.ReadLine());


string[] arry = new string[elementCount];
completionMassive(arry, elementCount);
void completionMassive(string[] Arry, int ElementCount)
{
    for (int i = 0; i < ElementCount; i++)
    {
        Console.Write("Введите элемент массива: ");
        Arry[i] = Convert.ToString(Console.ReadLine());
    }
    Console.Write($"Массив с количеством элементов {elementCount}: ");
    Console.WriteLine(string.Join(", ", Arry));
}

Console.WriteLine("----------------------------------");

string[] newMassive = newElementsMassive(arry);
string[] newElementsMassive(string[] Arr)
{
    Random random = new Random();
    string[] newMas = new string[random.Next(0, 4)];
    for (int i = 0; i < newMas.Length; i++)
    {
        newMas[i] = Arr[random.Next(0, Arr.Length)];
    }
    return newMas;
}
Console.WriteLine("Новый массив: ");
Console.WriteLine(string.Join(", ", newMassive));


