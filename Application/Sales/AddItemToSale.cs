using DeveloperCleanStoreSales.Domain;
using DeveloperCleanStoreSales.Domain.Repositories;

namespace DeveloperCleanStoreSales.Application.Sales;

public sealed class AddItemToSale
{
    private readonly ISaleRepository _repo;
    public AddItemToSale(ISaleRepository repo) => _repo = repo;

    public async Task Handle(Guid saleId, string description, int quantity, decimal unitPrice, CancellationToken ct = default)
    {
        var sale = await _repo.GetByIdAsync(saleId, ct)
            ?? throw new DomainException("Sale not found.");

        sale.AddItem(description, quantity, unitPrice);
        await _repo.UpdateAsync(sale, ct);
    }
}
