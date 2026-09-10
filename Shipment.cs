using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal  partial class Shipment 
    {
        //TrackingCode string        cannot be null, empty, or whitespace.  read-only from outside
        //Description string         cannot be null, empty, or whitespace.  read/write property with validation.
        //Weight decimal            must be greater than 0.                 read/write property with validation.
        //DeliveryFee decimal       must be greater than 0.                 public getter and private setter.
        //Destination DeliveryAddress                                       public read/write property.
        //EstimatedCost: a calculated property that returns: DeliveryFee + (Weight × 5)
        #region private field
        public int x;
        string description;
        decimal weight;
       public static int TotalShipmentsCreated;
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
        public virtual decimal EstimatedCost { get ; }
        #endregion
        #region constructor
         static Shipment()
        {
            Console.WriteLine("Shipment System Initialized");
            TotalShipmentsCreated = 0;
        }
        public Shipment(string trackingcode) {
            if (!string.IsNullOrWhiteSpace(trackingcode))
            TrackingCode = trackingcode;
            Description = "unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();

            TotalShipmentsCreated++;
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

            TotalShipmentsCreated++;
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
        public virtual void PrintShipment() { }
        public static  int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        #endregion

        #region method copying
        public Shipment shallowcopy()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            
            Shipment deep = (Shipment) MemberwiseClone();
            deep.Destination = new DeliveryAddress(this.Destination.City,this.Destination.Street,this.Destination.Buildingnumber);
            return deep;
        }

        #endregion
        public partial void OnTrackingStatusChanged(string newStatus);
    }
}
