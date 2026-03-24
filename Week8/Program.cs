// See https://aka.ms/new-console-template for more information

// section 1 creating objects

namespace Week8;
internal class Program
{
    public static void Main(string[] args)
    {
        Letter letter1 = new Letter("12345667",1);
        Letter letter2 = new Letter("94534304",3);
        Parcel parcel = new Parcel("23408354", 15, "10*10*10");
        
        letter2.PrintInfo();
        Console.WriteLine();// for visible split between information
        parcel.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel);
        
        Console.WriteLine();
        Console.WriteLine($"Total cost - {myCargo.GetTotalCost()}");
    }
}