using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentoop02
{//djkls
    internal class DeliveryCenter
    {
        string centerName;
        public string CenterName { get=>centerName; set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    centerName = value;
            }
        }
        private Shipment[] Shipments = new Shipment[20];
        public Shipment  this[int indexer]
        {
            get {
                if (indexer >= 0 && indexer < Shipments.Length)
                {
                    return Shipments[indexer];
                }
                else
                    return default;
                   
            }
            set
            {
                if (indexer >= 0 && indexer < Shipments.Length)
                {
                    Shipments[indexer] = value;
                }

            }
        }
        public Shipment this[string name]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    return default;
                }
                for(int i =0; i< Shipments.Length; i++)
                {
                    if (Shipments[i] != null && Shipments[i].TrackingCode == name)
                        return Shipments[i];
                }
                return default;
            }
  
        }
        public bool AddShipment(Shipment sh)
        {
            for(int i =0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = sh;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;
            for(int i =0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null && Shipments[i].TrackingCode == name)
                { Shipments[i] = null ;
                        return true;
                        }

            }
            return false;
        }
        //public void PrintAllShipments()
        //{
        //    for(int i = 0; i < Shipments.Length; i++)
        //    {

        //    Console.WriteLine($"shipments {i} is");
        //        Shipments[i].PrintShipment();
        //    }
        //}

        public void PrintAllShipmentsremain()
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                    continue;

                Console.WriteLine($"shipments {i} is");
                Shipments[i].PrintShipment();
            }
        }
    }
}
