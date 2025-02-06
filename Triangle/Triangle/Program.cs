Console.WriteLine("Enter angle a : ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Enter angle b : ");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Enter angle c : ");
int c=int.Parse(Console.ReadLine());

int sum = a + b + c;

if(sum == 180)
{
    Console.WriteLine("The sum of an angle is a triangle.");
}
else
{
    Console.WriteLine("It is not a triangle");
}
