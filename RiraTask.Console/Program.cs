using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;

// Needed to use hosting and dependency injection packages for using the product service interface

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<IProductService, ProductService>();
using IHost host = builder.Build();
host.Start();


Console.WriteLine("Choose the action and enter the number: \n\n");
Console.WriteLine("\t -- 1 Select all products from Category1 \n\n" +
                  "\t -- 2 Select product with highest price \n\n" +
                  "\t -- 3 Calculate total price of all products \n\n" +
                  "\t -- 4 Order products by category \n\n" +
                  "\t -- 5 Calculate average price of products \n\n");

while (true)
{
    var input = Convert.ToInt32(Console.ReadLine());

    IProductService productService = new ProductService();

    if (input > 5 || input < 1)
    {
        throw new Exception("Input wasn't in the above list");
    }

    if (input == 1)
    {
        var items = productService.GetProductsFromCategoryOne();
        foreach (var item in items)
        {
            Console.WriteLine($" Product Id: {item.Id}, Product Name: {item.Name}, Product Category: {item.Category}, Product Price: {item.Price}");
        }
    }

    if (input == 2)
    {
        var item = productService.GetProductWithHighestValue();
        Console.WriteLine($" Product Id: {item.Id}, Product Name: {item.Name}, Product Category: {item.Category}, Product Price: {item.Price}");
    }

    if (input == 3)
    {
        var totalPrice = productService.ProductsValuesSum();
        Console.WriteLine($" Total price of products: {totalPrice}");
    }

    if (input == 4)
    {
        var items = productService.OrderProductsByCategory();
        foreach (var item in items)
        {
            Console.WriteLine($" Product Id: {item.Id}, Product Name: {item.Name}, Product Category: {item.Category}, Product Price: {item.Price}");
        }
    }

    if (input == 5)
    {
        var averagePrice = productService.ProductsAverageValue();
        Console.WriteLine($" Average price of products: {averagePrice}");
    }

    Console.WriteLine("\n\t -- Wanna try another one? Type yes: ");
    var answer = Console.ReadLine().ToLower();
    if (answer != "yes")
    {
        Console.WriteLine("Thanks for your time!");
        break;
    }
    // This one is just to make a space 
    Console.WriteLine();
}
