t_1 = int(input())
t_2 = int(input())
t_3 = int(input())

#� ��������� indikator ������ ����� ��� ���������, � � ��������� minimum ����� �����
#������������� �� �� ��� ������
minimum = t_1
indikator = 1

#������� �� ���� ���� �� ���
if(t_2 < minimum):
	minimum = t_2
	indikator = 2

#������� �� ���� ���� �� ��� � ����
elif(t_3 < minimum):
	minimum = t_3
	indikator = 3

if(indikator == 1):
	print ("Aca")
elif(indikator == 2):
	print ("Jova")
else:
	print ("Miki")