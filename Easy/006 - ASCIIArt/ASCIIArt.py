#Puzzle - ASCII Art
import sys, math

L = int(input())
H = int(input())
T = input()

letras = {}
alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0"

for l in alfabeto: letras[l] = []

saida = ""
for i in range(H):
    ROW = input()
    pos = 0
    
    while(len(ROW) > 0):
        letras[alfabeto[pos]].append(ROW[0:L])
        ROW = ROW[L:]
        pos += 1
        
    for x in range(len(T)):
        lt = T[x].upper()
        if lt in letras:
            saida += letras[lt][i]
        else:
            saida += letras["0"][i]
    
    saida += "\n"

print(saida)