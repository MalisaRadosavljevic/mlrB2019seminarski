t_1 = int(input())
t_2 = int(input())
t_3 = int(input())

#у променљивој indikator чувамо редни број такмичара, а у променљивој minimum најбоље време
#претпоставимо да је Аца најбржи
minimum = t_1
indikator = 1

#уколико је Јова бржи од Аце
if(t_2 < minimum):
	minimum = t_2
	indikator = 2

#уколико је Мики бржи од Аце и Јове
elif(t_3 < minimum):
	minimum = t_3
	indikator = 3

if(indikator == 1):
	print ("Aca")
elif(indikator == 2):
	print ("Jova")
else:
	print ("Miki")