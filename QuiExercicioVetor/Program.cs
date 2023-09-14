using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 50;
            int[] vector = new int[TAM];
            int soma = 0;
            int aux = 0;
            int cont = 0;
            int value;
            do
            {
                Console.Write("DIGITE UM VALOR : ");
                value = int.Parse(Console.ReadLine());
                if (value < 0)
                {
                    break;
                }
                vector[cont] = value;
                aux = soma;
                soma = aux + vector[cont];
                cont++;
            }while(value > 0);
            float media = soma / cont;
            Console.Write("O VETOR TEM {0} POSIÇÕES. A MÉDIA DE TODOS OS VALORES É : {1}", cont, media);
        }
    }
}
