using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaExercicioCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um ano :");
            float ano = float.Parse(Console.ReadLine());
            if(ano % 100 != 0)
            {
                if(ano % 4 == 0 || ano % 400 == 0)
                {
                    Console.Write("É bissexto");
                }
            }
            else
            {
                Console.Write("Não é bissexto");
            }
        }
    }
}