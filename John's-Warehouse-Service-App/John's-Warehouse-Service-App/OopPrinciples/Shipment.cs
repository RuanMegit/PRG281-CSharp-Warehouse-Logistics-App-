using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal abstract class Shipment
    {
        // Fields
        private int ShipmentId;
        private DateTime ShipmentDate;
        private string Status;
        private string Destination;

        // Constructor
        protected Shipment(int shipmentId, DateTime shipmentDate,
                           string status, string destination)
        {
            ShipmentId1 = shipmentId;
            ShipmentDate1 = shipmentDate;
            Status1 = status;
            Destination1 = destination;
        }

        public int ShipmentId1 { get => ShipmentId; set => ShipmentId = value; }
        public DateTime ShipmentDate1 { get => ShipmentDate; set => ShipmentDate = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Destination1 { get => Destination; set => Destination = value; }

        // Properties


        // Polymorphism
        public abstract void ProcessShipment();
    }
}