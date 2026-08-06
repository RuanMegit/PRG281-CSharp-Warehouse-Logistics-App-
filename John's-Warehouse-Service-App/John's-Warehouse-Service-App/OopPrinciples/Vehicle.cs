using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal abstract class Vehicle
    {
        // fields / Objects of a Vehicle
        // fields / Objects of a Truck
        private int TrId;
        private string RegistrationNumber;
        private string Make;
        private int MaximumLoadCapacity;
        private int CurrentLoad;
        private string Status;
        private Employee Driver;

        // Constructor
        protected Vehicle(int trId, string registrationNumber, string make, int maximumLoadCapacity, int currentLoad, string status, Employee driver)
        {
            TrId1 = trId;
            RegistrationNumber1 = registrationNumber;
            Make1 = make;
            MaximumLoadCapacity1 = maximumLoadCapacity;
            CurrentLoad1 = currentLoad;
            Status1 = status;
            Driver1 = driver;
        }

        // Properties
        public int TrId1 { get => TrId; set => TrId = value; }
        public string RegistrationNumber1 { get => RegistrationNumber; set => RegistrationNumber = value; }
        public string Make1 { get => Make; set => Make = value; }
        public int MaximumLoadCapacity1 { get => MaximumLoadCapacity; set => MaximumLoadCapacity = value; }
        public int CurrentLoad1 { get => CurrentLoad; set => CurrentLoad = value; }
        public string Status1 { get => Status; set => Status = value; }
        internal Employee Driver1 { get => Driver; set => Driver = value; }

        // Polymorphism Methods
        public abstract void Deliver();
    }
}
