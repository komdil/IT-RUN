// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using MyWarehouse;
using MyWarehouse.Repositories;
using MyWarehouse.Repositories.Abstractions;
using MyWarehouse.Strategies;
using MyWarehouse.Strategies.Abstractions;

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IProductRepository, ProductRepository>();
serviceCollection.AddSingleton<ICommandLineStrategyResolver, CommandLineStrategyResolver>();

serviceCollection.AddSingleton<ICommandLineStrategy, GetProductsStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, AddProductStrategy>();
serviceCollection.AddSingleton<ICommandLineStrategy, SellProductStrategy>();

serviceCollection.AddSingleton<Application>();
var provider = serviceCollection.BuildServiceProvider();
Application application = provider.GetRequiredService<Application>();
application.Start();
