#��������� ������ � ������
k = float(input())
h = float(input())

#������������ BMI
BMI = k / (h * h)

if(BMI < 18.5):
	print ("NEUHRANJENOST")
elif(18.5 <= BMI < 30):
	print ("IDEALNA MASA")
else:
	print ("GOJAZNOST")