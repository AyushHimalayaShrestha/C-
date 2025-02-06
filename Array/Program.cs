//int[]a = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Enter the value of a["+i+"]:");
//    a[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0;i < 10;i++)
//{
//    Console.Write(a[i]+"\t");
//}


//WAP to input 10 numbers and find their maximum.

//int[]num= new int[10];  
//for (int i = 0; i<num.Length; i++)
//{
//    Console.WriteLine("Input numbers "+i+" : ");
//    num[i]=int.Parse(Console.ReadLine());
//}

//int max = num[0];
//for(int i = 0; i<num.Length;i++)
//{
//    if(max<num[i])
//    {
//        max=num[i];
//    }
//}
//Console.WriteLine("Maximum num is "+max);

//WAP to input 10 numbers and find their sum

int[] num = new int[10];
for (int i = 1; i<num.Length; i++)
{
    Console.WriteLine("Enter numbers "+ i+ " : ");
    num[i] = int.Parse(Console.ReadLine());
}
int sum= 0;
for (int i =0 ; i<num.Length ; i++)
{
    sum=sum+num[i];
}
Console.WriteLine("Sum = "+sum);

