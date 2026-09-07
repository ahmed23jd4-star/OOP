namespace assignmentoop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 01 — Theoretical Questions

            //            Abstraction
            //a)  What is Abstraction in Object - Oriented Programming?
            //b)  Why is abstraction considered one of the four pillars of OOP ?

            // هو عباره عن استخدام لكود بدون الاهتمام بتفاصيله وازاي اتعمل 
            //  اقدر اني اتعامل مع استخدام الحاجه من غير ما اهتم بتفاصيل هو اتبني ازاي فيساعدني استخدم الاوبجكت علي طول
            //اقدر لو حبيت اعدل علي حاجه فبعدل عليها من غير ما الاستخدام يتغير بعدل في ورا الكود 
            // اقدر استخدم interface  واقلل الاخطاء ان اي حد هيمضي العفد ده فلازم يكون عنده شويه حاجات لازم يعملها فهقلل احتماليه اني انسي حاجه متتعملش 


//            Abstract Classes vs.Interfaces
//a)  What is the difference between an Abstract Class and an Interface?
//b)  When would you choose an Interface instead of an Abstract Class?
//c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            // الابستراكت كلاس في ميزه اني بشارك الداتا زي  field and constroctur  فلو في علاقه بين الكلاسات الافضل ابستراكت كلاس
            // اقدر استخدم كذا implment multible  interface   بيديك ميزه انك لو عايز تحقق 
            //  لو محتاج اعمل شير للداتا او في علاقه بين كلاسين يبقي ابستراكت كلاس مناسب    لو هحتاج اعمل امبلمينت لكذا انترفيس فالاحسن وقتها استخدم الانترفيس
            // لا الكلاس اخره يرث ابستراكت كلاس بس     اما الانترفيس فهي من ضمن ميزاه التعدد لكذا امبلمينت
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
            obj.PrintAllShipments();
            obj.PrintTrackingStatuses();
            obj.printInsurable();
            Itrackable[] array00 = { sta01, exp01, int01 };
            Ilnsurable[] array001 = { sta01, exp01, int01 };
            foreach (var item in array00)
            {
                Console.WriteLine(item.GetTrackingstatue());
            }
            foreach (var item in array001)
            {
                Console.WriteLine(item.Calculatelnsurable());
            }
        }
    }
}
