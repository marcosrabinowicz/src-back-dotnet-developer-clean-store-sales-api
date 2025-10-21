namespace DeveloperCleanStoreSales.Domain;

public static class DiscountPolicy
{
    public static decimal GetDiscountFor(int quantity)
    {
        if (quantity < 4) return 0;
        if (quantity < 10) return 10;
        return 20;
    }
}
