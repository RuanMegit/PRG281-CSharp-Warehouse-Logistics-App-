using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class Employee : Person
    {
        // Employee specific fields
        private string Position;
        private double Salary;
        private bool IsAvailable;

        // Constructor
        public Employee(int id, string firstName, string lastName,
                        string phoneNumber, string email,
                        string position, double salary, bool isAvailable)
            : base(id, firstName, lastName, phoneNumber, email)
        {
            Position = position;
            Salary = salary;
            IsAvailable = isAvailable;
        }

        // Properties
        public string Position1 { get => Position; set => Position = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public bool IsAvailable1 { get => IsAvailable; set => IsAvailable = value; }

        // Polymorphism Methods
        public override void DisplayPersonInformation()
        {
            Console.WriteLine("===== Employee Information =====");
            Console.WriteLine($"ID: {Id1}");
            Console.WriteLine($"Name: {FirstName1} {LastName1}");
            Console.WriteLine($"Phone: {PhoneNumber1}");
            Console.WriteLine($"Email: {Email1}");
            Console.WriteLine($"Position: {Position1}");
            Console.WriteLine($"Salary: R{Salary1}");
            Console.WriteLine($"Available: {IsAvailable1}");
        }

    }
}
