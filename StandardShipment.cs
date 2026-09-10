using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal class StandardShipment :Shipment,Itrackable,Ilnsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode,description,weight,deliveryFee,destination)
        {

        }
        public override decimal EstimatedCost { get => DeliveryFee + (Weight * 5); }
        public override void PrintShipment()
        {
            Console.WriteLine($"tracking code : {TrackingCode}\nDescription : {Description}\nEstimatedCost: {EstimatedCost} EG\n ");
        }
        public override string GetTrackingstatue()
        {
            return "Shipment SH001 is Ready.";
        }

        public decimal Calculatelnsurable()
        {
            return .05m * EstimatedCost;
        }
        public override string ToString()
        {
            return "standerd shipment";
        }
    }
}
