using DeveloperCleanStoreSales.Domain;
using DeveloperCleanStoreSales.Domain.Repositories;

namespace DeveloperCleanStoreSales.Infrastructure.InMemory;

public sealed class InMemorySaleRepository : ISaleRepository
{
    private readonly Dictionary<Guid, Sale> _db = new();

    public Task<Sale?> GetByIdAsync(Guid id, CancellationToken ct = default)
        => Task.FromResult(_db.TryGetValue(id, out var sale) ? sale : null);

    public Task AddAsync(Sale sale, CancellationToken ct = default)
    {
        _db.Add(sale.Id, sale);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Sale sale, CancellationToken ct = default)
    {
        _db[sale.Id] = sale;
        return Task.CompletedTask;
    }
}
