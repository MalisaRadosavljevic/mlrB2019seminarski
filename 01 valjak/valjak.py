import math

#учитавање полупречника и висине ваљка
r = float(input())
H = float(input())

#израчунавање запремине
 v = r * r * H*math.pi;

#испис запремине 
print('%.3f'%v)