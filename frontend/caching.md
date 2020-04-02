.[← Примеры Razor Pages](/README.md)  

# Кеширование  
Для чатичнных представлений, которые используются насколько раз на странице с разными данными, можно использовать кеширование `vary-by` с параметром:
```
<cache vary-by="@Model.Id">@DateTime.Now</cache>
```
◻ [Cache Tag Helper (learnrazorpages.com)](https://www.learnrazorpages.com/razor-pages/tag-helpers/cache-tag-helper)  
📘 [Кэширование ответов в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/performance/caching/response?view=aspnetcore-3.1)  

◻ [Кэширование с помощью MemoryCache (metanit.com)](https://metanit.com/sharp/aspnet5/14.1.php)  

⚗ ...
