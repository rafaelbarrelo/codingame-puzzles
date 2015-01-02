#Puzzle - Skynet - The Chasm
import sys, math

R = int(input()) # the length of the road before the gap.
G = int(input()) # the length of the gap.
L = int(input()) # the length of the landing platform.

jump = False
# game loop
while 1:
    S = int(input()) # the motorbike's speed.
    X = int(input()) # the position on the road of the motorbike.
    
    # To debug: print("Debug messages...", file=sys.stderr)
    if not jump:
        if X < R-1:
            jump_gap = G+1
            if S < jump_gap: print("SPEED")
            elif S > jump_gap: print("SLOW")
            else: print("WAIT")
        else:
            print("JUMP")
            jump = True
    else:
        print("SLOW")