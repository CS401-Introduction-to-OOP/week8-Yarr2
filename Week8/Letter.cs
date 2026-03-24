namespace Week8;

public class Letter : DeliveryItem
{
    private const int StartingPrice = 15;
    private const int AddedValueForKilogram = 10;
    public Letter(string trackingNumber, int weight) : base(trackingNumber, weight)
    { }

    public override double CalculateCost()
    {
        return StartingPrice + Weight * AddedValueForKilogram;
    }
}