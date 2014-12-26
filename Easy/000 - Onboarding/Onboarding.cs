using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The code below will read all the game information for you.
 * On each game turn, information will be available on the standard input, you will be sent:
 * -> the total number of visible enemies
 * -> for each enemy, its name and distance from you
 * The system will wait for you to write an enemy name on the standard output.
 * Once you have designated a target:
 * -> the cannon will shoot
 * -> the enemies will move
 * -> new info will be available for you to read on the standard input.
 **/
class Player
{
    static void Main(String[] args)
    {
        string[] inputs;

        // game loop
        while (true)
        {
            int count = int.Parse(Console.ReadLine()); // The number of current enemy ships within range
            Console.Error.WriteLine("Count:" + count);
            
            Enemy[] enemys = new Enemy[count];
            
            for (int i = 0; i < count; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                enemys[i] = new Enemy(inputs[0], int.Parse(inputs[1]));
            }

            Array.Sort(enemys, delegate(Enemy en1, Enemy en2) {
                    return en1.Dist.CompareTo(en2.Dist);
                  });
                  
            Console.WriteLine(enemys[0].Name);
        }
    }
}

public class Enemy{
    public string Name;
    public int Dist;
    
    public Enemy(string name, int dist){
        this.Name = name;
        this.Dist = dist;
    }   
}