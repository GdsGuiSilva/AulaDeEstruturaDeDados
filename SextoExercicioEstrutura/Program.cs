using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SextoExercicioEstrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor :");
            string n = Console.ReadLine();
            int maior = Int32.Parse(n);
            int menor = Int32.Parse(n);
            int soma = 0;
            int cont = 0;

            while(!".".Equals(n))
            {
                soma += Int32.Parse(n);
                cont++;
                if(Int32.Parse(n) > maior)
                {
                    maior = Int32.Parse(n);
                }
                if(Int32.Parse(n) < menor)
                {
                    menor = Int32.Parse(n);
                }
                Console.Write("Digite um valor :");
                n = Console.ReadLine();
            }
            float media = soma / cont;
            Console.Write("Foram digitados {0} valores. O maior é {1} e o menor é {2}. A média de todos os valores digitados é {3}",
                cont,maior,menor,media);
        }
    }
}
