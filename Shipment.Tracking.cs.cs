using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{
    internal partial class Shipment
    {
        public virtual string GetTrackingstatue()
        {
            return "Shipment SH001 is Ready.";
        }
        public partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
        public void UpdateTrackingStatus(string newstaues)
        {
            OnTrackingStatusChanged(newstaues);
        }
    }
}
