using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// linking the new namespaces/folders to program.
using John_s_Warehouse_Service_App.OopPrinciples;

namespace John_s_Warehouse_Service_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Employee class
            Employee employee1 = new Employee(1, "John", "Doe", "+27 01234567", "example@gmail.com", "Truck Driver", 20000, false);
            employee1.DisplayPersonInformation();

            //Customer class
            Customer customer1 = new Customer(1, "Mia", "Hee", "+27 11234567", "example@gmail.com", "Happy st Pretoria");
            customer1.DisplayPersonInformation();

            //Truck class
            Truck truck1 = new Truck(1, "W242 GP", "BMW", 1000, 200, "Free", employee1, true);
            truck1.DisplayTruckInformation();

            //Incoming class
            IncomingShipment incoming1 = new IncomingShipment(1, DateTime.Now, "Received", "John's Warehouse", "Resource Transportation");
            incoming1.DisplayShippingInformation();

            //Outgoing class
            OutgoingShipment outgoing1 = new OutgoingShipment(2, DateTime.Now, "Ready", "Pretoria", "Mia Hee");
            outgoing1.DisplayShippingInformation();

            // Inventory Item class
            InventoryItem item1 = new InventoryItem(1, "Office Chair", "Furniture", 50, 1299.99m, "Aisle A Shelf 1");
            item1.DisplayInventoryInformation();

            //Warehouse class
            Warehouse warehouse1 = new Warehouse(1, "WareHouseOne", "Pretoria", 0, 100);
            warehouse1.AddEmployee(employee1);

            warehouse1.AddVehicle(truck1);

            warehouse1.AddShipment(incoming1);

            warehouse1.AddShipment(outgoing1);

            warehouse1.AddInventoryItem(item1);

            warehouse1.DisplayWarehouseInformation();

        }
    }
}
