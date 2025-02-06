//Multipilcation table of 1 to 10

int n = 1;
while(n<=20)
{
    int i = 1;
    while(i<=10)
    {
        Console.WriteLine(n+"x"+i+"="+n*i); i++;
    }
    n++;
}

int m = 21;
do
{
    int j = 1;
    do
    {
        Console.WriteLine(m + "x" + j + "=" + m * j);
        j++;
    } while (j <= 10);
    m++;
} while (m <= 40);

for(int o=41; o<=60; o++)
{
    for (int k = 1; k <= 10; k++)
    {
        Console.WriteLine(o+"x"+k+"="+o+k);
    }
}
for(int k = 1;k<= 5; k++)
{
    for(int l = k; l<=5; l++)
    {
        Console.Write("*\t");
    }
    Console.WriteLine();
}
Console.WriteLine("*");
for (int k = 1; k <= 5; k++)
{
    for (int l = k; l <= 5; l++)
    {
        Console.Write("*\t");
    }
    Console.WriteLine();
}
Console.WriteLine("*");

