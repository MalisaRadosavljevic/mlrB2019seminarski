---
title: Поштар
timelimit: 1.0 # u sekundama
memlimit: 64   # u MB
owner:  MalisaRadosavljevic   # vlasnik je onaj ko radi na zadatku
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
У улици има $$n$$ кућа нумерисаних бројевима од $$1$$ до $$n$$. Поштар дели писама само кућама чији је редни број прост. Написати програм који за унето $$n$$ исписује колико кућа поштар треба да обиђе?
Напомена: Прост број је природан број већи од $$1$$, дељив само бројем $$1$$ и самим собом.

## Улаз

Са стандардног улаза уноси се један цео број који представља број кућа у улици.

## Излаз

На стандардни излаз исписати један цео број који представља број кућа које поштар треба да обиђе.

## Пример

### Улаз

~~~
30
~~~

### Излаз

~~~
10
~~~