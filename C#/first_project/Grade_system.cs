using System;

public class Mark
{
    public void ShowStudentDetails(string name, int age, string department, int rollNumber, int[] marks)
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Roll Number: " + rollNumber);
    }

    public int CalculateTotal(int[] marks)
    {
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;
        }
        return total;
    }
    
    public double CalculateAverage(int total,int len)
    {
        if (len == 0) return 0;
        return (double)total / len;
    }

    public string DetermineGrade(double average)
    {
        if (average >= 90)
        {
            return "A";
        }
        else if (average >= 80)
        {
            return "B";
        }
        else if (average >= 70)
        {
            return "C";
        }
        else if (average >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}

public class Prg
{
    public static void Main(string[] args)
    {
        Mark mark = new Mark();
        
        Console.Write("Enter the student's name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter the student's age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the student's department: ");
        string department = Console.ReadLine();
        
        Console.Write("Enter the student's roll number: ");
        int rollNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the number of subjects: ");
        int numSubjects = Convert.ToInt32(Console.ReadLine());
        
        int[] marks = new int[numSubjects];
        for (int i = 0; i < numSubjects; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        mark.ShowStudentDetails(name, age, department, rollNumber, marks);
        
        int totalMarks = mark.CalculateTotal(marks);
        double averageMarks = mark.CalculateAverage(totalMarks,numSubjects);
        string grade = mark.DetermineGrade(averageMarks);
        
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks);
        Console.WriteLine("Grade: " + grade);
    }
}