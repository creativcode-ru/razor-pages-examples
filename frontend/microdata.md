[← Примеры Razor Pages](/README.md)  

# Микроразметка
Семантическая разметка базируется на стандарте http://schema.org/ , есть проект перевода на русский https://ruschema.org/ . Дерево всех возможных типов микроразметки https://schema.org/docs/full.html .  

Здесь важно понять, что есть два основных способы микроразметки:  
  1. внутри HTML документа, это формат  **Microdata**  
  2. в заголовке странице, в формате json, называется **JSON-LD**, и пользоваться им значительно проще.  
В этой статье рассматриваютяя примеры для JSON-LD  
Официальный сайт https://json-ld.org/  

## Семантическая разметка Яндекс   
Хотя в своей документации Яндекс https://yandex.ru/support/webmaster/supported-schemas/address-organization.html  обычно приводит примеры с разметкой **Microdata**, но он, иногда, также понимает и JSON-LD. В этом можно убедится, используя **валидатор микроразметки** Яндекса https://webmaster.yandex.ru/tools/microtest/ . Например проверьте в валидаторе пример из Яндекса https://yandex.ru/support/webmaster/json-ld/about.html 

## Структурированные данные Google  
Посмотреть поддерживаемые типа структурированных данных можно здесь: https://developers.google.com/search/docs/data-types/article , **валидатор**: https://search.google.com/structured-data/testing-tool (устарел), **Проверка расширенных результатов**: https://search.google.com/test/rich-results   

<br /><br />
<p align="center">
  Практические консультации вы можете получить на наших <a  href="http://creativcode.ru/learn" target="_blank" >веб курсах в Сочи, Адлер</a>:<br /><br />
   <a  href="http://creativcode.ru/learn/webnet" target="_blank" title="Курс веб программирования .Net C#" >
  <img src="http://creativcode.ru/img/learn/net-frontend.jpg" width="400" alt="">
   </a>
</p>
