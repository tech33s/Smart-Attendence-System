using System;
using System.Collections.Generic;

namespace AttendanceSystem
{
    class Program
    {
        static List<string> students = new List<string>();
        static List<string> employees = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Admin Panel");
                Console.WriteLine("2. Check In");
                Console.WriteLine("3. Check Out");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                if (choice == "1")
                    AdminPanel();
                else if (choice == "2")
                    Console.WriteLine("Check In feature");
                else if (choice == "3")
                    Console.WriteLine("Check Out feature");
                else if (choice == "4")
                    break;
            }
        }

        static void AdminPanel()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1) Add Student");
                Console.WriteLine("2) Add Employee");
                Console.WriteLine("3) View All People");
                Console.WriteLine("4) View Report");
                Console.WriteLine("5) Back to Main Menu");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                    AddStudent();
                else if (choice == "2")
                    AddEmployee();
                else if (choice == "3")
                    ViewAllPeople();
                else if (choice == "4")
                    ViewReport();
                else if (choice == "5")
                    break;
            }
        }

        static void AddStudent()
        {
            Console.Clear();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Student Code: ");
            string studentCode = Console.ReadLine();

            students.Add($"Name: {name}, Email: {email}, Student Code: {studentCode}");
            Console.WriteLine("Student added successfully!");
            Console.ReadKey();
        }

        static void AddEmployee()
        {
            Console.Clear();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Code: ");
            string code = Console.ReadLine();

            employees.Add($"Name: {name}, Email: {email}, Code: {code}");
            Console.WriteLine("Employee added successfully!");
            Console.ReadKey();
        }

        static void ViewAllPeople()
        {
            Console.Clear();
            Console.WriteLine(" Students ");
            if (students.Count == 0)
                Console.WriteLine("No students found.");
            else
            {
                foreach (string student in students)
                    Console.WriteLine(student);
            }

            Console.WriteLine("\n Employees ");
            if (employees.Count == 0)
                Console.WriteLine("No employees found.");
            else
            {
                foreach (string employee in employees)
                    Console.WriteLine(employee);
            }

            Console.ReadKey();
        }

        static void ViewReport()
        {
            Console.Clear();
            Console.WriteLine($"Total Students: {students.Count}");
            Console.WriteLine($"Total Employees: {employees.Count}");
            Console.WriteLine($"Total People: {students.Count + employees.Count}");
            Console.ReadKey();
        }
    }
}