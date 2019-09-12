---
title: Спавање
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

Мики свако поподне спава $$2$$ сата и $$15$$ минута. Написати програм који за унето време када је Мики заспао $$h$$:$$m$$ и време када се пробудио $$hh$$:$$mm$$ проверава да ли је тог дана Мики довољно спавао.


## Улаз

Са стандардног улаза се уносе четири цела броја у засебним редовима:
 * $$h$$ сати када је заспао $$(0≤h<24)$$
 * $$m$$ минути када је заспао $$(0≤m<60)$$
 * $$hh$$ сати када се пробудио $$(0≤hh<24)$$
 * $$mm$$ минути када се пробудио $$(0≤mm<60)$$

## Излаз

На стандардни излаз исписати поруку да ли је Мики довољно спавао.

## Пример

### Улаз

~~~
14
30
16
50
~~~

### Излаз

~~~
ДОВОЉНО ЈЕ СПАВАО
~~~
### Улаз

~~~
15
14
17
10
~~~

### Излаз

~~~
НИЈЕ ДОВОЉНО СПАВАО
~~~

