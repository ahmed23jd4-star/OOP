using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal class InternationalShipment : Shipment ,Itrackable,Ilnsurable

    {
        string destinationCountry;
        decimal customsFee;
        public string DestinationCountry { get=> destinationCountry; set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            } 
        }
        public decimal CustomsFee { get=> customsFee;
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }
        public override decimal EstimatedCost { get => DeliveryFee + (Weight * 5) + CustomsFee; }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry ,decimal customsFee) 
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"tracking code : {TrackingCode}\nDestination Country : {DestinationCountry}\nEstimatedCost: {EstimatedCost} EG\n ");
        }

        public string GetTrackingstatue()
        {
            return "Shipment SH003 has been Delivered";
        }

        public decimal Calculatelnsurable()
        {
            return (.12m * EstimatedCost);
        }
        public override string ToString()
        {
            return "interntinal shipment";
        }
    }
}
