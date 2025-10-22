namespace DeveloperCleanStoreSales.Domain.Repositories;

public interface ISaleRepository
{
    Task<Sale?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task AddAsync(Sale sale, CancellationToken ct = default);
    Task UpdateAsync(Sale sale, CancellationToken ct = default);
}
