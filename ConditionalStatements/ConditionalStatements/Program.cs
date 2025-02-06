/*
 Conditional Statement
to check conditions
1. If statement
        syntax:
                if(condition)
                    {
                        statement if condition is true;
                    }

2. If else statement
        syntax:
            if(condition)
            {
                statement if condition is true;
            }
            else
            {
                statement if condition is false;
            }
3. If else if else statement
        syntax:
            if(condition1)
            {
                statement if condition1 is true;
            }
            else if(condtion2)
            {
                statement if condition2 is true;
            }
            else if(condition3)
            {

            }
            else
            {
                statement if all above conditions are false;
            }
 */


Console.WriteLine("Enter any number : ");
int number=int.Parse(Console.ReadLine());

if (number % 5 == 0 )
{
    Console.WriteLine(number + " is divisible by 5");
}
else
{
    Console.WriteLine(number + "is not divisible by 5");
}