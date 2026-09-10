using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal class Shipment
    {
        #region private field
        public int x;
        string description;
        decimal weight;
        #endregion
        #region property
        public string TrackingCode { get; }
        public string Description { get =>description;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public Decimal Weight { get => weight;
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public Decimal DeliveryFee{ get ; private set;}
        public DeliveryAddress Destination { get; set; }
        public decimal EstimatedCost { get => DeliveryFee + (Weight * 5); }
        #endregion
        #region constructor
        public Shipment(string trackingcode) {
            if (!string.IsNullOrWhiteSpace(trackingcode))
            TrackingCode = trackingcode;
            Description = "unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
            TrackingCode = trackingCode;
            }
            Description = description;
            Weight = weight;
            if(deliveryFee>0)
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        #endregion
        #region method
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine($"tracking code is {TrackingCode} description is {Description} and weight is {Weight} \nthe deliveery fee is {DeliveryFee}" +
                $"deliveryaddrese is {Destination.GetFullAddress()} \nEstimatedCost: {EstimatedCost}\n");
        }
        #endregion
    }
}
