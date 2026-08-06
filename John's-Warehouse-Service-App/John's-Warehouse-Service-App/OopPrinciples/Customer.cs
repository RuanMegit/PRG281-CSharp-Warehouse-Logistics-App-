using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class Customer : Person
    {
        // Customer specific field
        private string DeliveryAddress;

        // Constructor
        public Customer(int id, string firstName, string lastName,
                        string phoneNumber, string email,
                        string deliveryAddress)
            : base(id, firstName, lastName, phoneNumber, email)
        {
            DeliveryAddress = deliveryAddress;
        }

        // Property
        public string DeliveryAddress1
        {
            get => DeliveryAddress;
            set => DeliveryAddress = value;
        }

        // Polymorphism Methods
        public override void DisplayPersonInformation()
        {
            Console.WriteLine("===== Customer Information =====");
            Console.WriteLine($"ID: {Id1}");
            Console.WriteLine($"Name: {FirstName1} {LastName1}");
            Console.WriteLine($"Phone: {PhoneNumber1}");
            Console.WriteLine($"Email: {Email1}");
            Console.WriteLine($"Delivery Address: {DeliveryAddress1}");
        }
    }
}
