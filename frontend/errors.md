[← Примеры Razor Pages](/README.md)  

# Обработка ошибок  

В встандартный проект уже включена обработка ошибок, для этого в файле Startup.cs включен код:
```
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}
```
Этот код означает, что при разработке будет выдаваться подробная страница с описанием ошибки, а в режиме публикации, будет показываться ваша страница _/Pages/Error.cshtml_. Первое, что стоит сделать, это оформить данную страницу надлежащим образом, и убедится, что мастер страница Layout.cshtml никак не может являтся источником ошибок.  
Для тестирования, оствьте только одну строку кода `app.UseExceptionHandler("/Error");`, а в тестовой странице вызовите исключение 
```
public void OnGet()
{
    throw new Exception("Тестирвание страницы ошибки");
}
```

◻ [Глобальная обработка ошибок (learnrazorpages.com)](https://www.learnrazorpages.com/configuration/global-error-handling)  
📘 [Обработка ошибок в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/error-handling?view=aspnetcore-3.1)  

# Страница 404  
Можно сделать собственную страницу 404, для отображения информации о страницах, которых нет на сайте.  
В папке Pages, создайте папку *Errors*, а в ней создайте страницу _404.cshtml_. При этом будет создан файл с подчеркиванием спереди *_404.cshtml*, переименуйте его, но имя класса страницы пусть останется  `public class _404Model : PageModel`, поскольку имя класса не может начинаться с цифры.
 Далее  в файле Startup.cs в метод *Configure* вставьте вызов:
```
app.UseStatusCodePagesWithReExecute("/errors/{0}");
```
а для тестирования используйте вызов:
```
 public IActionResult OnGet()
{
        return NotFound();
}
```
**HTML Код** простейшей страницы 404.cshtml:
```
@page
@model _имя_вашего_проекта.Pages.Errors._404Model

<div class="page c-white m3">
    <h1>404</h1>
    <p class="mt2 c-blue">Данная страница не существует<br />Проверьте адрес страницы:</p>
    <p class="h3">@Model.OriginalURL</p>
</div>
```
**С# код:**
```
   public class _404Model : PageModel
    {
        public string OriginalURL { get; set; }
        public void OnGet()
        {
            var statusCode = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            if (statusCode != null)
            {
                OriginalURL =
                    statusCode.OriginalPathBase
                    + statusCode.OriginalPath
                    + statusCode.OriginalQueryString;
            }
        }
    }
```

◻ [Настройка пользовательской страницы ошибок на веб-сайте (learnrazorpages.com)](https://www.learnrazorpages.com/configuration/custom-errors)  
