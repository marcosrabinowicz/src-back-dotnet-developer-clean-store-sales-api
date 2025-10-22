using DeveloperCleanStoreSales.Application.Sales;
using DeveloperCleanStoreSales.Infrastructure.InMemory;

Console.WriteLine("=== Store Sales API - Clean Architecture Study (Step 2) ===");

var repo = new InMemorySaleRepository();
var createSale = new CreateSale(repo);
var addItem = new AddItemToSale(repo);

var sale = await createSale.Handle("S001", DateTime.Now);
await addItem.Handle(sale.Id, "Produto A", 2, 100m);
await addItem.Handle(sale.Id, "Produto B", 5, 50m);

Console.WriteLine($"Sale Number: {sale.SaleNumber}");
Console.WriteLine($"Total: {sale.Total:C}");
