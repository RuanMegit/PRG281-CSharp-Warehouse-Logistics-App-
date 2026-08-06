using John_s_Warehouse_Service_App.OopPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_s_Warehouse_Service_App.OopPrinciples
{
    internal abstract class Person
    {
        // Fields
        private int Id;
        private string FirstName;
        private string LastName;
        private string PhoneNumber;
        private string Email;

        // Constructor
        protected Person(int id, string firstName, string lastName,
                         string phoneNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Properties
        public int Id1 { get => Id; set => Id = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Email1 { get => Email; set => Email = value; }

        //Polymorphism
        public abstract void DisplayPersonInformation();
    }
}
