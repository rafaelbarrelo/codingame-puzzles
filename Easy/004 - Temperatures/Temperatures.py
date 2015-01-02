import sys, math

try:
    N = int(input()) # the number of temperatures to analyse
    TEMPS = input() # the N temperatures expressed as integers ranging from -273 to 5526

    #print(TEMPS, file=sys.stderr)
    valores = TEMPS.split()
    closer = int(valores[0])
    #print("Closer: " + str(closer), file=sys.stderr)
    for v in valores:
        x = int(v)
        if x > 0:
            closer = closer if (x > closer) and (x > closer * -1) else x
        elif x < 0:
            closer = closer if x < closer else x
        else:
            print(0)
        
    print(closer)
except EOFError:
    print(0)
