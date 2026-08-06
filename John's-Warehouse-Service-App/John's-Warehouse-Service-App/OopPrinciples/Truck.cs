using John_s_Warehouse_Service_App.OopPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class Truck : Vehicle
    {
        // fields
        private bool HasRefrigeration;

        // Properties
        public bool HasRefrigeration1 { get => HasRefrigeration; set => HasRefrigeration = value; }

        // Constructor
        public Truck(int trId, string registrationNumber, string make,
                 int maximumLoadCapacity, int currentLoad,
                 string status, Employee driver, bool hasRefrigeration)
        : base(trId, registrationNumber, make,
               maximumLoadCapacity, currentLoad,
               status, driver)
        {
            HasRefrigeration = hasRefrigeration;
        }

        //methods
        public void DisplayTruckInformation()
        {
            Console.WriteLine("===== Truck Information =====");
            Console.WriteLine($"ID: {TrId1}");
            Console.WriteLine($"Registration Number: {RegistrationNumber1}");
            Console.WriteLine($"Make Name: {Make1}");
            Console.WriteLine($"Maximum Load Capacity: {MaximumLoadCapacity1}Kg");
            Console.WriteLine($"Current Load: {CurrentLoad1}Kg");
            Console.WriteLine($"Status: {Status1}");
            Console.WriteLine($"Driver: {Driver1.FirstName1} {Driver1.LastName1}");
            Console.WriteLine($"Has Refrigeration: {HasRefrigeration1}");
        }
        public override void Deliver()
        {
            Console.WriteLine("Truck is delivering goods.");
        }
    }
}
