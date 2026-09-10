using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal static class Deliveryreport
    {
        public static void printshipment(Itrackable shipment )
        {
            Console.WriteLine(shipment.GetTrackingstatue());
        }
        public static void printinsurance(Ilnsurable shipment)
        {
            Console.WriteLine(shipment.Calculatelnsurable());
        }
    }
}
