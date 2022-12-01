using DataAccess.DbAccess;
using MinimalAPI_SP.EndPoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IClienteData, ClienteData>();
builder.Services.AddSingleton<IServicoData, ServicoData>();
builder.Services.AddSingleton<IItemData, ItemData>();
builder.Services.AddSingleton<IChaleData, ChaleData>();
builder.Services.AddSingleton<IChaleItemData, ChaleItemData>();
builder.Services.AddSingleton<IHospedagemData, HospedagemData>();
builder.Services.AddSingleton<IHospedagemServicoData, HospedagemServicoData>();
builder.Services.AddSingleton<ITelefoneData, TelefoneData>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureClienteApi();
app.ConfigureChaleApi();
app.ConfigureItemApi();
app.ConfigureServicoApi();
app.ConfigureChaleItemApi();
app.ConfigureTelefoneApi();
app.ConfigureHospedagemApi();
app.ConfigureHospedagemServicoApi();

app.Run();
