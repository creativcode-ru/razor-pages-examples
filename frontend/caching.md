.[← Примеры Razor Pages](/README.md)  

# Кеширование  
📘 [Кэширование ответов в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/performance/caching/response?view=aspnetcore-3.1)
## Тег cache
Для чатичнных представлений, которые используются насколько раз на странице с разными данными, можно использовать кеширование `vary-by` с параметром:
```
<cache vary-by="@Model.Id">@DateTime.Now</cache>
```
Можно кешировать в зависимости от параметра маршрута или запроса. Например параметр маршрута задан на странице `@page "{section}"` тогда:
```
<cache  vary-by-route="section">@DateTime.Now</cache>
```
◻ [Cache Tag Helper (learnrazorpages.com)](https://www.learnrazorpages.com/razor-pages/tag-helpers/cache-tag-helper)  
📘 [Вспомогательная функция тегов кэша в MVC-моделях ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/mvc/views/tag-helpers/built-in/cache-tag-helper?view=aspnetcore-3.1)  

## Кеширование в памяти
Для подключения кеша в файле Startup.sc добавьте вызов `services.AddRazorPages();` в метод ConfigureServices(IServiceCollection services) первой строкой. Далее в модели страницы добавьте вызов зависимости:
```
// Кеш в памяти
private IMemoryCache _cache;
public вашаСтраницаModel(IMemoryCache memoryCache)
{
     _cache = memoryCache;
}
```
Если вы одновременно используете доступ к базе данных, то зависимость должна включать также и контекст БД:
```
/ Кеш в памяти и база данных
private IMemoryCache _cache;
private readonly вашContext _context;

public вашаСтраницаModel(IMemoryCache memoryCache, TopfirmContext context)
{
     _cache = memoryCache;
     _context = context;
}
```


📘 [Кэширование в памяти в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/performance/caching/memory?view=aspnetcore-3.1)  
◻ [Кэширование в Razor Pages (earnrazorpages.com)](https://www.learnrazorpages.com/razor-pages/caching)   
◻ [Кэширование с помощью MemoryCache (metanit.com)](https://metanit.com/sharp/aspnet5/14.1.php)  

⚗ ...
