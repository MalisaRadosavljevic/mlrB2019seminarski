---
title: Ваљак
timelimit: 1.0 # u sekundama
memlimit: 64   # u MB
owner:  MalisaRadosavljevic # vlasnik je onaj ko radi na zadatku
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


Израчунати запремину ваљка ако је познато $$r$$ (полупречник основе) и $$H$$ (висина ваљка).
Напомена: Запремина ваљка се рачуна по формули $$V=r^2H\pi$$
## Улаз

У првој линији стандардног улаза се налази реална вредност $$r$$, а у следећој линији реална вредност $$H$$.

## Излаз

На стандардни излаз исписати један реалан број који представља запремину ваљка заокружен на три децимале.

## Пример

### Улаз

~~~
5
7
~~~

### Излаз

~~~
549.779
~~~
