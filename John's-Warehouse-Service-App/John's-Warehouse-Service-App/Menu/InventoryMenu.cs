using John_s_Warehouse_Service_App.Exceptions;
using John_s_Warehouse_Service_App.OopPrinciples;
using System;

namespace John_s_Warehouse_Service_App.Menu
{
    internal class InventoryMenu : MenuManager
    {
        // Inventory Menu
        public static void InventoryMenus(Warehouse warehouse)
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("===== Inventory Management =====");
                Console.WriteLine("1. Add Inventory Item");
                Console.WriteLine("2. View Inventory");
                Console.WriteLine("3. Remove Inventory Item");
                Console.WriteLine("0. Back");

                string choice = InputException.ReadMenuChoice(0, 3);

                switch (choice)
                {
                    case "1":
                        AddInventoryItem(warehouse);
                        break;

                    case "2":
                        ViewInventory(warehouse);
                        break;

                    case "3":
                        RemoveInventoryItem(warehouse);
                        break;

                    case "0":
                        back = true;
                        break;
                }
            }
        }

        // Add Inventory Item
        public static void AddInventoryItem(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Add Inventory Item =====");

            int id = InputException.ReadInt("Item ID: ");

            // Prevent duplicate IDs
            foreach (InventoryItem existingItem in warehouse.InventoryItems1)
            {
                if (existingItem.ItemId1 == id)
                {
                    Console.WriteLine("An item with this ID already exists.");
                    Pause();
                    return;
                }
            }

            string name = InputException.ReadString("Item Name: ");

            string category = InputException.ReadString("Category: ");

            int quantity = InputException.ReadInt("Quantity: ");

            decimal price = InputException.ReadDecimal("Unit Price: ");

            string location = InputException.ReadString("Storage Location: ");

            try
            {
                InventoryItem item = new InventoryItem(
                    id,
                    name,
                    category,
                    quantity,
                    price,
                    location);

                warehouse.AddInventoryItem(item);

                Console.WriteLine();
                Console.WriteLine("Inventory item added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Pause();
        }

        // View Inventory
        public static void ViewInventory(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Inventory List =====");

            if (warehouse.InventoryItems1.Count == 0)
            {
                Console.WriteLine("No inventory items found.");
            }
            else
            {
                foreach (InventoryItem item in warehouse.InventoryItems1)
                {
                    item.DisplayInventoryInformation();
                    Console.WriteLine();
                }
            }

            Pause();
        }

        // Remove Inventory Item
        public static void RemoveInventoryItem(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Remove Inventory Item =====");

            int id = InputException.ReadInt("Enter Item ID: ");

            InventoryItem itemToRemove = null;

            foreach (InventoryItem item in warehouse.InventoryItems1)
            {
                if (item.ItemId1 == id)
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                warehouse.RemoveInventoryItem(itemToRemove);

                Console.WriteLine("Inventory item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            Pause();
        }
    }
}