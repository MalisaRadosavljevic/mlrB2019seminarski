#учитавање оцене и основне плате
O = int(input())
P = int(input())

#ако је наставник изузетан
if(O == 10):
	Plata = P + P*0.15
	print ("Izuzetan")
	print ('%.3f'%Plata)

 #ако је наставник јако лош
elif(O <= 3):
	Plata = P - P*0.15
	print ("Jako los")
	print ('%.3f'%Plata)
#ако је наставник просечан или одличан
else:
	Plata = P + P*(float(O)/100)
	
	#ако је наставник просечан
	if(O == 4 | O == 5):
		print ("Prosecan")
		print ('%.3f'%Plata)

	#ако је наставник одличан
	else:
		print ("Odlican")
		print ('%.3f'%Plata)
