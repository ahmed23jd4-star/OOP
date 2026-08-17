namespace assignmentoop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions q1
            //What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //doesn,t change because struct is value type not reference 
            //b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
            // the first the same data but the object 2 change the object 1 doesn,t change 



            //DeliveryAddres address01 = new DeliveryAddres(5, "10 bab alloq ", "cairo");
            //DeliveryAddres address02 = address01;
            //address01.GetFullAddress();
            //address02.GetFullAddress();
            //address01.city = "alex";
            //address01.buildingnumber = 50;
            //address01.GetFullAddress();
            //address02.GetFullAddress();
            #endregion
            #region Question 2
            //public struct Shipment
            //public string
            //Description; public
            //double Weight; public
            //decimal DeliveryFee;
            //a) Identify at least three problems with this design from an encapsulation perspective.
            // public struct , string , description : you must proberty to have get , set to protcted data field and maintilbalty , and validation

            //b) How can private fields and public properties improve this design?
            // by use encapsulation using proberty auto for example public string s {get ; set }  or use any property if you have validation 
            #endregion
        }
    }
}
