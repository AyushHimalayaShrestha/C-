using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your marks (0-100): ");
        int marks = int.Parse(Console.ReadLine());

        string grade;

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid marks. Please enter between 0 and 100.");
            return; // exit the program
        }

        if (marks >= 90)
            grade = "A+";
        else if (marks >= 80)
            grade = "A";
        else if (marks >= 70)
            grade = "B";
        else if (marks >= 60)
            grade = "C";
        else if (marks >= 50)
            grade = "D";
        else
            grade = "Fail";

        Console.WriteLine($"Your Grade is: {grade}");
    }
}

