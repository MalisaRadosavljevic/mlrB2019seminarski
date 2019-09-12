---
title: Најбоље време
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
На часу физичког Јоци се мери $$n$$ $$(1 \le n )$$ пута време (у секундама) које му је потребно да претрчи $$30$$ метара. Написати програм који исписује у ком покушају је био најбржи.
Напомена: Уколико се најбоље време остварило више пута исписати када се последњи пут остварило.

## Улаз

Са стандардног улаза уноси се један цео број који представља број мерења ($$n$$)  а након тога и $$n$$ целих бројева у засебним редовима који представљају времена измерена у секундама.

## Излаз

На стандардни излаз исписати један цео број који означава у ком покушају је Јоца имао најбоље време.

## Пример

### Улаз

~~~
3
4
3
6
~~~

### Излаз

~~~
2
~~~
### Улаз

~~~
4
3
4
6
3
~~~

### Излаз

~~~
4
~~~
