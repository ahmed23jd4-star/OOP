namespace assignmentoop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryAddres address01 = new DeliveryAddres(5, "10 bab alloq ", "cairo");
            DeliveryAddres address02 = address01;
            address01.GetFullAddress();
            address02.GetFullAddress();
            address01.city = "alex";
            address01.buildingnumber = 50;
            address01.GetFullAddress();
            address02.GetFullAddress();
        }
    }
}
