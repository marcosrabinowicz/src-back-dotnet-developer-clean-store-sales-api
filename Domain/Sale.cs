using System.Linq;

namespace DeveloperCleanStoreSales.Domain;

public class Sale
{
    public Guid Id { get; } = Guid.NewGuid();
    public string SaleNumber { get; }
    public DateTime Date { get; }
    private readonly List<SaleItem> _items = new();

    public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();

    public Sale(string saleNumber, DateTime date)
    {
        SaleNumber = string.IsNullOrWhiteSpace(saleNumber)
            ? throw new DomainException("Sale number is required.")
            : saleNumber;

        Date = date;
    }

    public void AddItem(string description, int quantity, decimal unitPrice)
        => _items.Add(new SaleItem(description, quantity, unitPrice));

    public decimal Total => _items.Sum(i => i.Total);
}
