namespace DeveloperCleanStoreSales.Domain;

public class SaleItem
{
    public string Description { get; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; }
    public decimal DiscountPercent { get; private set; }

    public decimal Subtotal => Quantity * UnitPrice;
    public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);
    public decimal Total => Subtotal - DiscountAmount;

    public SaleItem(string description, int quantity, decimal unitPrice)
    {
        if (quantity <= 0)
            throw new DomainException("Quantity must be greater than zero.");

        Description = description;
        Quantity = quantity;
        UnitPrice = unitPrice;
        DiscountPercent = DiscountPolicy.GetDiscountFor(quantity);
    }

    public void ChangeQuantity(int newQuantity)
    {
        if (newQuantity <= 0)
            throw new DomainException("Quantity must be greater than zero.");

        Quantity = newQuantity;
        DiscountPercent = DiscountPolicy.GetDiscountFor(newQuantity);
    }
}
