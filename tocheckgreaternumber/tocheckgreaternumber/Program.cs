//WAP to input 3 numbers and check which is greater.
int a, b, c;
Console.WriteLine("Enter a : ");
a=int.Parse(Console.ReadLine());
Console.WriteLine("Enter b : ");
b=int.Parse(Console.ReadLine());
Console.WriteLine("Enter c : ");
c=int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("a is greater.");
    }

}
else if (b > c)
{
    if (b > a)
    {
        Console.WriteLine("b is greater.");
    }
}
else if(c > a)
{
    if(c > b)
    {
        Console.WriteLine("c is greater.");
    }
}
else
{
    Console.WriteLine("All are equal");
}
