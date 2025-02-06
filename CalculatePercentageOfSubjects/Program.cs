Console.WriteLine("Enter Physics marks : ");
int Physics=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Chemistry marks : ");
int Chemistry=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Biology marks : ");
int Biology=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Maths marks : ");
int Maths=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Computer marks : ");
int Computer=int.Parse(Console.ReadLine());

int TotalMarks=Physics+Chemistry+Biology+Maths+Computer;
double Percentage = (TotalMarks/500.0)*100;

Console.WriteLine(Percentage);

if(Percentage >=90 && Percentage<=100)
{
    Console.WriteLine("Your Grade is A+");
}
else if(Percentage >=80 && Percentage<90)
{
    Console.WriteLine("Your Grade is A");
    
}
else if(Percentage >= 70 && Percentage <= 80)
{
    Console.WriteLine("Your Grade is B+");
}
else if(Percentage >= 60 && Percentage <=70)
{
    Console.WriteLine("Your Grade is B");
}
else if(Percentage >= 50 && Percentage <= 60)
{
    Console.WriteLine("Your Grade is C");
}
else
{
    Console.WriteLine("You Have Failed.");
}