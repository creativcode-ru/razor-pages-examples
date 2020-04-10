.[← Примеры Razor Pages](/README.md)  

# Кеширование  
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
📘 [Кэширование ответов в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/performance/caching/response?view=aspnetcore-3.1)  

◻ [Кэширование с помощью MemoryCache (metanit.com)](https://metanit.com/sharp/aspnet5/14.1.php)  

⚗ ...
