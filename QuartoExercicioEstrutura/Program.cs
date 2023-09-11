using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicioEstrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor :");
            int v1 = int.Parse(Console.ReadLine());
            int aux = v1;
            Console.Write("Digite outro valor");
            int v2 = int.Parse(Console.ReadLine());
            int soma = 0;
            while(v1 <= v2)
            {
                soma = soma + v1;
                v1++;
            }
            Console.Write("A soma do interalo entre {0} e {1} é {2}",aux,v2,soma);
        }
    }
}
