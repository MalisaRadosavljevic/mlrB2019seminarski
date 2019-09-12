#функција која за дате сате и минуте враћа колико је сати прошло од поноћи
def u_minute (sati,minuti):
	return sati * 60 + minuti

#учитавање променљивих
h = int(input())
m = int(input())
hh = int(input())
mm = int(input())

#одређивање дужине спавања у минутима
minuti_spavanja = u_minute(hh,mm) - u_minute(h,m)

#провера да ли је довољно спавао и испис одговарајуће поруке
if minuti_spavanja >= u_minute(2,15):
	print ("DOVOLJNO JE SPAVAO")
else:
	print ("NIJE DOVOLJNO SPAVAO")
