#//Puzzle - Kirk's Quest - The Descent

import sys, math

# game loop
while 1:
    SX, SY = [int(i) for i in input().split()]
    
    fire, maior = 0, 0
    for i in range(8):
        MH = int(input()) # represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
        if MH > maior:
            maior=MH
            fire=i
    
    # Write an action using print
    # To debug: print("Debug messages...", file=sys.stderr)
    if SX == fire:
        print("FIRE")
    else:
        print("HOLD")