using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(o => o.ResourcesPath = "Resources");

var app = builder.Build();

app.UseHttpsRedirection();

if (app.Services.GetRequiredService<IStringLocalizer<Program>>()["TehString"] == "TehString")
{
    Console.WriteLine("Failed!");
}
