using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal class InternationalShipment : Shipment

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
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry ,decimal customsFee) 
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"International Shipment\n \ntracking code is :{TrackingCode}\n description:{Description} \nweight: {Weight} KG\ndeliveery:{DeliveryFee} EG" +
                $"\nEstimatedCost: {EstimatedCost} EG\nDestination Country:{DestinationCountry} \nCustoms Fee: {CustomsFee} EG\n--------------------------------------------------------------------\n"); ;
        }
        public virtual void GenerateCustomsReport()
        {

        }
    }
}
