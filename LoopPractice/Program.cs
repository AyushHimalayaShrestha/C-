//To print natural numbers from 1-100, 101-200,201-300

int a = 1;
while (a <= 100)
{
    Console.Write(a + "\t");
    a++;
}


int b = 101;
do
{
    Console.Write(b + "\t");
    b++;
}
while (b <= 200);

for (int c = 201; c <= 300; c++)
{
    Console.Write(c + "\t");
}

//To print even number from 1-100

int d = 0;
while (d <= 100)
{
    Console.Write(d+"\t");
    d += 2;
}

//To print odd number from 1-100
int e=1;
do
{
    Console.Write(e+"\t");
    e+=2;
}
while (e<=100);

// To generate terms of a series 1,5,9,13,17,21,25,29,33,37

int f;
for(f=1; f<=37; f+=4)
{
    Console.Write(f+"\t");
    
}

Console.WriteLine("Enter a number: ");
int g;
g=int.Parse(Console.ReadLine());
for(int i=1; i<=10; i++ )
{
    Console.WriteLine(g + "x" + i + "=" + g * i);
}
