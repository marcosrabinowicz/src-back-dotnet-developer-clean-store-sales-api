namespace DeveloperCleanStoreSales.Domain;

public class Sale
{
    public string SaleNumber { get; }
    public DateTime Date { get; }
    private readonly List<SaleItem> _items = new();

    public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();

    public Sale(string saleNumber, DateTime date)
    {
        SaleNumber = saleNumber;
        Date = date;
    }

    public void AddItem(string description, int quantity, decimal unitPrice)
    {
        var item = new SaleItem(description, quantity, unitPrice);
        _items.Add(item);
    }

    public decimal Total => _items.Sum(i => i.Total);
}
