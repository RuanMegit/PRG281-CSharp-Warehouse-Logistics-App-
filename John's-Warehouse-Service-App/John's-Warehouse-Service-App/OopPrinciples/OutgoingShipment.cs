using John_s_Warehouse_Service_App.OopPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal class OutgoingShipment : Shipment
    {
        private string CustomerName;

        public OutgoingShipment(int shipmentId,
                                DateTime shipmentDate,
                                string status,
                                string destination,
                                string customerName)
            : base(shipmentId, shipmentDate, status, destination)
        {
            CustomerName = customerName;
        }

        public string CustomerName1
        {
            get => CustomerName;
            set => CustomerName = value;
        }

        public override void ProcessShipment()
        {
            Console.WriteLine("Dispatching shipment to customer");
        }

        public void DisplayShippingInformation()
        {
            Console.WriteLine("===== Outgoing Shipment =====");
            Console.WriteLine($"Shipment ID: {ShipmentId1}");
            Console.WriteLine($"Date: {ShipmentDate1:d}");
            Console.WriteLine($"Status: {Status1}");
            Console.WriteLine($"Destination: {Destination1}");
            Console.WriteLine($"Customer: {CustomerName1}");
        }
    }
}
