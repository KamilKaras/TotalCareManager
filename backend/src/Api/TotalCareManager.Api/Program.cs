using MediatR.NotificationPublishers;
using TotalCareManager.Shared.DbAccess;
using UserAccess.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddMediatR(cfg =>
{
    cfg
    .RegisterServicesFromAssemblies(
        TotalCareManager.Shared.AssemblyReference.Assembly,
        UserAccess.Aplication.AssemblyReference.Assembly,
        UserAccess.Infrastructure.AssemblyReference.Assembly
    )
    .NotificationPublisher = new TaskWhenAllPublisher();

    cfg.AddOpenBehavior(typeof(UnitOfWorkBehavior<,>));
}

);

builder.Services.AddInfrastructure(builder.Configuration);

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