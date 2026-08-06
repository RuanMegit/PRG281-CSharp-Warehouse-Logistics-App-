using John_s_Warehouse_Service_App.OopPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class IncomingShipment : Shipment
    {
        private string Supplier;

        public IncomingShipment(int shipmentId,
                                DateTime shipmentDate,
                                string status,
                                string destination,
                                string supplier)
            : base(shipmentId, shipmentDate, status, destination)
        {
            Supplier = supplier;
        }

        public string Supplier1
        {
            get => Supplier;
            set => Supplier = value;
        }

        public override void ProcessShipment()
        {
            Console.WriteLine("Receiving shipment into the warehouse...");
        }

        public void DisplayShippingInformation()
        {
            Console.WriteLine("===== Incoming Shipment =====");
            Console.WriteLine($"Shipment ID: {ShipmentId1}");
            Console.WriteLine($"Date: {ShipmentDate1:d}");
            Console.WriteLine($"Status: {Status1}");
            Console.WriteLine($"Destination: {Destination1}");
            Console.WriteLine($"Supplier: {Supplier1}");
        }
    }
}
