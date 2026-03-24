namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; }
    private const int StartingPrice = 50;
    private const int PriceForKilogram = 25;

    public Parcel(string trackingNumber, int weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return StartingPrice + Weight * PriceForKilogram;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions - {Dimensions}");
    }
}