[← Примеры Razor Pages](/README.md)  

# Маршрутизация

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
