using System;

using KurtovoKonare.Interfaces;

namespace KurtovoKonare.Customers
{
    public class Customer : ICustomer
    {
        private string name;

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.CustomerType = type;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("name", "Name cannot be null, empty or whitespaces!");
                }
                this.name = value;
            }
        }

        public CustomerType CustomerType { get; set; }
    }
}
