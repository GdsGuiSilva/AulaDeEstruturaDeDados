using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerExercicioFuncao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra :");
            String texto = Console.ReadLine();
            Console.Write(Maiuscula(texto));
        }
        static String Maiuscula(String minusculo)
        {
            minusculo = minusculo.ToUpper();
            return minusculo;
        }
    }
}
