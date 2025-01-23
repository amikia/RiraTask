using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddControllers();
builder.Services.AddMvc();

var app = builder.Build();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Product}/{action=Index}"
    );

app.Run();
