.[← Примеры Razor Pages](/README.md)  

# Кеширование  
Для чатичнных представлений, которые используются насколько раз на странице с разными данными, можно использовать кеширование `vary-by` с параметром:
```
<cache vary-by="@Model.Id">@DateTime.Now</cache>
```
◻ [Cache Tag Helper (learnrazorpages.com)](https://www.learnrazorpages.com/razor-pages/tag-helpers/cache-tag-helper)  

⚗ ...
