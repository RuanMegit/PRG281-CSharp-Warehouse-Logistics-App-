using John_s_Warehouse_Service_App.Exceptions;
using John_s_Warehouse_Service_App.OopPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.Menu
{
    internal class MenuManager
    {

        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //Main Menu
        public static void MainMenu(Warehouse warehouse)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("    JOHN'S WAREHOUSE SERVICE APP");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Employee Management");
                Console.WriteLine("2. Inventory Management");
                Console.WriteLine("3. Vehicle Management");
                Console.WriteLine("4. Shipment Management");
                Console.WriteLine("5. Display Warehouse");
                Console.WriteLine("0. Exit");

                Console.Write("\nSelect an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EmployeeMenu.EmployeeMenus(warehouse);
                        break;

                    case "2":
                        InventoryMenu.InventoryMenus(warehouse);
                        break;

                    case "3":
                        VehicleMenu.VehicleMenus(warehouse);
                        break;

                    case "4":
                        ShipmentMenu.ShipmentMenus(warehouse);
                        break;

                    case "5":
                        warehouse.DisplayWarehouseInformation();
                        Pause();
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        Pause();
                        break;
                }
            }
        }
    }
}
