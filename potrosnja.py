#учитавање капацитета резервоара и пређеног пута са пуним резервоаром
kapacitet = int(input())
S = int(input())

#израчунавање потрошње
potrosnja = (float(kapacitet)/float(S))*100

#испис потрошње заокружен на три децимале
print ('%.3f'%potrosnja)