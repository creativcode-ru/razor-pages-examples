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

## Group BY
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
 
