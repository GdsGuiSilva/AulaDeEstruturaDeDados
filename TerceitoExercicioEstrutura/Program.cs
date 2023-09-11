using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceitoExercicioEstrutura
{
    internal class Program
    {
        public int Soma(int num1,int num2)
        {
            return num1 + num2; 
        }
        public int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }
        public double Divisao(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Program calcula = new Program();
            Console.Write("Digite um valor :");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a operação :");
            string op = Console.ReadLine();
            Console.Write("Digite outro valor :");
            int v2 = int.Parse(Console.ReadLine());

            if("+".Equals(op))
            {
                Console.Write("A soma de {0} com {1} é {2}",v1,v2,calcula.Soma(v1,v2));
            }
            else if("-".Equals(op))
            {
                Console.Write("A subtração de {0} com {1} é {2}", v1, v2, calcula.Subtracao(v1, v2));
            }
            else if ("*".Equals(op))
            {
                Console.Write("A multiplicação de {0} com {1} é {2}", v1, v2, calcula.Multiplicacao(v1, v2));
            }
            else
            {
                Console.Write("A s de {0} com {1} é {2}", v1, v2, calcula.Divisao(v1, v2));
            }
        }
    }
}