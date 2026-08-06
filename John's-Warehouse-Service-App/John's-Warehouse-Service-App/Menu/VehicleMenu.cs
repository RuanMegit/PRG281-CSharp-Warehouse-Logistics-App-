using John_s_Warehouse_Service_App.Exceptions;
using John_s_Warehouse_Service_App.OopPrinciples;
using System;

namespace John_s_Warehouse_Service_App.Menu
{
    internal class VehicleMenu : MenuManager
    {
        // Vehicle Menu
        public static void VehicleMenus(Warehouse warehouse)
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("===== Vehicle Management =====");
                Console.WriteLine("1. Add Truck");
                Console.WriteLine("2. View Vehicles");
                Console.WriteLine("3. Remove Vehicle");
                Console.WriteLine("0. Back");

                string choice = InputException.ReadMenuChoice(0,3);

                switch (choice)
                {
                    case "1":
                        AddTruck(warehouse);
                        break;

                    case "2":
                        ViewVehicles(warehouse);
                        break;

                    case "3":
                        RemoveVehicle(warehouse);
                        break;

                    case "0":
                        back = true;
                        break;
                }
            }
        }

        // Add Truck
        public static void AddTruck(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Add Truck =====");

            int id = InputException.ReadInt("Truck ID: ");
            string registration = InputException.ReadString("Registration Number: ");
            string make = InputException.ReadString("Make: ");
            int maxLoad = InputException.ReadInt("Maximum Load Capacity (kg): ");
            int currentLoad = InputException.ReadInt("Current Load (kg): ");
            string status = InputException.ReadString("Status: ");

            Console.WriteLine();
            Console.WriteLine("Available Drivers");
            Console.WriteLine("-----------------");

            if (warehouse.Employees1.Count == 0)
            {
                Console.WriteLine("No employees available.");
                Pause();
                return;
            }

            foreach (Employee employee in warehouse.Employees1)
            {
                Console.WriteLine($"{employee.Id1}. {employee.FirstName1} {employee.LastName1}");
            }

            int driverId = InputException.ReadInt("Enter Driver ID: ");

            Employee driver = null;

            foreach (Employee employee in warehouse.Employees1)
            {
                if (employee.Id1 == driverId)
                {
                    driver = employee;
                    break;
                }
            }

            if (driver == null)
            {
                Console.WriteLine("Driver not found.");
                Pause();
                return;
            }

            bool refrigeration = InputException.ReadBool("Has Refrigeration (true/false): ");

            Truck truck = new Truck(
                id,
                registration,
                make,
                maxLoad,
                currentLoad,
                status,
                driver,
                refrigeration);

            warehouse.AddVehicle(truck);

            Console.WriteLine();
            Console.WriteLine("Truck added successfully.");

            Pause();
        }

        // View Vehicles
        public static void ViewVehicles(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Vehicle List =====");

            if (warehouse.Vehicles1.Count == 0)
            {
                Console.WriteLine("No vehicles found.");
            }
            else
            {
                foreach (Vehicle vehicle in warehouse.Vehicles1)
                {
                    if (vehicle is Truck truck)
                    {
                        truck.DisplayTruckInformation();
                        Console.WriteLine();
                    }
                }
            }

            Pause();
        }

        // Remove Vehicle
        public static void RemoveVehicle(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Remove Vehicle =====");

            int id = InputException.ReadInt("Enter Truck ID: ");

            Vehicle vehicleToRemove = null;

            foreach (Vehicle vehicle in warehouse.Vehicles1)
            {
                if (vehicle.TrId1 == id)
                {
                    vehicleToRemove = vehicle;
                    break;
                }
            }

            if (vehicleToRemove != null)
            {
                warehouse.RemoveVehicle(vehicleToRemove);
                Console.WriteLine("Vehicle removed successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }

            Pause();
        }
    }
}