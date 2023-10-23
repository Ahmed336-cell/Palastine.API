using Firebase.Database;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Palastine.API.Interfaces;
using Palastine.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<FirebaseClient>(_ => new FirebaseClient("https://palastine-232d9-default-rtdb.firebaseio.com/"));

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();


var app = builder.Build();

AppOptions ao = new AppOptions();
ao.Credential = GoogleCredential.FromFile("palastineKey.json");
FirebaseApp.Create(ao);



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
