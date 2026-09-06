namespace assignmentoop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            //            Q1 Overloading, Overriding, and Binding
            //a) What is the difference between Method Overloading and Method Overriding?
            //b) What is the difference between Static Binding and Dynamic Binding?

            // ovverloading depend in signture method you hae same and return type but the parmter change in count or data type or order
            //ovverriding you can change bahavoir for the same method same paramer same all but different implmentaion
            //binding you depend in refernce type in compiler
            //dynamic you depend clr (real object)

//            Sealed Classes and Methods
//a) What is the purpose of the sealed keyword when applied to a class?
//b) What is the difference between a sealed class and a sealed method?
//c) Can a sealed method be overridden? Why?
        // you can,t inhearies for this class if you use sealed 
        // sealed class you can,t inherties this class any more sealed method you can,t ovveride and method hiding if you ovveride in time binding not ivverride 
        // NO but binding you can  not dynamic meaning depend in reference not object and new method bacouse if you use sealed the method is method hidding
        

            #endregion
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
            string namedriver;
            DeliveryCenter obj = new DeliveryCenter();
            #endregion
            Console.WriteLine("name driver");
            namedriver = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(namedriver))
            {
                driver d01 = new driver(namedriver);
                obj.Namedriver = d01;
            }
            #region standerd

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
         
            obj[0] = sta01;
            obj[1] = exp01;
            obj[2] = int01;
            Console.WriteLine($"driver : {obj.Namedriver}");
            obj.PrintAllShipments();
            DeliveryHelper.PrintShipmentDetails(sta01);
            DeliveryHelper.PrintShipmentDetails(exp01);
            DeliveryHelper.PrintShipmentDetails(int01);
            decimal uptadeweight;
            decimal packing;
            Console.WriteLine(" enter uptade weight for standerd");
            ispressed = decimal.TryParse(Console.ReadLine(), out uptadeweight);
            sta01.Updatesweight(uptadeweight);
            Console.WriteLine(" enter uptade weight for express");
            ispressed = decimal.TryParse(Console.ReadLine(), out uptadeweight);
            exp01.Updatesweight(uptadeweight);
            Console.WriteLine(" enter uptade weight for internatinal");
            ispressed = decimal.TryParse(Console.ReadLine(), out uptadeweight);
            int01.Updatesweight(uptadeweight);

            Console.WriteLine(" enter pacjing weight for standerd");
            ispressed = decimal.TryParse(Console.ReadLine(), out packing);
            sta01.Updatesweight(uptadeweight , packing);
            Console.WriteLine(" enter pacjing weight for exoress");
            ispressed = decimal.TryParse(Console.ReadLine(), out packing);
            exp01.Updatesweight(uptadeweight , packing);
            Console.WriteLine(" enter pacjing weight for internatinal");
            ispressed = decimal.TryParse(Console.ReadLine(), out packing);
            int01.Updatesweight(uptadeweight , packing);
            Console.WriteLine("-------------------------------------");
            Shipment[] array = [sta01, exp01, int01];
            foreach (var item in array)
            {
                item.PrintShipment();
            }
            
        }
    }
}
