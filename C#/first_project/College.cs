using System;

public class College
{
    
    public void CollegeDetails()
    {
        Console.WriteLine("Welcome to Kalasalingam College!");
        Console.WriteLine("We offer a variety of courses and programs.");
        Console.WriteLine("Our faculty is highly qualified and experienced.");
        Console.WriteLine("We provide excellent facilities for students.");
        Console.WriteLine("Join us to shape your future!");
    }
}

public class Studentdetails:College
{
    public void ShowStudentDetails(string name, int age, string department, int rollNumber)
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Roll Number: " + rollNumber);
    }
}


public class Staff:College
{
    public void ShowStaffDetails(string name, int age, string department, int staffId)
    {
        Console.WriteLine("\nStaff Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Staff ID: " + staffId);
    }

}

public class Collegeprg
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the choice (1 for Student, 2 for Staff): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Studentdetails student = new Studentdetails();
            

            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the student's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the student's department: ");
            string department = Console.ReadLine();

            Console.Write("Enter the student's roll number: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());


            student.ShowStudentDetails(name, age, department, rollNumber);
            student.CollegeDetails();
        }
        else if (choice == 2)
        {
            Staff staffMember = new Staff();
            

            Console.Write("Enter the staff member's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the staff member's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the staff member's department: ");
            string department = Console.ReadLine();

            Console.Write("Enter the staff member's ID: ");
            int staffId = Convert.ToInt32(Console.ReadLine());

            staffMember.ShowStaffDetails(name, age, department, staffId);
            staffMember.CollegeDetails();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 for Student or 2 for Staff.");
        }
    }
}