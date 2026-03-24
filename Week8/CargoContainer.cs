namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double result = 0;
        foreach (T item in _items)
        {
            result += item.CalculateCost();
        }

        return result;
    }
}