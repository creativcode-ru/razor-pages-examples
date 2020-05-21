[← Примеры Razor Pages](/README.md)  

# Разметка для социальных сетей Open Graph

Когда вы публикуете ссылку на страницу в социальной сети или передаете по вацапу, вы можете увидеть картинку и кратное описание страницы. 
Это делается с помощью протокола Open Graph: на русском https://ruogp.me/ 

## og разметка с большой картинкой
Большая картинка хорошо смотрится в Твиторе и Фейсбуке. Для Вацапа из этой картинки будет вырезана квадратная область в центре, учитывайте это при дузайне.
Файлы используйте только .jpg, которые обеспечивают оптимальное сжатие картинки и небольшой размер файла. Оптимальный размер картинки 1200x628. Стандартный код:
```
<meta name="description" content="Обычный метатег описания, он же будет использован для социальных сетей" />
<meta property="og:title" content="Продублируйте здесь метатег title заголовка страницы">
<meta property="og:image" content="http://site.ru/img/og/site1200x628.jpg">
<meta property="og:image:width" content="1200">
<meta property="og:image:height" content="628">
<meta property="og:type" content="website" />
<meta property="og:url" content="http://site.ru">
<meta name="twitter:card" content="summary_large_image">
<link rel="image_src" href="/img/og/topfirm1200x628.jpg" />
```

## og разметка с маленькой картинкой
Для маленькой картинки можно взять, например, стандартый логотип сайта и использовать его для нескольких страниц:
```
<meta name="description" content="Обычный метатег описания, он же будет использован для социальных сетей" />
<meta property="og:title" content="Продублируйте здесь метатег title заголовка страницы">
<meta property="og:image" content="http://site.ru/img/og/logo200x200.jpg">
<meta property="og:image:width" content="200">
<meta property="og:image:height" content="200">
<meta property="og:type" content="website" />
<meta property="og:url" content="http://site.ru">
<meta name="twitter:card" content="summary">
```
⚙ Пишут, что минимальный размер картинки 120x120, но Фейсбук не поддерживает картинки менее 200x200. Пока не тестировал.

Ссылки: 
* https://www.pandoge.com/stati-i-sovety/mikrorazmetka-open-graph-dlya-twitter  
* https://developer.twitter.com/en/docs/tweets/optimize-with-cards/guides/getting-started  
* https://developers.facebook.com/docs/sharing/webmasters  

(⚗) 

