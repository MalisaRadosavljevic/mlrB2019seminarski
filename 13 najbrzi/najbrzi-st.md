---
title: Најбржи
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

На часу физичког Аца, Јова и Мики мере време колико је коме потребно да претрчи $$100m$$. Написати програм који одређује ко је био најбржи ако је познато да је Аца трчао $$t_{1}$$ $$(s)$$, Joва $$t_{2}$$ $$(s)$$ и Мики $$t_{3}$$ $$(s)$$.
Напомена: Уколико два такмичара имају исто време исписати првог који је трчао.

## Улаз


Са стандардног улаза се уносе три цела броја у засебним редовима:
 * $$t_{1}$$ $$(s)$$ време које је Аца постигао
 * $$t_{2}$$ $$(s)$$ време које је Јова постигао
 * $$t_{3}$$ $$(s)$$ време које је Мики постигао

## Излаз

На стандардни излаз исписати име најбржег такмичара.

## Пример

### Улаз

~~~
13
15
11
~~~

### Излаз

~~~
Мики
~~~
### Улаз

~~~
12
13
12
~~~

### Излаз

~~~
Аца
~~~