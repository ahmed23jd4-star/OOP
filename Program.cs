namespace assignmentoop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region field
            string trackingcode;
            string descraption;
            decimal weight;
            decimal delivaryfee;
            DeliveryAddress destaintion;
            string city;
            string street;
            int buildnumber;
            decimal extrafee;
            decimal customsFee;
            string destinationCountry;
            #endregion
            
            
            #region standerd
            DeliveryCenter obj = new DeliveryCenter();
            Console.WriteLine("enter the center name");
            obj.CenterName = Console.ReadLine();
            Console.WriteLine("enter the trackingcode for standerd");
            trackingcode = Console.ReadLine();
            Console.WriteLine("enter the descraption for standerd");
            descraption = Console.ReadLine();
            Console.WriteLine("enter the weight for standerd");
            bool ispressed = decimal.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("enter the delivaryfee for standerd");
            ispressed = decimal.TryParse(Console.ReadLine(), out delivaryfee);
            Console.WriteLine("enter the city for standerd");
            city = Console.ReadLine();
            Console.WriteLine("enter the street for standerd");
            street = Console.ReadLine();
            Console.WriteLine("enter the buildnumber for standerd");
            ispressed = int.TryParse(Console.ReadLine(), out buildnumber);
            destaintion = new DeliveryAddress(city, street, buildnumber);
            StandardShipment sta01 = new StandardShipment(trackingcode,descraption,weight,delivaryfee,destaintion);
            #endregion
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"delivery center : {obj.CenterName}");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("standerd shipment\n");
            sta01.PrintShipment();
            #region ExpressShipment.
            Console.WriteLine("enter the trackingcode for ExpressShipment.");
            trackingcode = Console.ReadLine();
            Console.WriteLine("enter the descraption for ExpressShipment.");
            descraption = Console.ReadLine();
            Console.WriteLine("enter the weight for ExpressShipment.");
            ispressed = decimal.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("enter the delivaryfee for ExpressShipment.");
            ispressed = decimal.TryParse(Console.ReadLine(), out delivaryfee);
            Console.WriteLine("enter the extrafee for ExpressShipment.");
            ispressed = decimal.TryParse(Console.ReadLine(), out extrafee);
            Console.WriteLine("enter the city for ExpressShipment.");
            city = Console.ReadLine();
            Console.WriteLine("enter the street for ExpressShipment.");
            street = Console.ReadLine();
            Console.WriteLine("enter the buildnumber for ExpressShipment.");
            ispressed = int.TryParse(Console.ReadLine(), out buildnumber);
            destaintion = new DeliveryAddress(city, street, buildnumber);
            ExpressShipment exp01 = new ExpressShipment(trackingcode, descraption, weight, delivaryfee, destaintion, extrafee);
            #endregion
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("express shipment\n");
            exp01.PrintShipment();
            #region InternationalShipment
            Console.WriteLine("enter the trackingcode for InternationalShipment");
            trackingcode = Console.ReadLine();
            Console.WriteLine("enter the descraption for InternationalShipment");
            descraption = Console.ReadLine();
            Console.WriteLine("enter the destinationCountry for InternationalShipment");
            destinationCountry = Console.ReadLine();
            Console.WriteLine("enter the weight for InternationalShipment");
             ispressed = decimal.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("enter the delivaryfee for InternationalShipment");
            ispressed = decimal.TryParse(Console.ReadLine(), out delivaryfee);
            Console.WriteLine("enter the customsFee for InternationalShipment");
            ispressed = decimal.TryParse(Console.ReadLine(), out customsFee);
            Console.WriteLine("enter the city for InternationalShipment");
            city = Console.ReadLine();
            Console.WriteLine("enter the street for InternationalShipment");
            street = Console.ReadLine();
            Console.WriteLine("enter the buildnumber for InternationalShipment");
            ispressed = int.TryParse(Console.ReadLine(), out buildnumber);
            destaintion = new DeliveryAddress(city, street, buildnumber);
            InternationalShipment int01 = new InternationalShipment(trackingcode, descraption, weight, delivaryfee, destaintion, destinationCountry, customsFee);
            #endregion
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("internatinal shipment\n");
            int01.PrintShipment();
            Console.WriteLine("--------------------------------------------------------------------------------");
            obj[0] = sta01;
            obj[1] = exp01;
            obj[2] = int01;
            Console.WriteLine("search name");
             trackingcode = Console.ReadLine();
            Shipment search = obj[trackingcode];
            if (search != null)
            {
                Console.WriteLine("the shipment of search ");
                search.PrintShipment();
            }
            Console.WriteLine("remove tracking name");
            trackingcode = Console.ReadLine();
            bool resu = obj.RemoveShipment(trackingcode);
            if (resu)
            {
                Console.WriteLine("shioment removed succesfully");
            }
            else
                Console.WriteLine("shioment didn,t remov succesfully");
            obj.PrintAllShipmentsremain();
        }
    }
}
