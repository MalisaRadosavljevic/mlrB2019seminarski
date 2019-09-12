---
title: Понашање
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


Ако се ученик лоше понаша на часовима (понашање се уноси као број од $$1$$ до $$10$$, све изнад $$5$$ је добро понашање), и не зна градиво (оцена на контролном је мања од $$4$$), професор ће га извести пред таблу и оценити га. Ако се ученик лоше понаша и зна градиво, биће истеран са часа. Ако се ученик добро понаша, професор ће га похвалити. Уноси се понашање, а ако је потребно и оцена са контролног. Треба исписати поруку "ИСПИТАТИ", "ИЗБАЦИТИ" или "ПОХВАЛИТИ".





## Улаз


У првој линији стандардног улаза уноси се цео број $$p$$ $$(1 \le p \le 10)$$ који представља понашање ученика, а по потреби у следећој линији цео број $$o$$ $$(1 \le o \le 5)$$ који представља оцену на контролном.

## Излаз

На стандардни излаз исписати поруку "ИСПИТАТИ", "ИЗБАЦИТИ" или "ПОХВАЛИТИ".

## Пример

### Улаз

~~~
6
~~~

### Излаз

~~~
ПОХВАЛИТИ
~~~
### Улаз

~~~
5
4
~~~

### Излаз
~~~
ИЗБАЦИТИ
~~~

