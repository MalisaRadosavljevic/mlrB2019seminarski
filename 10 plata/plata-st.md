﻿---
title: Плата
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

Ученици оцењују свог наставника бројем од $$1$$ до $$10$$. Оцене од $$1$$ до $$3$$ значе да је наставник "Јако лош", оцене од $$4$$ до $$5$$ да је "Просечан", од $$6$$ до $$9$$ да је "Одличан", а оцена $$10$$ да је "Изузетан". Директор је одлучио да плата наставника зависи од дате оцене и то - ако је наставник изузетан, повећаће му плату за $$15$$ % , ако је јако лош, смањиће му плату за $$15$$ %. У свим осталим случајевима, наставнику ће се повећати плата за проценат који одговара оцени (нпр. за оцену $$5$$, плата се повећава за $$5$$ %). За унету оцену и основну плату, исписати какав је наставник и плату коју ће добити.



## Улаз


Са стандардног улаза се уносе два цела броја у засебним редовима:
 * $$O$$ оцена ученика $$(1 \le O<10)$$
 * $$P$$ основна плата $$(0 \le P)$$ 

## Излаз

На стандардни излаз у одвијеним редовима исписати прво поруку какав је наставник а након тога реалан број заокружен на три децимале коју педставља плату добити након оцењивања.

## Пример

### Улаз

~~~
6
45820
~~~

### Излаз

~~~
Одличан
48569.200
~~~