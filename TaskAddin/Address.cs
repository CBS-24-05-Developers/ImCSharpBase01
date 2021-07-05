using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAddin
{
    public partial class Address
    {
        int index;
        string country;
        string city;
        string street;
        string house;
        ushort apartment;

        public Address()
        {

        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public ushort Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
