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
		

suma_k = 0
cene = []

S = int(input())
k = int(input())
n = int(input())
#������� ���� � ���
for i in range(n):
	cene.append(int(input()))
#��������� ��� ���� � ������� �������
sortiraj_rastuce(cene,n)
#�������� ����� � ������� ����
for i in range(k):
	suma_k = suma_k + cene[i]
#������� �� ���� ����� � ���� �� ������� ���� S
if(suma_k < S):
	print ("MOGUCE")
#������� �� ���� ����� � ve�a �� ������� ���� S
else:
	print ("NIJE MOGUCE")
	print (suma_k)