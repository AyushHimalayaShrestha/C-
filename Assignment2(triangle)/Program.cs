/*
int a, b, c;
Console.WriteLine("Enter three sides of a triangle:");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if(a<(b+c) && b<(c+a) && c<(b+a))
{
    Console.WriteLine("Valid");

if(a==b && b==c)
    {
        Console.WriteLine("Equilateral Triangle");
    }
else if(a==b || a==c || b==c)
    {
        Console.WriteLine("Isosceles Triangle");
    }
else
    {
        Console.WriteLine("Scalen Triangle");
    }

    
}
else
{
    Console.WriteLine("Invalid");

}
*/

int i, j;
for(i=1;i<=5;i++)
{
    for(j=1;j<=i;j++)
    { Console.Write("\t");
    }
    for(j=i;j<=5;j++)
    { Console.Write(i+"\t");
    }
    Console.WriteLine();
}

Console.ReadKey();
