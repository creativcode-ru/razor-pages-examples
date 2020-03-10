[← Примеры Razor Pages](/README.md)  

# Информационные материалы по дизайну 
* **Системы дизайна:**

📘 Google: [Material Design System](https://material.io/design/#swipe-to-refresh-swipe-to-refresh)  
📘 Microsoft: [Fluent Design System](https://www.microsoft.com/design/fluent/#/)  
📘 Apple: [Human Interface](https://developer.apple.com/design/)  
📘 [IBM Design Language](https://www.ibm.com/design/language/)  
📘 Язык проектирования [Atlassian](https://atlassian.design/) для создания простых и красивых впечатлений.  
📘 [Polaris Shopify](https://polaris.shopify.com/)  

* **Атомарный дизайн**  

Atomic Design подробно описывает все, что входит в создание и поддержание надежных систем проектирования, позволяющих развертывать более качественные, более согласованные пользовательские интерфейсы быстрее, чем когда-либо прежде.  
Дизайн разделяется на компонерты: атомы, молекулы, организмы, шаблоны, страницы. Кадлый более мелкий компонент объединяется с подобным себе, для построения более сложного компонента - атомы дизайна объединяются в молекулы, дальше в организмы, потом в шаблоны, и наконец, после добавления реального контента, в страницы.

• **Атомы** - это элементы пользовательского интерфейса, которые нельзя разбивать дальше и которые служат элементными строительными блоками интерфейса.  
• **Молекулы** представляют собой наборы атомов, которые образуют относительно простые компоненты пользовательского интерфейса.  
• **Организмы** - это относительно сложные компоненты, которые образуют отдельные участки интерфейса. Организм - это основа для построение частичного представления.     
• **Шаблоны** размещают компоненты в макете и демонстрируют структуру содержимого, лежащую в основе дизайна. Шаблон состоит в основном из групп организмов, сшитых вместе для формирования страниц.    
• **Страницы** применяют реальный контент к шаблонам и формулируют варианты, чтобы продемонстрировать окончательный интерфейс и проверить устойчивость системы проектирования.  

📘 [Книга Atomic Design](https://atomicdesign.bradfrost.com/)  
◻ [Атомарный дизайн-методология](https://medium.muz.li/atomic-design-methodology-166261ce47c2) - краткое описание кнцепции.  
◻ [Атомарный дизайн: начало работы](https://www.wearemobilefirst.com/blog/atomic-design)  

## Цветовые палитры:  
 ◻ Цветовая палитра Google [2014 Material Design color palettes](https://material.io/design/color/the-color-system.html#tools-for-picking-colors)  
 ◻ [Adobe color](https://color.adobe.com/ru/explore)  
 ◻ [Microsoft Color palettes](https://developer.microsoft.com/en-us/fabric#/styles/web/colors/theme-slots)  
 ◻ На основе ваших любимых цветов комбинируются различные палитры [khroma.co](http://khroma.co/)  

## Детали интерфейса  
 * **Иконки**  
 ◻ Иконки Google, Андроид [Icons Material Design](https://material.io/resources/icons/?style=baseline)  
 ◻ [HTML символы](https://www.w3schools.com/charsets/ref_utf_punctuation.asp) - часто, вместо иконок достаточноиспользовать специальные символы, которые содержит стандартный шрифт. Это общая пунтуация, сиволы валют, матемаические, блоки, стрелки смайлики и т.д.  
 
 ✅ Как поменять цвет иконки SVG:  
 Если без CSS, то надо дополнить тег path кодом `style="fill:white;fill-rule:nonzero;"` - будет белый цвет. Весь код иконки:
 ```
 <svg xmlns="http://www.w3.org/2000/svg" height="24" viewBox="0 0 24 24" width="24"><path d="M0 0h24v24H0z" fill="none"/><path d="M12 8c1.1 0 2-.9 2-2s-.9-2-2-2-2 .9-2 2 .9 2 2 2zm0 2c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2zm0 6c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2z" style="fill:white;fill-rule:nonzero;"/></svg>
 ```
◻ [Изменить цвет и размер иконки SVG с помощью CSS](https://github.com/filamentgroup/grunticon/issues/235)  
 
 
 * **Картинки**  
 ◻ Удаление фона картинки [remove.bg](https://www.remove.bg/). Бесплатно и без регистрации для небольших изображений.  
 ◻ Увеличение качества изображения, из маленького можно увеличить без потери качества [letsenhance.io](https://letsenhance.io/). Требуется регистрациия.  
 
 https://imglarger.com/


 
⚗ готовится:)

