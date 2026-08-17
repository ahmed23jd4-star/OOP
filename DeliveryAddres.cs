using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop01
{
    internal struct DeliveryAddres
    {
       public string city;
       public string street;
       public int buildingnumber;
        public DeliveryAddres(int buildnumber , string street , string city)
        {
            this.city = city;
            this.street = street;
            buildingnumber = buildnumber;
        }
        public void GetFullAddress()
        {
            Console.WriteLine($"city : {city} \n street : {street} \n buildnumber {buildingnumber} ");
        }

    }
}
