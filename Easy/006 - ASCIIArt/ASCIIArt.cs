//Puzzle - ASCII Art
using System;
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
        
        Dictionary<string, string[]> letras = new Dictionary<string, string[]>();
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0";
                      
        for (int l=0; l < alfabeto.Length; l++){
            letras.Add(alfabeto.Substring(l, 1), new string[H]);
        }                      
        
        string saida = "";              
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            int pos = 0;
            while (ROW.Length > 0){
                string lt = alfabeto.Substring(pos, 1);
                letras[lt][i]=ROW.Substring(0, L);
                ROW = ROW.Substring(L);
                pos++;
            }
            for(int x=0; x < T.Length; x++){
                string lt = T.Substring(x, 1).ToUpper();
                if (letras.ContainsKey(lt)){
                    saida += letras[lt][i].ToString();    
                }else{
                    saida += letras["0"][i].ToString();
                }
            }    
            saida += Environment.NewLine;
        }
        
        Console.WriteLine(saida);
    }
}