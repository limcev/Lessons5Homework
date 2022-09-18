






int[] arry = new int[6];

for (int i = 0; i < arry.Length; i++)
{
    Random random = new Random();

    arry[i] = random.Next(0, 20);

}


Console.Write(string.Join(" ", arry));

Console.WriteLine();
for (int i = 0; i < arry.Length; i++)
{
    for (int j = 0; j < arry.Length - 1; j++)
    {
        
        
        
        
        int temp = 0;
        if (arry[j] > arry[j + 1])
        {
            temp = arry[j];
            arry[j] = arry[j + 1];
            arry[j + 1] = temp;
        }

    }

}
Console.Write(string.Join(" ", arry));