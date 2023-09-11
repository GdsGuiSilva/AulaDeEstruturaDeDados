using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriExercicioFuncao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do cícruclo :");
            double r = double.Parse(Console.ReadLine());
            Console.Write("A Área do círculo é {0}", AreaCirculo(r));
        }

        static double AreaCirculo(double raio) => 3.14 * Math.Pow(raio, 2);
    }
}