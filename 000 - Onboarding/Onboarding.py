import sys, math

# The code below will read all the game information for you.
# On each game turn, information will be available on the standard input, you will be sent:
# -> the total number of visible enemies
# -> for each enemy, its name and distance from you
# The system will wait for you to write an enemy name on the standard output.
# Once you have designated a target:
# -> the cannon will shoot
# -> the enemies will move
# -> new info will be available for you to read on the standard input.

class Enemy:
    def __init__(self, name, dist):
        self.name = name
        self.dist = dist

# game loop
while 1:
    count = int(input()) # The number of current enemy ships within range
    enemys = []
    for i in range(count):
        # enemy: The name of this enemy
        # dist: The distance to your cannon of this enemy
        enemy, dist = input().split()
        dist = int(dist)
        enemys.append(Enemy(enemy, dist))
    
    enemys = sorted(enemys, key=lambda en: en.dist)
    print(enemys[0].name)
    # Write an action using print
    # To debug: print("Debug messages...", file=sys.stderr)
