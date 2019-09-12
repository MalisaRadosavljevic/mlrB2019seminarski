---
title: Судбински број
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

Судбински број је цифра од $$0$$ до $$9$$ и дефинише нашу судбину. Добија се сабирањем цифара броја дана, месеца и године рођења. Уколико се тада добије двоцифрени број потребно је сабрати цифре тог двоцифреног броја. Написати програм који за унети датум рођења исписује Судбински број.



## Улаз

Са стандардног улаза се уносе три цела броја у засебним редовима:
 * $$d$$ дан рођења $$(1≤d<31)$$
 * $$m$$ месец рођења $$(1≤m<12)$$
 * $$g$$ година рођења $$(0≤g<2500)$$
 
Напомена: Претпоставља се да је датум рођења исправно унет.

## Излаз

На стандардни излаз исписати један цео број који представља Судбински број.

## Пример

### Улаз

~~~
26
3
1993
~~~

### Излаз

~~~
6
~~~
