using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimExercicioCondicionais
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor :");
            int valor = int.Parse(Console.ReadLine());
            if(valor > 0)
            {
                Console.Write("Valor é positivo");
            }
            if(valor < 0)
            {
                Console.Write("Valor é negativo");
            }
            if(valor == 0 )
            {
                Console.Write("Valor é zero");
            }
        }
    }
}
