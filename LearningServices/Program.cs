using LearningServicesClassLib;
using ServiceContracts;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    WebRootPath = "~/wwwroot"
});
builder.Services.AddControllersWithViews();
builder.Services.Add(new ServiceDescriptor(
    typeof(ICitiesService),
    typeof(CitiesService),
    ServiceLifetime.Transient
));

var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();
app.UseRouting();

app.Run();