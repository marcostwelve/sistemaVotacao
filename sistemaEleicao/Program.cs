using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidato_A = 0;
            int candidato_B = 0;
            int voto;

            while(true)
            {
                try
                {
                    Console.WriteLine("****Cabine de votação****".ToUpper());
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Votos Candidato A: {candidato_A}");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Votos Candidato B: {candidato_B}");
                    Console.ResetColor();
                    Console.Write("Em qual candidato deseja votar:\n Aperte [1] para o candidato A\n Aperte [2] para o candidato B\n");
                    voto = int.Parse(Console.ReadLine());

                    if (voto == 1)
                    {
                        candidato_A += 1;
                    }
                    if (voto == 2)
                    {
                        candidato_B += 1;
                    }
                    Console.Clear();
                }
                
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
