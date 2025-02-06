
string str = "I am learning .net";
string[] strings=str.Split(' ');

for (int i = 0; i < strings.Length; i++)
{
    Console.WriteLine((i+1)+ " "+ strings[i]);
}

str = str.Replace(".net", "C#");
Console.WriteLine(str);

str = str.Remove(0,4);
Console.WriteLine(str);



// To print letters in reverse order.
string stat = "HELLO WORLD";
stat.ToLower();
Console.WriteLine(stat);
for(int j=stat.Length-1; j>=0; j--)
{
    Console.WriteLine(stat[j]);
}

if(stat.Contains("Hello"))
{
    Console.WriteLine("It contains Hello");
}
else
{
    Console.WriteLine("It doesn't contain Hello.");
}