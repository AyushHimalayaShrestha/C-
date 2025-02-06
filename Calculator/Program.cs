

char choice;
int result;
Console.WriteLine("Select any one a to d from below");

Console.WriteLine("a. Add");
Console.WriteLine("b. Subtract");
Console.WriteLine("c. Product");
Console.WriteLine("d. Division");

choice=char.Parse(Console.ReadLine());

Console.WriteLine("Enter first number");
int firstNumber=int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int secondNumber=   int.Parse(Console.ReadLine());

switch(choice)
{
    case 'a':
        result=firstNumber+secondNumber;
        Console.WriteLine("The sum is : " + result);
        break;

    case 'b':
        result=firstNumber-secondNumber; 
        Console.WriteLine("The difference is : "+result);
        break;

    case 'c':
        result=firstNumber*secondNumber;
        Console.WriteLine("The product is : " + result);
        break;

    case 'd':
        if(secondNumber !=0)
        {
            result=firstNumber/secondNumber;
            Console.WriteLine("The quotient is : " + result);
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed");
        }
        break;

    default:
        Console.WriteLine("Invalid Section.Please Choose between a and d.");
        break;

}





