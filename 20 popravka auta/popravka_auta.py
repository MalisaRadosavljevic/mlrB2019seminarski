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
		

suma_k = 0
cene = []

S = int(input())
k = int(input())
n = int(input())
#учитамо цене у низ
for i in range(n):
	cene.append(int(input()))
#сортирамо низ цена у растућем поретку
sortiraj_rastuce(cene,n)
#саберемо првих к најнижих цена
for i in range(k):
	suma_k = suma_k + cene[i]
#уколико је сума првих к мања од понуђене суме S
if(suma_k < S):
	print ("MOGUCE")
#уколико је сума првих к veћa од понуђене суме S
else:
	print ("NIJE MOGUCE")
	print (suma_k)