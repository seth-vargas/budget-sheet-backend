using BudgetSheetApi.Data;
using BudgetSheetApi.Middleware;
using BudgetSheetApi.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging();

// Add services to the container.
builder.Services.AddScoped<ILoggerService, LoggerService>();
builder.Services.AddScoped<IErrorHandlerService, ErrorHandlerService>();

builder.Services.AddScoped<IFrostTransactionService, FrostTransactionService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddControllers();

builder.Services.AddDbContext<BudgetSheetContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
