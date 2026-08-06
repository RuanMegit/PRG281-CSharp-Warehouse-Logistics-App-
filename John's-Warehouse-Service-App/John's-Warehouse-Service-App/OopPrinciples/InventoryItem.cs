using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class InventoryItem
    {
        // Fields
        private int ItemId;
        private string ItemName;
        private string Category;
        private int Quantity;
        private decimal UnitPrice;
        private string StorageLocation;
        
        // Constructor
        public InventoryItem(int itemId, string itemName, string category,
                             int quantity, decimal unitPrice, string storageLocation)
        {
            ItemId1 = itemId;
            ItemName1 = itemName;
            Category1 = category;
            Quantity1 = quantity;
            UnitPrice1 = unitPrice;
            StorageLocation1 = storageLocation;
        }

        // Properties
        public int ItemId1 { get => ItemId; set => ItemId = value; }
        public string ItemName1 { get => ItemName; set => ItemName = value; }
        public string Category1 { get => Category; set => Category = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public decimal UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }
        public string StorageLocation1 { get => StorageLocation; set => StorageLocation = value; }


        // Methods

        // Add stock
        public void AddStock(int amount)
        {
            Quantity1 += amount;

            Console.WriteLine($"{amount} units added to {ItemName1}.");
        }

        // Remove stock
        public void RemoveStock(int amount)
        {
            if (amount > Quantity1)
            {
                Console.WriteLine("Not enough stock available.");
                return;
            }

            Quantity1 -= amount;

            Console.WriteLine($"{amount} units removed from {ItemName1}.");
        }

        // Check if stock is low
        public bool IsLowStock()
        {
            return Quantity1 <= 10;
        }

        // Update the item's price
        public void UpdatePrice(decimal newPrice)
        {
            UnitPrice1 = newPrice;
        }

        // Display item information
        public void DisplayInventoryInformation()
        {
            Console.WriteLine("===== Inventory Item =====");
            Console.WriteLine($"Item ID: {ItemId1}");
            Console.WriteLine($"Item Name: {ItemName1}");
            Console.WriteLine($"Category: {Category1}");
            Console.WriteLine($"Quantity: {Quantity1}");
            Console.WriteLine($"Unit Price: R{UnitPrice1}");
            Console.WriteLine($"Storage Location: {StorageLocation1}");
        }
    }
}
