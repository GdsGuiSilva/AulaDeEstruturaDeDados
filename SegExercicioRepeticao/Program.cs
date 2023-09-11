using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegExercicioRepeticao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random numaleatorio = new Random();
            int valor = numaleatorio.Next(1, 100);
            int cont = 0;
            int num = 0;
            do
            {
                Console.Write("Digite um valor :");
                num = int.Parse(Console.ReadLine());
                if(num == valor)
                {
                    break;
                }
                else if(num > valor)
                {
                    Console.WriteLine("VALOR É MENOR");
                }
                else
                {
                    Console.WriteLine("VALOR É MAIOR");
                }
                cont++;
            } while (num != valor);
            Console.Write("ACERTOU!! O numero é {0}. Tentativas : {1}",valor,cont);
        }
    }
}
