using John_s_Warehouse_Service_App.Exceptions;
using John_s_Warehouse_Service_App.OopPrinciples;
using System;

namespace John_s_Warehouse_Service_App.Menu
{
    internal class EmployeeMenu : MenuManager
    {
        // Employee Menu
        public static void EmployeeMenus(Warehouse warehouse)
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("===== Employee Management =====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Remove Employee");
                Console.WriteLine("0. Back");

                string choice = InputException.ReadMenuChoice(0, 3);

                switch (choice)
                {
                    case "1":
                        AddEmployee(warehouse);
                        break;

                    case "2":
                        ViewEmployees(warehouse);
                        break;

                    case "3":
                        RemoveEmployee(warehouse);
                        break;

                    case "0":
                        back = true;
                        break;
                }
            }
        }

        // Add Employee
        public static void AddEmployee(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Add Employee =====");

            int id = InputException.ReadInt("Employee ID: ");

            // Prevent duplicate IDs
            foreach (Employee employeee in warehouse.Employees1)
            {
                if (employeee.Id1 == id)
                {
                    Console.WriteLine("An employee with this ID already exists.");
                    Pause();
                    return;
                }
            }

            string firstName = InputException.ReadString("First Name: ");

            string lastName = InputException.ReadString("Last Name: ");

            string phone = InputException.ReadPhone("Phone Number: ");

            string email = InputException.ReadEmail("Email: ");

            string position = InputException.ReadString("Position: ");

            double salary = InputException.ReadDouble("Salary: ");

            bool available = InputException.ReadBool("Is Available (Yes/No): ");

            Employee employee = new Employee(
                id,
                firstName,
                lastName,
                phone,
                email,
                position,
                salary,
                available);

            warehouse.AddEmployee(employee);

            Console.WriteLine();
            Console.WriteLine("Employee added successfully.");

            Pause();
        }

        // View Employees
        public static void ViewEmployees(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Employee List =====");

            if (warehouse.Employees1.Count == 0)
            {
                Console.WriteLine("No employees found.");
            }
            else
            {
                foreach (Employee employee in warehouse.Employees1)
                {
                    employee.DisplayPersonInformation();
                    Console.WriteLine();
                }
            }

            Pause();
        }

        // Remove Employee
        public static void RemoveEmployee(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Remove Employee =====");

            int id = InputException.ReadInt("Enter Employee ID: ");

            Employee employeeToRemove = null;

            foreach (Employee employee in warehouse.Employees1)
            {
                if (employee.Id1 == id)
                {
                    employeeToRemove = employee;
                    break;
                }
            }

            if (employeeToRemove != null)
            {
                warehouse.RemoveEmployee(employeeToRemove);
                Console.WriteLine("Employee removed successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

            Pause();
        }
    }
}