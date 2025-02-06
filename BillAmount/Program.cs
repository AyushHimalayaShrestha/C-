using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the total bill amount
        Console.Write("Enter your bill amount: ");
        int billAmount = int.Parse(Console.ReadLine());

        // Declare variables
        double discountPercentage, totalAmount, discountAmount;

        // Check if the bill amount is negative
        if (billAmount < 0)
        {
            Console.WriteLine("Bill Amount cannot be negative.");
        }
        else
        {
            // Determine discount percentage based on bill amount
            if (billAmount < 10000)
            {
                discountPercentage = 0;
            }
            else if (billAmount >= 10000 && billAmount <= 50000)
            {
                discountPercentage = 10;
            }
            else
            {
                discountPercentage = 15;
            }

            // Calculate the discount and total payable amount
            discountAmount = (discountPercentage / 100) * billAmount;
            totalAmount = billAmount - discountAmount;

            // Display the results
            Console.WriteLine($"Total Bill Amount: {billAmount:F2}");
            Console.WriteLine($"Discount Amount: {discountAmount:F2}");
            Console.WriteLine($"Total Payable Amount: {totalAmount:F2}");
        }
    }
}
