Console.WriteLine("Please enter the height of a triangle :");
int height=Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    //for adding trailing space
    for (int j = 0; j < height - i; j++)
    {
        Console.Write(" ");
    }
    //for printing triangle
    for (int k = 0; k < i; k++)
    {
        Console.Write(" * ");
    }
    Console.WriteLine();
    Thread.Sleep(50);

}
