using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class Warehouse
    {
        //Fields
        private int WarehouseId;
        private string Name;
        private string Location;
        private int CurrentCapacity;
        private int MaximumCapacity;
        private List<Employee> Employees;
        private List<InventoryItem> InventoryItems;
        private List<Vehicle> Vehicles;
        private List<Shipment> Shipments;

        // Constructor
        public Warehouse(int warehouseId, string name, string location, int currentCapacity, int maximumCapacity)
        {
            WarehouseId1 = warehouseId;
            Name1 = name;
            Location1 = location;
            CurrentCapacity1 = currentCapacity;
            MaximumCapacity1 = maximumCapacity;
            Employees1 = new List<Employee>();
            InventoryItems1 = new List<InventoryItem>();
            Vehicles1 = new List<Vehicle>();
            Shipments1 = new List<Shipment>();
        }

        public int WarehouseId1 { get => WarehouseId; set => WarehouseId = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Location1 { get => Location; set => Location = value; }
        public int CurrentCapacity1 { get => CurrentCapacity; set => CurrentCapacity = value; }
        public int MaximumCapacity1 { get => MaximumCapacity; set => MaximumCapacity = value; }
        internal List<Employee> Employees1 { get => Employees; set => Employees = value; }
        internal List<InventoryItem> InventoryItems1 { get => InventoryItems; set => InventoryItems = value; }
        internal List<Vehicle> Vehicles1 { get => Vehicles; set => Vehicles = value; }
        internal List<Shipment> Shipments1 { get => Shipments; set => Shipments = value; }

        //Properties


        //Methods
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public void AddShipment(Shipment shipment)
        {
            Shipments.Add(shipment);
        }
        public void RemoveShipment(Shipment shipment)
        {
            Shipments.Remove(shipment);
        }
        public void CheckCapacity(int amount)
        {
            if (CurrentCapacity + amount > MaximumCapacity)
            {
                throw new Exception("Warehouse capacity exceeded.");
            }
        }
        public void AddInventoryItem(InventoryItem item)
        {
            CheckCapacity(item.Quantity1);

            InventoryItems.Add(item);

            CurrentCapacity += item.Quantity1;
        }
        public void RemoveInventoryItem(InventoryItem item)
        {
            if (InventoryItems.Contains(item))
            {
                InventoryItems.Remove(item);
                CurrentCapacity1 -= item.Quantity1;
            }
        }
        public Employee FindEmployee(int id)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.Id1 == id)
                    return employee;
            }

            return null;
        }

        public InventoryItem FindInventoryItem(int id)
        {
            foreach (InventoryItem item in InventoryItems)
            {
                if (item.ItemId1 == id)
                    return item;
            }

            return null;
        }
        public Vehicle FindVehicle(int id)
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.TrId1 == id)
                    return vehicle;
            }

            return null;
        }
        public Shipment FindShipment(int id)
        {
            foreach (Shipment shipment in Shipments)
            {
                if (shipment.ShipmentId1 == id)
                    return shipment;
            }

            return null;
        }

        // Display Information
        public void DisplayWarehouseInformation()
        {
            Console.WriteLine("===== Warehouse Information =====");
            Console.WriteLine($"ID: {WarehouseId1}");
            Console.WriteLine($"Name: {Name1}");
            Console.WriteLine($"Location: {Location1}");
            Console.WriteLine($"Capacity: {CurrentCapacity1}/{MaximumCapacity1}");
            Console.WriteLine($"Employees: {Employees.Count}");
            Console.WriteLine($"Inventory Items: {InventoryItems.Count}");
            Console.WriteLine($"Vehicles: {Vehicles.Count}");
            Console.WriteLine($"Shipments: {Shipments.Count}");
        }
    }
}
