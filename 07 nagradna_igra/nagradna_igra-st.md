---
title: Наградна игра
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

Другарице Јелена и Нина учествују у наградној игри и победила је она другарица која прва сакупи $$20$$ бода. Бодови се освајају тако што се сакупљају чепови, а сваки чеп носи $$3$$ бода. Познато је да Јелена сваког дана сакупи $$m$$ чепа а Нина сваког другог дана по $$n$$ чепа. Која ће другарица освојити награду?




## Улаз

У првој линији стандардног улаза се налази цео број $$m$$ $$(0 \le m \le 10)$$, а у следећој линији цео број $$n$$ $$(0 \le n \le 10)$$.

## Излаз

На стандардни излаз исписати име другарице која је победила у игри или исписати НЕРЕШЕНО.

## Пример

### Улаз

~~~
2
3
~~~

### Излаз

~~~
Јелена
~~~
### Улаз

~~~
3
6
~~~

### Излаз
~~~
НЕРЕШЕНО
~~~