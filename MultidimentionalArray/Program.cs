int[,] a = new int[4, 4];
int i, j;
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        Console.Write("a[{0},{1}] = ", i, j);
        a[i, j] = int.Parse(Console.ReadLine());
    }
}
for(i = 0;i < 4; i++)
{
    for(j = 0;j < 4; j++)
    {
        Console.Write(a[i, j]+"\t");
    }
    Console.WriteLine();
}
