[← Примеры Razor Pages](/README.md)  

# Маршрутизация
📘 [Маршрутизация в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/routing?view=aspnetcore-3.1#route-template-reference)  

* **Замена маршрута:**  
Допутим вы хотите, чтобы первую часть маршрута с параметрами обрабатывала одна страница, а вторую часть - другая страница.  
Например, маршрут _catalog/{section}_ обрабатывает стандартная страница /catalog/index.cshtml, а маршрут _catalog/{section}/{item)_ обрабатывает страница /catalog/item.cshtml. Тогда, для страницы /catalog/item.cshtml вам надо переписать маршрут:
```
@page "/catalog/{section}/{item}"
```
а на странице _catalog/{section}_ предусмотреть, чтобы параметр _{section}_ не принимал значение item

Для большего контроля можно применять ограничители параметров, которве контролируют из тип.
📘  [Справочник по ограничениям маршрутов](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/routing?view=aspnetcore-3.1#route-constraint-reference)  

* **Использование дефиса в маршрутах:**  
◻ [Изменение маршрутов страницы (learnrazorpages.com)](https://www.learnrazorpages.com/advanced/route-parameter-transformers#modifying-page-routes)  
◻ [Дефисы в имени файла(stackoverflow.com)](https://stackoverflow.com/questions/53026459/add-razor-page-dialog-does-not-allow-hyphens-in-a-filename)  


* **Материалы:**  
📘 [Соглашения для маршрутов и приложений](https://docs.microsoft.com/ru-ru/aspnet/core/razor-pages/razor-pages-conventions?view=aspnetcore-3.1)  
◻ [Razor Pages Routing (learnrazorpages.com)](https://www.learnrazorpages.com/razor-pages/routing)  
◻ [Routing in Razor Pages (mikesdotnetting.com)](https://www.mikesdotnetting.com/article/310/routing-in-razor-pages)   
◻ [Необязательные параметры в маршрутизации (mikesdotnetting.com)](https://www.mikesdotnetting.com/article/339/optional-parameters-in-razor-pages-routing)  
◻ [How to Use Routing in ASP.NET Core 3.0 Razor Pages (exceptionnotfound.net)](https://exceptionnotfound.net/how-to-use-routing-in-asp-net-core-3-0-razor-pages/)  

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
