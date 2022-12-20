using CurrencyAPI;
using Microsoft.AspNetCore.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICurrencyService, ParserCurrencyService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(c => c.Run(async context =>
{
    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
    var exception = exceptionHandlerPathFeature!.Error;
    var response = new { error = exception?.Message };
    await context!.Response.WriteAsJsonAsync(response);
}));
//app.UseRouting();


//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler(exceptionHandlerApp =>
//    {
//        exceptionHandlerApp.Run(async context =>
//        {
//            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
//            // using static System.Net.Mime.MediaTypeNames;
//            context.Response.ContentType = Text.Plain;
//            await context.Response.WriteAsync("An exception was thrown.");
//            var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
//            if (exceptionHandlerPathFeature?.Error is FileNotFoundException)
//            {
//                await context.Response.WriteAsync(" The file was not found.");
//            }
//            if (exceptionHandlerPathFeature?.Path == "/")
//            {
//                await context.Response.WriteAsync(" Page: Home.");
//            }
//        });
//    });
//}

app.MapControllers();

app.Run();
