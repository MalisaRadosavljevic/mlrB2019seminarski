#��������� ����� � ������� �����
O = int(input())
P = int(input())

#��� �� ��������� ��������
if(O == 10):
	Plata = P + P*0.15
	print ("Izuzetan")
	print ('%.3f'%Plata)

 #��� �� ��������� ���� ���
elif(O <= 3):
	Plata = P - P*0.15
	print ("Jako los")
	print ('%.3f'%Plata)
#��� �� ��������� �������� ��� �������
else:
	Plata = P + P*(float(O)/100)
	
	#��� �� ��������� ��������
	if(O == 4 | O == 5):
		print ("Prosecan")
		print ('%.3f'%Plata)

	#��� �� ��������� �������
	else:
		print ("Odlican")
		print ('%.3f'%Plata)
