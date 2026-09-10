using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace assignmentoop02
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | shipment type :{shipment.ToString()} | wight :{shipment.Weight}| {shipment.GetTrackingstatue()}";
        }
        public static  bool IsDelivered(this Shipment shipment)
        {
             
            if(shipment.GetTrackingstatue() == "Shipment SH003 has been Delivered")
            {
                return true;
            }

            return false;
        }
    }
}
