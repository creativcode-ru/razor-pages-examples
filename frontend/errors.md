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
◻ [Настройка пользовательской страницы ошибок на веб-сайте (learnrazorpages.com)](https://www.learnrazorpages.com/configuration/custom-errors)  
