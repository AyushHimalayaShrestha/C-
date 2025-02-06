//To Convert temperature from Fahrenheit to Celsius and Celsius to Fahrenheit
/* Formula
   Celsius to Fahrenheit: (°C X 9/5) +32 =°F
Fahrenheit to Celsius: (°F-32)X5/9 =°C
*/

Console.WriteLine("Enter your Choice:\n1.Celsius to Fahrenheit \n2.Fahrenheit to Celsius");
int choice=int.Parse(Console.ReadLine());

if (choice == 1 )
{
    Console.WriteLine("Enter Celsius : ");
    float celsius=float.Parse(Console.ReadLine());
    float fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine($"Fahrenheit ={fahrenheit:F2}");
}
else if (choice == 2 )
{
    Console.WriteLine("Enter Fahrenheit : ");
    float fahrenheit=float.Parse(Console.ReadLine());
    float celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"Celsius={celsius:F2}");
}
else
{
    Console.WriteLine("Wrong Input");
}
