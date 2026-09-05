using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace assignmentoop02
{
    internal struct DeliveryAddress
    {
        //djkls
        public string City { get; set; }
        public string Street { get; set; }
        int buildnumber;
        public int Buildingnumber
        {
            get => buildnumber;
            set
            {
                if (value > 0)
                    buildnumber = value;
            }
        }
        public int[] x = new int[10];

        public DeliveryAddress(string city, string street,int buildingnumber)
        {
            City = city;
            Street = street;
            Buildingnumber = buildingnumber;
        }
        public string GetFullAddress()
        {
           return $"city is {City}\nthe street is {Street}\nand build number {Buildingnumber}";
        }




    }
}
