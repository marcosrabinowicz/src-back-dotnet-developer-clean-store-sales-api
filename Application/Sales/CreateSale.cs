using DeveloperCleanStoreSales.Domain;
using DeveloperCleanStoreSales.Domain.Repositories;

namespace DeveloperCleanStoreSales.Application.Sales;

public sealed class CreateSale
{
    private readonly ISaleRepository _repo;
    public CreateSale(ISaleRepository repo) => _repo = repo;

    public async Task<Sale> Handle(string saleNumber, DateTime date, CancellationToken ct = default)
    {
        var sale = new Sale(saleNumber, date);
        await _repo.AddAsync(sale, ct);
        return sale;
    }
}
