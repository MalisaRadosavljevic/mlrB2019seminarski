---
title: Интервал
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

Написати програм који од унетих $$n$$ реалних бројева (који су различити од $$0$$ ) исписује производ само оних бројева који припадају интервалу $$[a,b]$$. Уколико се ниједан број не налази у датом интервалу исписати поруку "НЕМА БРОЈЕВА У ДАТОМ ИНТЕРВАЛУ".


## Улаз


Са стандардног улаза се уносе три цела броја у засебним редовима:
 * $$n$$  $$(1 \le n)$$
 * $$a$$ почетак интервала
 * $$b$$ крај интервала
Након тога се уноси још $$n$$ реалних бројева у засебним редовима.
## Излаз

На стандардни излаз исписати реалан број заокружен на три децимале који представља тражени производ или одговарајућу поруку.

## Пример

### Улаз

~~~
5
-3
2
-4.2
1.5
10
-0.8
2
~~~

### Излаз

~~~
-2.400
~~~
### Улаз

~~~
3
2
5
-1
11
1.5
~~~

### Излаз

~~~
НЕМА БРОЈЕВА У ДАТОМ ИНТЕРВАЛУ
~~~