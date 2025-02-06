/*
 Loop - to perform same/similar task repeatedly
    
    -initialization : where to start
    -condition-check : upto when to continue /  when to stop
    -next : how to proceed
    -statement : what ot do(repeat)

1. while 

    initialization
        while(condition-check)
        {
            statement;
            next;
        }    

2. do-while
        
    initialization
        do
        {
               statement;
               next;
        } while(condition-check);

3.for
    for(initialization;condition-check;next)
    {
        statements;
    }
*/


//int i= 5;
//while(i<=10)
//{
//    Console.WriteLine(i+"." + "Hello! I'm Ayush Himalaya Shrestha and I am a programmer.");
//    i++;
//}

//int j= 13;
//do
//{
//    Console.WriteLine(j+"."+"Hello World!!");
//j++;
//}
//while(j<30);

//int k ;
//for (k = 1; k <= 100; k++)
//{
//    Console.WriteLine(k + "." + "Welcome!!");

//}

char choice = 'y';
while(choice=='y')
{
    Console.Write("Enter a : ");
    int a=int.Parse(Console.ReadLine());

    Console.Write("Enter b : ");
    int b=int.Parse(Console.ReadLine());

    Console.WriteLine("Sum = " + (a + b));
    Console.WriteLine("Do you want to continue? If yes press y.");
    choice=Console.ReadKey().KeyChar;
}

