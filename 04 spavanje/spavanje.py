#������� ��� �� ���� ���� � ������ ����� ������ �� ���� ������ �� �����
def u_minute (sati,minuti):
	return sati * 60 + minuti

#��������� ����������
h = int(input())
m = int(input())
hh = int(input())
mm = int(input())

#��������� ������ ������� � ��������
minuti_spavanja = u_minute(hh,mm) - u_minute(h,m)

#������� �� �� �� ������ ������ � ����� ���������� ������
if minuti_spavanja >= u_minute(2,15):
	print ("DOVOLJNO JE SPAVAO")
else:
	print ("NIJE DOVOLJNO SPAVAO")
