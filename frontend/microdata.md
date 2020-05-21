[← Примеры Razor Pages](/README.md)  

# Микроразметка
Семантическая разметка базируется на стандарте http://schema.org/ , есть проект перевода на русский https://ruschema.org/ . Дерево всех возможных типов микроразметки https://schema.org/docs/full.html .  

Здесь важно понять, что есть два основных способы микроразметки:  
  1. внутри HTML документа, это формат  **Microdata**  
  2. в заголовке странице, в формате json, называется **JSON-LD**, и пользоваться им значительно проще.  
В этой статье рассматриваютяя примеры для JSON-LD  
Официальный сайт https://json-ld.org/  

## Семантическая разметка Яндекс   
Хотя в своей документации Яндекс https://yandex.ru/support/webmaster/supported-schemas/address-organization.html  обычно приводит примеры с разметкой **Microdata**, но он, иногда, также понимает и JSON-LD. В этом можно убедится, используя валидатор микроразметки Яндекса https://webmaster.yandex.ru/tools/microtest/ . Например проверьте в валидаторе пример из Яндекса https://yandex.ru/support/webmaster/json-ld/about.html 

## Структурированные данные Google  
Посмотреть поддерживаемые типа структурированных данных можно здесь: https://developers.google.com/search/docs/data-types/article , валидатор: https://search.google.com/structured-data/testing-tool  
