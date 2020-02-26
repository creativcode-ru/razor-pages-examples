[← Примеры Razor Pages](/README.md)  

# [Учебник. Создание веб-приложения Razor Pages ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/?view=aspnetcore-3.1)  
[Создание проекта](https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-3.1&tabs=visual-studio#create-a-razor-pages-web-app). Приложение сконфинурировано для HTTPS.  

<p align="center">
   <a  href="https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-3.1&tabs=visual-studio" target="_blank" >
  <img src="https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/razor-pages-start/_static/home2.2.png?view=aspnetcore-3.1" width="400" alt="">
   </a>
</p>

Дополнительныe сведения по файлам проекта:  
📘 [Макет в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/mvc/views/layout?view=aspnetcore-3.1)  
Мастер страница _Pages/Shared/__Layout.cshtml_. Разделы `@RenderSection("Scripts", required: false)`, IgnoreBody и IgnoreSection. Импорт общих директив, файл _ViewImports.cshtml_  
📘 [Статические файлы в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/static-files?view=aspnetcore-3.1)  
Статические файлы, включая расположенные в wwwroot, находятся в открытом доступе. Просмотр каталогов по умолчанию отключен. [Докумены по умолчанию](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/static-files?view=aspnetcore-3.1#serve-a-default-document). [Регистрация MIME типов файлов](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/static-files?view=aspnetcore-3.1#fileextensioncontenttypeprovider)  
📘 [Конфигурация в .NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/configuration/index?view=aspnetcore-3.1)  
📘 [Запуск приложения в ASP.NET Core, Класс Startup](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/startup?view=aspnetcore-3.1)  

## [Добавление модели](https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-3.1&tabs=visual-studio)  
Для примера используется SQLite, если вы хотите работать с полноценной SQL, посмотрите учебник [EF-Core](https://github.com/creativcode-ru/EF-Core).
* [Создание шаблонного элемента]() при первом запуске шаблона формируется:  
• добавляются необходимые пространства имен.  
• добавляется строка подключения в файл _appsettings.json_  
• добавляется файл контекста _Data/RazorPagesMovieContext.cs_  
• регистрируется контекст с помощью внедрения зависимостей в файле _Startup.cs_ 
Практически сделано всё для подключения базы данных к проекту. Далее шаблон формирует стандартные файлы для CRUD операций.  
⚠ Здесь есть недочёт: в каждом шаблоне операций и связанным с ним файлом надо уточнить пространство имен - должно содержать полный путь к папке класса `namespace RazorPagesMovie.Pages.Movies`  

* [Первоначальная миграция](https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-3.1&tabs=visual-studio#initial-migration)  
Для миграций используется Консоль диспечера пакетов (PMC). Команда `Add-Migration InitialCreate` создает миграцию в виде набора файлов в папке _Migrations_. Здесь можно посмотреть, какие действия будут произведены с БД, и при необходимости подправить.  
Команда `Update-Database` - создает базу данных.  

Дополнительныe сведения:  
📘 [Пространство имен DataAnnotations](https://docs.microsoft.com/ru-ru/dotnet/api/system.componentmodel.dataannotations?view=netframework-4.8)  
📘 [DbContext Class](https://docs.microsoft.com/ru-ru/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-3.1)  
📘 [DbSet<TEntity> Class](https://docs.microsoft.com/ru-ru/dotnet/api/microsoft.entityframeworkcore.dbset-1?view=efcore-3.1)  
📘 [DbContextOptions Class](https://docs.microsoft.com/ru-ru/dotnet/api/microsoft.entityframeworkcore.dbcontextoptions?view=efcore-3.1) 

## [Формирование шаблонов](https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/page?view=aspnetcore-3.1&tabs=visual-studio)
Используя внедрение зависимостей, конструктор добавляет на страницу RazorPagesMovieContext. 

Дополнительныe сведения:  
📘 [Синтаксис Razor](https://docs.microsoft.com/ru-ru/aspnet/core/mvc/views/razor?view=aspnetcore-3.1#razor-syntax)  
📘 [Основные сведения о вспомогательных возможностях HTML](https://docs.microsoft.com/ru-ru/aspnet/mvc/overview/older-versions-1/views/creating-custom-html-helpers-cs#understanding-html-helpers)  
📘 [Вспомогательные функции тегов в ASP.NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-3.1)  

## [Работа с базой данных](https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/sql?view=aspnetcore-3.1&tabs=visual-studio)  

Дополнительныe сведения:  
📘 [Конфигурация в .NET Core](https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/configuration/index?view=aspnetcore-3.1)  

## Обновление страниц
⚗ Готовится:  
📘 []()  
