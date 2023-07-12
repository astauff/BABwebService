using BABwebService.Context;
using BABwebService.Repositories.EventRepos;
using BABwebService.Services;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add contexts
builder.Services.AddSingleton<DapperContext>();

// Add service
builder.Services.AddTransient<IEventService, EventService>();

// Add repos
builder.Services.AddTransient<IEventRepo, EventRepo>();

builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger(x => x.SerializeAsV2 = true);
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

