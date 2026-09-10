using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace assignmentoop02
{
    internal class ExpressShipment : Shipment,Itrackable,Ilnsurable
    {
        private decimal extrafee;
        public decimal ExtraFee
        {
            get => extrafee; set
            {
                if (value >= 0)
                    extrafee = value;
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extrafee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extrafee;
            
        }
        public override decimal EstimatedCost { get => DeliveryFee + (Weight * 5) + ExtraFee; }

        public override void PrintShipment()
        {
            Console.WriteLine($"tracking code : {TrackingCode}\nExtrafee : {ExtraFee} EG\nEstimatedCost: {EstimatedCost} EG\n ");
        }
        public override string GetTrackingstatue()
        {
            return "Shipment SH002 is Out for Delivery.";
        }

        public decimal Calculatelnsurable()
        {
            return .08m * EstimatedCost;
        }
        public override string ToString()
        {
            return "express shipment";
        }
    }

    


        }
    
