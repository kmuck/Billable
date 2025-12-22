using Microsoft.EntityFrameworkCore;

using Billable.Services.Identity.Data;
using Billable.Services.Identity.Models;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDbContext>(o => 
    o.UseNpgsql(builder.Configuration.GetConnectionString("identity-db")));

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGet("/ping", () => "pong");

if (app.Environment.IsDevelopment())
    app.MapOpenApi();

app.Run();
