namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber;
    public int Weight;// weight in kilograms

    public DeliveryItem(string trackingNumber, int weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }
    
    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Item with tracking number - {TrackingNumber} and weight - {Weight}");
    }
}