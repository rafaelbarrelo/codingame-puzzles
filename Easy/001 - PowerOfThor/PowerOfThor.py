# Puzzle - Ragnarök - Power of Thor

import sys, math

# Auto-generated code below aims at helping you parse
# the standard input according to the problem statement.

# LX: the X position of the light of power
# LY: the Y position of the light of power
# TX: Thor's starting X position
# TY: Thor's starting Y position
LX, LY, TX, TY = [int(i) for i in input().split()]

# game loop
while 1:
    E = int(input()) # The level of Thor's remaining energy, representing the number of moves he can still make.
    
    if LY == TY and LX > TX:
        print("E")
    elif LY == TY and LX < TX:
        print("W")
    elif LY > TY and LX == TX:
        print("S")
    elif LY < TY and LX == TX:
        print("N")
    elif LY > TY and LX > TX:
        print("SE")
        TY += 1
        TX += 1
    elif LY > TY and LX < TX:
        print("SW")
        TY += 1
        TX -= 1
    elif LY < TY and LX > TX:
        print("NE")
        TY -= 1
        TX += 1
    elif LY < TY and LX > TX:
        print("NW")
        TY -= 1
        TX -= 1
