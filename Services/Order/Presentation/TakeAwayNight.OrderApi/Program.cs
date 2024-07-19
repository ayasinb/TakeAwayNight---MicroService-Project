using TakeAwayNight.Application.Features.CQRS.Handlers.AdressHandlers;
using TakeAwayNight.Application.Interfaces;
using TakeAwayNight.Persistence.Context;
using TakeAwayNight.Persistence.Repostories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<OrderContext>();

builder.Services.AddScoped<GetAdressQueryHandler>();
builder.Services.AddScoped<GetAdressByIdQueryHandler>();
builder.Services.AddScoped<CreateAdressCommandHandler>();
builder.Services.AddScoped<UpdateAdressCommandHandler>();
builder.Services.AddScoped<RemoveAdressCommandHandler>();


builder.Services.AddScoped(typeof(IRepostory<>), typeof(Repostory<>));

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();
