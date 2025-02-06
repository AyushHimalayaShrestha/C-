/*WAP to input 3 sides of a triangle and check if triangle is valid or invalid, also check wheater
 the triangle is equilateral,scalene or isosceles*/

Console.WriteLine("Enter three sides of a triangle");
int a=  int.Parse(Console.ReadLine());
int b= int.Parse(Console.ReadLine());   
int c= int.Parse(Console.ReadLine());

if (a<(b+c) && b<(a+c) && c<(a+b))

{
    Console.WriteLine("Valid");
    if (a == b && b == c)
    {
        Console.WriteLine("Equilateral Triangle");
    }
    else if (a == b || b == c || c == a)
    {
        Console.WriteLine("Isosceles Triangle");
    }
    else
    {
        Console.WriteLine("Scalene Triangle");
    }
    
}
else
{
    Console.WriteLine("Invalid");
}
       
