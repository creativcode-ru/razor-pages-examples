[← Примеры Razor Pages](/README.md)  

# Canonical url - Канонический адрес страницы

## Удаление дубликатов Index и / (слеш)
Стадартно Razor Pages используют Index как документ по умолчанию, который не обязательно указывать в URL. Но, если вы его укажете, то откроется та же страница, и у вас возникнет дублирование страниц - когда по разным адресам открывается одна и та же страница. То же самое происходит, если указать слеш в конце url.

Чтобы предовратить это поведение, добавьте в _Startup.cs_ в метод  `Configure(IApplicationBuilder app, IWebHostEnvironment env)` перед `app.UseStaticFiles();` следующий код:
```
var rewriteOptions = new RewriteOptions()
     .AddRedirect("(.*)/$", "$1")    //убираем слеж в конце адреса
     .AddRedirect("((?i)(index))$", "/");  //убираем дубликат стартовой страницы; (?i) это ignorecase
app.UseRewriter(rewriteOptions);
```
и необходимые пространства имен `using Microsoft.AspNetCore.Rewrite;`
Запустите и протестируйте проект - страница Index не будет отображаться в url.  
📘 [Переопределения URL-адресов в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-3.1)

* **Как отвечает сервер**  
Посмотрим, что происходит на сервере, если ввести в url страницу по умолчанию, и слеш в конце. Для этого будем использовать средство диагностики броузера, открывается, если нажать F12, вкладка [Network]

<p align="center">
     <img src="img/redirect-index.jpg" width="1196" alt="">
</p>

Мы видим, что сервер пытался открыть страницу _index/_ со слешем, потом просто _index_, и только потом корневую страницу. Во время редиректов возвращается код 302, что означает, что такая страница как бы есть, но временно перемещена. Для поискового робота, это сигнал проверить позже, а не появилась ли такая страница снова.  

Становится понятно, что с этим надо что-то делать, об этом немного позднее:)

⚗ готовится:)

🔖 Пока закладки:  
📘 [Яндекс: Канонический адрес страницы](https://yandex.ru/support/webmaster/robot-workings/canonical.html)  
📘 [Google: Как консолидировать повторяющиеся URL](https://support.google.com/webmasters/answer/139066?hl=ru)  
▫ [полное руководство по использованию канонических ссылок](https://seoprofy.ua/blog/optimizaciya-sajtov/rel-canonical)  
▫ [Что такое атрибут rel=“canonical”, когда и как его использовать?](https://siteclinic.ru/blog/technical-aspects/rel-canonical/)  
▫ [Настройка canonical: что это, зачем и как](https://1ps.ru/blog/dirs/2016/nastrojka-canonical-chto-eto-zachem-i-kak/)  
▫ [Как правильно канонизировать URL в приложении ASP.NET MVC?](https://stackoverflow.com/questions/3797182/how-to-correctly-canonicalize-a-url-in-an-asp-net-mvc-application)  
▫ [Parameter Transformers для чистой генерации URL и слагов в Razor Pages или MVC](https://www.hanselman.com/blog/ASPNETCore22ParameterTransformersForCleanURLGenerationAndSlugsInRazorPagesOrMVC.aspx)  
▫ [Слеш в конце URL - Search Console Community](https://support.google.com/webmasters/thread/6582004?hl=ru)  
▫ [Что выбрать: ставить или не ставить слэш на конце URL?](https://qna.habr.com/q/5626)  
▫ [Со слешем или без него на конце – вот в чем серверный вопрос… - Школа поисковой оптимизации](http://www.seoschool.ru/search-engine-optimization-seo/to-slash-or-not-to-slash-thats-a-server-header-question.html)  
▫ [УРЛ со слешем или без - почему правильно именно так?](http://imperacms.ru/docs/seo/url-slash-or-not)  
▫ [10 советов по переписыванию URL для IIS](https://ruslany.net/2009/04/10-url-rewriting-tips-and-tricks/)   
▫ []()   
▫ []()   
