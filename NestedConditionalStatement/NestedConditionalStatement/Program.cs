/*
 if(conditon1)
    {
        if(condition2)
        {
            statements if condition1 and condtion2 are true
        }
        else
        {
            statements if condtion1 is true and condition is false
        }
    
    }

    else
    {
        if(condition3)
        {
            statements if condition1 is false and condition3 is true.
        }
        else
        {
            statements if condition1 and condition3 are false
        }
    }
*/



//WAP to input 3 numbers and find the maximum in them.
int a, b, c;
Console.WriteLine("Enter First Number :");
a= int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
b= int.Parse(Console.ReadLine());
Console.WriteLine("Enter Third Number : ");
c= int.Parse(Console.ReadLine());

if(a>b && a>c)
{
    Console.WriteLine("a is greater");
}
else if(b>c && b>a)
{
    Console.WriteLine("b is greater");
}
else if (c>a && c>b)
{
    Console.WriteLine("c is greater");
}
else
{
    Console.WriteLine("Error");
}