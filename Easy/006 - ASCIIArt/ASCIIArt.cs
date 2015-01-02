//Puzzle - ASCII Art
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        
        //Console.Error.WriteLine("T:" + T + " L: "+ L + " H: " + H);
        Dictionary<string, string[]> letras = new Dictionary<string, string[]>();
        string[] alfabeto = {"A", "B", "C", "D", "E", "F", "G",
                      "H", "I", "J", "K", "L", "M", "N",
                      "O", "P", "Q", "R", "S", "T", "U",
                      "V", "W", "X", "Y", "Z", "0"};
                      
        foreach(string lt in alfabeto){
            letras.Add(lt, new string[H]);
        }
                      
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            int pos = 0;
            while (ROW.Length > 0){
                string x = ROW.Substring(0, L);
                //Console.Error.WriteLine("X " + x.Replace(" ", "_"));
                letras[alfabeto[pos]][i]=x;
                ROW = ROW.Substring(L);
                pos++;
            }
        }
        
        string saida = "";
        for(int x = 0; x < H; x ++){
            for(int i=0; i < T.Length; i++){
                string lt = T.Substring(i, 1).ToUpper();
                //Console.Error.WriteLine(lt);
                if (letras.ContainsKey(lt)){
                    saida += letras[lt][x].ToString();    
                }else{
                    saida += letras["0"][x].ToString();
                }
                
            }    
            saida += Environment.NewLine;
        }
        
        Console.WriteLine(saida);
    }
}