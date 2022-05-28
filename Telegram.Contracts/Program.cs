using Telegram.Contracts.Extensions;
using Telegram.Contracts.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.RegisterSettings(builder.Configuration);
builder.Services.RegisterTelegramApiClient(builder.Configuration, new TelegramClientSettings());

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
