var builder = WebApplication.CreateBuilder(args);

// Усі сесії працюють поверх об'єкта IDistributedCache, і ASP.NET Core 
// надає вбудовану реалізацію IDistributedCache
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10); // Тривалість сеансу (тайм-аут завершення сеансу)
    options.Cookie.Name = "Session"; // Кожна сесія має свій ідентифікатор, який зберігається в кукі.
});

// Додаємо сервіси Razor Pages до контейнера
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseSession(); // Додаємо middleware-компонент для роботи із сесіями

app.MapRazorPages();

app.Run();