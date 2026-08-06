using John_s_Warehouse_Service_App.Exceptions;
using John_s_Warehouse_Service_App.OopPrinciples;
using System;

namespace John_s_Warehouse_Service_App.Menu
{
    internal class ShipmentMenu : MenuManager
    {
        // Shipment Menu
        public static void ShipmentMenus(Warehouse warehouse)
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();

                Console.WriteLine("===== Shipment Management =====");
                Console.WriteLine("1. Add Incoming Shipment");
                Console.WriteLine("2. Add Outgoing Shipment");
                Console.WriteLine("3. View Shipments");
                Console.WriteLine("4. Remove Shipment");
                Console.WriteLine("0. Back");

                string choice = InputException.ReadMenuChoice(0, 4);

                switch (choice)
                {
                    case "1":
                        AddIncomingShipment(warehouse);
                        break;

                    case "2":
                        AddOutgoingShipment(warehouse);
                        break;

                    case "3":
                        ViewShipments(warehouse);
                        break;

                    case "4":
                        RemoveShipment(warehouse);
                        break;

                    case "0":
                        back = true;
                        break;
                }
            }
        }

        // Add Incoming Shipment
        public static void AddIncomingShipment(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Add Incoming Shipment =====");

            int id = InputException.ReadInt("Shipment ID: ");
            string status = InputException.ReadString("Status: ");
            string destination = InputException.ReadString("Destination: ");
            string supplier = InputException.ReadString("Supplier: ");

            IncomingShipment shipment = new IncomingShipment(
                id,
                DateTime.Now,
                status,
                destination,
                supplier);

            warehouse.AddShipment(shipment);

            Console.WriteLine();
            Console.WriteLine("Incoming shipment added successfully.");

            Pause();
        }

        // Add Outgoing Shipment
        public static void AddOutgoingShipment(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Add Outgoing Shipment =====");

            int id = InputException.ReadInt("Shipment ID: ");
            string status = InputException.ReadString("Status: ");
            string destination = InputException.ReadString("Destination: ");
            string customer = InputException.ReadString("Customer Name: ");

            OutgoingShipment shipment = new OutgoingShipment(
                id,
                DateTime.Now,
                status,
                destination,
                customer);

            warehouse.AddShipment(shipment);

            Console.WriteLine();
            Console.WriteLine("Outgoing shipment added successfully.");

            Pause();
        }

        // View Shipments
        public static void ViewShipments(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Shipment List =====");

            if (warehouse.Shipments1.Count == 0)
            {
                Console.WriteLine("No shipments found.");
            }
            else
            {
                foreach (Shipment shipment in warehouse.Shipments1)
                {
                    if (shipment is IncomingShipment incoming)
                    {
                        incoming.DisplayShippingInformation();
                    }
                    else if (shipment is OutgoingShipment outgoing)
                    {
                        outgoing.DisplayShippingInformation();
                    }

                    Console.WriteLine();
                }
            }

            Pause();
        }

        // Remove Shipment
        public static void RemoveShipment(Warehouse warehouse)
        {
            Console.Clear();

            Console.WriteLine("===== Remove Shipment =====");

            int id = InputException.ReadInt("Enter Shipment ID: ");

            Shipment shipmentToRemove = null;

            foreach (Shipment shipment in warehouse.Shipments1)
            {
                if (shipment.ShipmentId1 == id)
                {
                    shipmentToRemove = shipment;
                    break;
                }
            }

            if (shipmentToRemove != null)
            {
                warehouse.RemoveShipment(shipmentToRemove);
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Pause();
        }
    }
}