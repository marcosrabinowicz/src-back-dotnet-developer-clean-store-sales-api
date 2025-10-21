using System;
using DeveloperCleanStoreSales.Domain;

Console.WriteLine("=== Store Sales API - Clean Architecture Study ===");

var sale = new Sale("S001", DateTime.Now);
sale.AddItem("Produto A", 2, 100m);
sale.AddItem("Produto B", 5, 50m);

Console.WriteLine($"Sale Number: {sale.SaleNumber}");
Console.WriteLine($"Total: {sale.Total:C}");
