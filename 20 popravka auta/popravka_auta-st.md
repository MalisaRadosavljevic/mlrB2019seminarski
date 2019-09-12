---
title: Поправка аута
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

Марко помаже тати да купи делове за поправку аута. Жели да од $$n$$ делова за које су познате цене купи $$k$$ $$(k<n)$$ најјефтинијих делова али да цена поруџбине не пређе задату суму $$S$$. Да ли је то могуће (исписати “МОГУЋЕ “ или “ НИЈЕ МОГУЋЕ”), а ако није могуће написати колико је новца потребно за $$k$$ најјефтинијих делова? 
Напомена: Претпоставити да неће бити више од $$200$$ делова.


## Улаз

Са стандардног улаза уноси се прво један цео број који представља дозвољену суму $$S$$, након тога у новом реду цео број $$k$$, након тога у новом реду цео број $$n$$ и у наредних $$n$$ редова цене делова (цели бројеви).

## Излаз

На стандардни излаз исписати поруку “МОГУЋЕ “ или “НИЈЕ МОГУЋЕ” а уколико није могуће у новом реду исписати један цео број који представља колико је новца потребно за $$k$$ најјефтинијих делова .

## Пример

### Улаз

~~~
2100
3
7
850
1550
730
1320
1360
600
2100
~~~

### Излаз

~~~
НИЈЕ МОГУЋЕ
2180
~~~


