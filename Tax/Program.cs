
Console.WriteLine("Enter Your Salary : ");
double Salary = double.Parse(Console.ReadLine());

if (Salary < 0)
{
    Console.WriteLine("Invalid Input! Salary cannot be in negative");

}
else
{
    double taxAmount;
    double taxPercentage;
    double totalSalary;
    if (Salary <= 400000)
    {
        taxPercentage = 1;
    }
    else if (Salary > 400000 && Salary <= 500000)
    {
        taxPercentage = 15;
    }
    else
    {
        taxPercentage = 36;
    }
    taxAmount = (taxPercentage / 100) * Salary;
    totalSalary = Salary - taxAmount;

    Console.WriteLine($"Basic Salary : {Salary:F2}");
    Console.WriteLine($"Tax Amount :{taxAmount:F2}");
    Console.WriteLine($"Total Salary:{totalSalary:F2}");
}

