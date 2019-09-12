---
title: Потроснја - опис решења 
---

## Смернице за алгоритам

Потрошњу аутомобила рачунамо по формули  $$potrosnja=$$ $$\frac{kapacitet}{predjeni \ put}100$$.


Како је променљива $$kapacitet$$ типа int приликом рачунања разлимка $$\frac{kapacitet}{predjeni \ put}$$ 
долази до целобројног дељења. Да би де то избегло потредно је променити тип (кастовати) променљивој $$kapacitet$$ из int у double 
а то се постиже на следећи начин $$potrosnja=$$ $$\frac{(double)kapacitet}{predjeni \ put}100$$.


