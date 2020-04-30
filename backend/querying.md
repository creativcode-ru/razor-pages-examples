[← EF Core](/README.md)  

# Запросы в EF Core  
Пример простого запроса для чтения данных с соединением двух таблиц: 
```
return (from f in _context.Firms
             join cr in _context.CatalogRubrics on f.RubricId equals cr.RubricId
             where cr.UrlMask == rubric
                   && f.IsAllowed
             orderby f.Rank descending
             select f).Take(N).AsNoTracking().ToList();
```
Соединние таблиц выполняется аналогично SQL: `join cr in _context.CatalogRubrics on f.RubricId equals cr.RubricId`. Первые N строк выбираются оператором `Take(N)` (в SQL это top(N)). `AsNoTracking()` указывает, что для запроса для чтения данных надо отключить отслеживание изменений.  
select f - вернет данные только из одной таблицы f. Чтобы вернуть необходимые данные из обеих таблиц, надо сделать класс, который совмещает данные из этих таблиц, или, анонимно `new { f, cr }`.  

📘 [Сложные операторы запросов](https://docs.microsoft.com/ru-ru/ef/core/querying/complex-query-operators)  
◻ [Запросы в Entity Framework Core (entityframeworktutorial.net)](https://www.entityframeworktutorial.net/efcore/querying-in-ef-core.aspx)   
◻ [Linq-to-Entities Query (entityframeworktutorial.net)](https://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx) 

## EF Core GROUP BY
Пример запроса, когда используются несколько полей и создается объект заданного типа:
```
SELECT        City, UrlMask, ISO2
FROM          CatalogRubricCities
GROUP BY City, UrlMask, ISO2

private IQueryable<City> RubricCityQuery()
{
    return _context.CatalogRubricCities
           .GroupBy(o => new { o.City, o.UrlMask, o.Iso2})
           .Select(g => new City {Name = g.Key.City, UrlMask = g.Key.UrlMask, CountryCode = g.Key.Iso2});
}

//где то в программе вызов, например такой:
 cities = await RubricCityQuery().AsNoTracking().ToListAsync();
```

📘 [Преобразование оператора LINQ GroupBy](https://docs.microsoft.com/ru-ru/ef/core/what-is-new/ef-core-2.1#linq-groupby-translation)  
📘 [Сложные операторы запросов: GroupBy](https://docs.microsoft.com/ru-ru/ef/core/querying/complex-query-operators#groupby)  

## EF Core LEFT OUTER JOIN  
Когда есть основная таблица, а для некоторых записей есть сведения в связанной таблице. Но нам нужны данные для основной таблицы, даже если нет уточнений. Для этого в SQL используется оператор LEFT OUTER JOIN (левое соединение), который берет все данные из основной таблицы.  
Можно использовать `into`:
```
SELECT        f.*,fe.*
FROM          Firms AS f LEFT OUTER JOIN
                         TFirmExtensions AS fe ON f.FirmId = fe.FirmId

var q= from f in _context.Firms
       join fe in _context.TfirmExtensions on f.FirmId equals fe.FirmId
       into Details 
       from d in Details.DefaultIfEmpty()
       select new { f, d};
```
📘 [Левое соединение](https://docs.microsoft.com/ru-ru/ef/core/querying/complex-query-operators#left-join)  
◻ [EntityFramework: левое (внешнее) соединение в Linq (stackoverflow.com)](https://stackoverflow.com/questions/39919230/asp-net-core-entityframework-core-left-outer-join-in-linq)  
📘 [Селектор коллекции ссылается на внешний источник в предложении WHERE](https://docs.microsoft.com/ru-ru/ef/core/querying/complex-query-operators#collection-selector-references-outer-in-a-where-clause)    
📘 [Выполнение левых внешних соединений](https://docs.microsoft.com/ru-ru/dotnet/csharp/linq/perform-left-outer-joins)  
 
