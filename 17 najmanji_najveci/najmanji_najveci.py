#������� ��� ������� ��� ����� ������ � ������� �������
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
		
#������� ��� ������� ��� ����� ������ � �������� �������
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
#��������� ��� � ���� ���� ������ �����
cifre = []
najveci = 0
najmanji = 0
#������� ����� � ���
for i in range(n):
	broj = input()
	cifre.append(broj)
#��������� ����� � �������� �������
sortiraj_opadajuce(cifre,n)
for i in range(n-1):
	#��������� ����� ��� �� ����� n-1 �����
	najveci = (najveci + cifre[i]) * 10
#������� ����� ���� ������ � ����
najveci = najveci + cifre[n-1]
print (najveci)

#��������� ����� � ������� �������
sortiraj_rastuce(cifre,n)
for i in range(n-1):
	#��������� ������ ��� �� ����� n-1 �����
	najmanji = (najmanji + cifre[i]) * 10
#������� ����� ���� ������ � ����
najmanji = najmanji + cifre[n-1]
print (najmanji) 