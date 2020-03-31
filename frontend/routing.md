[← Примеры Razor Pages](/README.md)  

# Маршрутизация
📘 [Соглашения для маршрутов и приложений Razor Pages в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/razor-pages/razor-pages-conventions?view=aspnetcore-3.1)

# Перенаправление
В зависмости от параметров, вернуть страницу, или сделать, например редирект:
```
        public IActionResult OnGet(string section)
        {
            if (string.IsNullOrEmpty(section))
            {
                return LocalRedirectPermanent("/"); 
            }

            return Page();
        }
```
🟢 [Возвращение результата в Razor Pages](https://metanit.com/sharp/aspnet5/29.7.php)  
 ◻ [Результаты действий в Razor Pages](https://www.learnrazorpages.com/razor-pages/action-results)  
