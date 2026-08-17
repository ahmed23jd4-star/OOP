using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace assignmentoop01
{
    internal struct Shipment
    {
        #region 2.Ceate a Shipment struct

        //private string trackingCode;
        //private string description="unknown";
        //private int weight = 1;
        //private decimal deliveryFee=50m;
        //public DeliveryAddres Destination { set; get ; }
        //public string TrackingCode { get { return trackingCode; } }
        //public string Description { 
        //    set {
        //        if (!string.IsNullOrEmpty(value?.Trim()))
        //        {
        //            description = value;
        //        }
        //    }
        //    get { return description; }
        //}
        //public int Weight
        //{
        //    set
        //    {
        //        if (value > 0)
        //            weight = value;
        //     }
        //    get
        //    {
        //        return weight;
        //    }
        //}
        //public decimal DeliveryFee
        //{
        //    private set;
        //    get
        //    {
        //        return deliveryFee ;
        //    }
        //}
        //public decimal EstimatedCost
        //{
        //    get {
        //        return DeliveryFee + (Weight*5);
        //}
        //}
        //public Shipment(string track)
        //{
        //    if (!string.IsNullOrEmpty(track?.Trim()))
        //    {
        //        trackingCode = track;
        //    }
        //    Weight = 1;
        //    DeliveryFee = 50m;
        //    Description = "unknown";
        //    Destination = new DeliveryAddres();

        //}
        //public Shipment(string track, string descraption , int weight , decimal delevryfee , DeliveryAddres deliveryaddres )
        //{
        //    if (!string.IsNullOrEmpty(track?.Trim()))
        //    {
        //        trackingCode = track;
        //    }
        //    Weight = weight;
        //    Description = descraption;
        //    DeliveryFee = delevryfee;
        //    Destination = deliveryaddres;

        //} 
        //public void UpdateDeliveryFee(decimal deliveryfee)
        //{
        //    if (deliveryfee > 0)
        //        DeliveryFee = deliveryfee ;
        //}
        //public void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking code : {TrackingCode} \n descraption : {Description} \n weight : {Weight}\n deliveryfee : {DeliveryFee}\n {Destination}");
        //}
        #endregion

    }
}
