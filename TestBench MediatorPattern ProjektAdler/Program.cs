var builder = WebApplication.CreateBuilder(args);

var defBuilder = Host.CreateDefaultBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Mediatr dependency injection
defBuilder.ConfigureServices((hostContext, services) =>
{
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator.BaseMediator>());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
