---
title: БМИ
timelimit: 1.0 # u sekundama
memlimit: 64   # u MB
owner:   MalisaRadosavljevic  # vlasnik je onaj ko radi na zadatku
origin:    # može ostati prazno, koristi se kada postoji potreba navodjena izvora
tags: []   # svaki zadatak treba ra je označen tagovima prema dogovorenoj listi tagova
status: IZRADA   # jedan od: "IZRADA", "PREGLED", "KANDIDAT" ili "KOMPLETAN".
status-od:    # datum u formatu YYYY-MM-DD od kada je u navedenom statusu
solutions:
  - name: ex0
    lang: [cpp, cs]
    desc: ""
    tags: []
---
Индекс телесне масе (BMI) одређује ухрањеност појединца старијег од $$20$$ година. Одредити колико је BMI човека тежине $$k$$ $$(kg)$$ и висине $$h$$ $$(m)$$. Написати програм који ако је BMI $$<18.5$$ исписује „НЕУХРАЊЕНОСТ“, ако је $$18.5 \le BMI <30$$ исписује „ИДЕАЛА МАСА“ а ако је $$30\le BMI$$ исписује „ГОЈАЗНОСТ“.
Напомена: $$BMI$$ се рачуна по формули $$BMI= \frac{k}{h^2}$$.


## Улаз


У првој линији стандардног улаза уноси се реалан број $$k$$ који представља тежину особе у $$kg$$, а у следећој линији реалан број $$h$$  који представља висину особе у $$m$$.

## Излаз

На стандардни излаз исписати поруку „НЕУХРАЊЕНОСТ“,„ИДЕАЛА МАСА“ или „ГОЈАЗНОСТ“.

## Пример

### Улаз

~~~
83.5
1.87
~~~

### Излаз

~~~
ИДЕАЛА МАСА
~~~


