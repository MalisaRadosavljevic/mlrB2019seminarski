
n = int(input())
a = int(input())
b = int(input())

# ïğîèçâîä èíèöè¼àëèçó¼åìî íà íåóòğàë çà ìíîæåœå
proizvod = 1 
#èíäèêàòîğ íàì ñëóæè äà ïğîâåğèìî äà ëè ñå íåêè áğî¼ íàëàçè ó òğàæåíîì èíòåğâàëó è íà ïî÷åòêó ïğåòïîñòàâèìî äà íåìàìî áğî¼åâà ó òğàæåíîì èíòåğâàëó
indikator = False

#êîğèñòèìî ïåòšó äà ó÷èòàìî n áğî¼à
for i in range(n):

	#ó ñâàêî¼ èòåğàöè¼è ïåòšå ó÷èòàìî ¼åäàí áğî¼
	x = float(input())
	
	#àêî ¼å ó÷èòàíè áğî¼ ó òğàæåíîì èíòåğâàëó îíäà ãà äîäàìî ó ïğîèçâîä
	if(x >= a and x <= b):
		proizvod *= x

		#ïğîìåíèìî âğåäíîñò èíäèêàòîğà
		if (indikator == False):
			indikator = True

if (indikator == False):
	print ("NEMA BROJEVA U DATOM INTERVALU")

else:
	print ("%.3f"%proizvod)