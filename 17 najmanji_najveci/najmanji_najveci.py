#функција која сортира низ целих бројева у растућем поретку
def sortiraj_rastuce(niz,n):
	for i in range(n-1):
		minimum = i
		for j in range(i + 1,n):
		   if(niz[j] < niz[minimum]):
			minimum = j
		if(minimum != i):
			pom = niz[i]
			niz[i] = niz[minimum]
			niz[minimum] = pom
		
#функција која сортира низ целих бројева у опадајућем поретку
def sortiraj_opadajuce(niz,n):
	for i in range(n-1):
		maksimum = i
		for j in range(i + 1,n):
		   if(niz[j] > niz[maksimum]):
			maksimum = j
		if(maksimum != i):
			pom = niz[i]
			niz[i] = niz[maksimum]
			niz[maksimum] = pom
		
n = int(input())
#направимо низ у коме ћемо чувати цифре
cifre = []
najveci = 0
najmanji = 0
#учитамо цифре у низ
for i in range(n):
	broj = input()
	cifre.append(broj)
#сортирамо цифре у опадајућем поретку
sortiraj_opadajuce(cifre,n)
for i in range(n-1):
	#формирамо највећи број са првих n-1 цифра
	najveci = (najveci + cifre[i]) * 10
#последњу цифру само додамо у збир
najveci = najveci + cifre[n-1]
print (najveci)

#сортирамо цифре у растућем поретку
sortiraj_rastuce(cifre,n)
for i in range(n-1):
	#формирамо најмањи број са првих n-1 цифра
	najmanji = (najmanji + cifre[i]) * 10
#последњу цифру само додамо у збир
najmanji = najmanji + cifre[n-1]
print (najmanji) 