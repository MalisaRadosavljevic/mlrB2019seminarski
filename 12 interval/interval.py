
n = int(input())
a = int(input())
b = int(input())

# �������� ������������� �� ������� �� ������
proizvod = 1 
#��������� ��� ����� �� ��������� �� �� �� ���� ��� ������ � �������� ��������� � �� ������� ������������� �� ������ ������ � �������� ���������
indikator = False

#��������� ���� �� ������� n ����
for i in range(n):

	#� ����� �������� ���� ������� ����� ���
	x = float(input())
	
	#��� �� ������� ��� � �������� ��������� ���� �� ������ � ��������
	if(x >= a and x <= b):
		proizvod *= x

		#��������� �������� ����������
		if (indikator == False):
			indikator = True

if (indikator == False):
	print ("NEMA BROJEVA U DATOM INTERVALU")

else:
	print ("%.3f"%proizvod)