using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 5;
            int[] vector = new int[TAM];
           for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("INFORME UM NÚMERO :");
                vector[i] = int.Parse(Console.ReadLine());
            }
           for(int i = TAM - 1; i >= 0 ; i--)
            {
                Console.WriteLine("Os valores inversos : {0}", vector[i]);
            }
        }
    }
}